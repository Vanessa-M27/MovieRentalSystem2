using MovieRentalSystem2BL;

namespace MovieRentalSystem1BL
{
    public class Customer
    {
        public string Name { get; }
        public List<Rental> Rentals { get; }

        public Customer(string name)
        {
            Name = name;
            Rentals = new List<Rental>();
        }

        public void RentMovie(Movie movie, int days)
        {
            Rentals.Add(new Rental(movie, days));

        }
    }
}
