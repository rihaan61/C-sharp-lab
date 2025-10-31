namespace VEhicleRentalApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            car c = new car("SUV","Toyota",5500,7,"deisel");
            Console.WriteLine("--------- HERE ARE THE DETAILS FOR THE RENTAL SERVICE OF ONE DAY--------");
            c.display();
            c.display1();
        }
    }
}
