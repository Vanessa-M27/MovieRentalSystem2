using MovieRentalSystem1BL;
using MovieRentalSystem2BL;
namespace MovieRentalSystem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("Welcome to Movie Rental!");
            Console.WriteLine("Please proceed to Log In your account to see the Available Renting Movies");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("---Log In your Account---");

            Console.WriteLine("Enter Username: ");
            Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            Console.ReadLine();
            Console.WriteLine("~~Log In Successfully~~");
            Console.WriteLine("---------------------------------------------------------------------------");
            Customer customer = new Customer("Customer");
            Movie movie1 = new Movie(" Jurassic Park franchise", "Adventure", 50.00);
            Movie movie2 = new Movie("Marvel universe", "Super hero", 350.00);
            Movie movie3 = new Movie("Toy Story", "Animation", 100.00);
            Movie movie4 = new Movie("Barbie", "Fantasy", 110.00);
            Movie movie5 = new Movie("Parasyte", "Science fiction horror", 120.00);
            // rental days
            Console.WriteLine("Available Renting Movies for you:");

            customer.RentMovie(movie1, 7);
            customer.RentMovie(movie2, 12);
            customer.RentMovie(movie3, 15);
            customer.RentMovie(movie4, 14);
            customer.RentMovie(movie5, 10);
            //  rental details
            Console.WriteLine("\nRental Details:");
            foreach (var rental in customer.Rentals)
            {
                Console.WriteLine($"\nMovie: {rental.Movie.Title}, {rental.Movie.Genre}, " +
                                  $"\nRental Days: {rental.RentalDays},\nRental Fee: Php {rental.RentalFee}");
            }


        }
    }
    }

