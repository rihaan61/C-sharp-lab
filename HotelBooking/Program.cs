namespace HotelBooking
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-----------HOTEL CUSTOMER DETAILS--------------");
            Booking b = new Booking("Rajat");
            Booking b1 = new Booking("Jitesh");
            Booking b2 = new Booking("Romario");
            b.Book("tim",9);
            b.Hotel("Jitesh", 1, "Spa");
        }
    }
}
