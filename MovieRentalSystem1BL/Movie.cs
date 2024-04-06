using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalSystem2BL
{
    public class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public double RentalPrice { get; set; }


        public Movie(string title, string genre, double rentalPrice)
        {
            Title = title;
            Genre = genre;
            RentalPrice = rentalPrice;

        }
    }
}
