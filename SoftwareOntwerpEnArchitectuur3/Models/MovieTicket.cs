using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOntwerpEnArchitectuur3.Models
{
    internal class MovieTicket
    {
        private int rowNr;
        private int seatNr;
        private bool isPremium;
        private MovieScreening movieScreening;

        public MovieTicket(MovieScreening movieScreening, bool isPremiumReservation, int seatRow, int seatNr)
        {
            this.movieScreening = movieScreening;
            this.isPremium = isPremiumReservation;
            this.rowNr = seatRow;
            this.seatNr = seatNr;
        }

        public bool IsPremium()
        {
            return isPremium;
        }

        public double GetPrice()
        {
            // TODO: return price
            return 0;
        }

        public override string ToString()
        {
            // TODO: tostring
            return base.ToString();
        }
    }
}
