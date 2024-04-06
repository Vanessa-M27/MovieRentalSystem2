using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRentalSystem2BL
{
    public class Rental
    {

        public Movie Movie { get; }
        public int RentalDays { get; }
        public double RentalFee { get; }

        public Rental(Movie movie, int rentalDays)
        {
            Movie = movie;
            RentalDays = rentalDays;
            RentalFee = movie.RentalPrice * rentalDays;
        }
    }
}
