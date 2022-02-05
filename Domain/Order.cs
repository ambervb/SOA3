using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Domain
{
    public class Order
    {
        private int orderNr;
        private bool isStudentOrder;
        private List<MovieTicket> movieTickets;

        public Order(int orderNr, bool isStudentOrder)
        {
            this.orderNr = orderNr;
            this.isStudentOrder = isStudentOrder;
            this.movieTickets = new List<MovieTicket>();
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

            for (int i = 0; i < ticketCount; i++)
            {
                MovieTicket ticket = movieTickets[i];
                double ticketPrice = ticket.GetPrice();
                // TODO: Dit hoort niet public te zijn
                DayOfWeek dayOfScreening = ticket.movieScreening.dateAndTime.DayOfWeek;
                if (isStudentOrder || (dayOfScreening >= DayOfWeek.Monday && dayOfScreening <= DayOfWeek.Thursday))
                {
                    if ((i + 1) % 2 == 0)
                    {
                        ticketPrice = 0;
                        totalOrder += ticketPrice;
                        continue;
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

        public void Export(EnumTicketExportFormat ticketExportFormat)
        {
            String path = "";
            String orderText = "test";
            if (ticketExportFormat == EnumTicketExportFormat.JSON)
            {
                orderText = JsonSerializer.Serialize(orderText);
            }

            File.WriteAllText(path, orderText);
        }
    }
}
