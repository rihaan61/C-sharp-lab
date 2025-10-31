namespace OnlineShoppimgManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            available a = new available();
            a.disp();
            product p = new product();
            Console.WriteLine("------ details------");
            p.dispproduct();
            payment m = new payment(50000, "Do86bi84");
            Console.WriteLine("NOTICE PAYMENT CAN BE ONLY DONE THROUGH CREDIT CARD");
            m.disppayment();


        }
    }
}
