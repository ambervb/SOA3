using SoftwareOntwerpEnArchitectuur3.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SoftwareOntwerpEnArchitectuur3.Models
{
    internal class Order
    {
        private int orderNr;
        private bool isStudentOrder;
        private List<MovieTicket> movieTickets;

        public Order(int orderNr, bool isStudentOrder)
        {
            this.orderNr = orderNr;
            this.isStudentOrder = isStudentOrder;
        }

        public int GetOrderNr()
        {
            return orderNr;
        }

        public void AddSeatReservation(MovieTicket ticket)
        {
            movieTickets.Add(ticket);
        }

        public double CalculatePrice()
        {
            double totalOrder = 0;
            double discount = 0.0;
            int ticketCount = movieTickets.Count;
            DayOfWeek dayOfScreening = DateTime.Today.DayOfWeek;
         
            for(int i = 0; i < ticketCount; i++){
                MovieTicket ticket = movieTickets[i];
                double ticketPrice = ticket.GetPrice();
                if (isStudentOrder || (dayOfScreening >= DayOfWeek.Monday && dayOfScreening <= DayOfWeek.Thursday))
                {
                    if (i+1 % 2 == 0)
                    {
                        ticketPrice = 0;
                        totalOrder += ticketPrice;
                        break;
                    }
                }
                if (ticket.IsPremium())
                {
                    if (isStudentOrder)
                    {
                        ticketPrice += 2;
                    }
                    else
                    {
                        ticketPrice += 3;
                    }
                }
                totalOrder += ticketPrice;
            }
            if (ticketCount >= 6)
            {
                discount = 0.10;
            }

            return totalOrder - totalOrder * discount;
        }

        public void Export(TicketExportFormat ticketExportFormat)
        {
            String path = "";
            String orderText = "test";
            if (ticketExportFormat == TicketExportFormat.JSON)
            {
                orderText = JsonSerializer.Serialize(orderText);
            }

            File.WriteAllText(path, orderText);

        }
        
    }
}
