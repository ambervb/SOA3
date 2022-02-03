using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOntwerpEnArchitectuur3.Models
{
    internal class MovieScreening
    {
        private DateTime dateAndTime;
        private double pricePerSeat;
        private Movie movie;

        public MovieScreening(Movie movie, DateTime dateAndTime, double pricePerSeat)
        {
            this.movie = movie;
            this.dateAndTime = dateAndTime;
            this.pricePerSeat = pricePerSeat;
        }

        public double GetPricePerSeat()
        {
            return pricePerSeat;
        }

        public override string ToString()
        {
            // TODO: tostring
            return base.ToString();
        }
    }
}
