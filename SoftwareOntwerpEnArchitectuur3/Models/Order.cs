using SoftwareOntwerpEnArchitectuur3.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            // TODO function
        }

        public double CalculatePrice()
        {
            // TODO: function
            return 0;
        }

        public void Export(TicketExportFormat ticketExportFormat)
        {
            // TODO: function
        }
    }
}
