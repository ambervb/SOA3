using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class MovieTicket
    {
        private int rowNr;
        private int seatNr;
        private bool isPremium;
        public MovieScreening movieScreening;

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
            return movieScreening.GetPricePerSeat();
        }

        public override string ToString()
        {
            // TODO: tostring
            return base.ToString();
        }
    }
}
