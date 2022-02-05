using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareOntwerpEnArchitectuur3.Models
{
    internal class Movie
    {
        private string title;
        private List<MovieScreening> movieScreenings;

        public Movie(string title)
        {
            this.title = title;
            this.movieScreenings = new List<MovieScreening>();
        }

        public void AddScreening(MovieScreening screening)
        {
            movieScreenings.Add(screening);
        }

        public override string ToString()
        {
            // TODO: tostring
            return base.ToString();
        }
    }
}
