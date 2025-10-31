namespace NumberSquare
{
    public class Program
    {
        static void Main(string[] args)
        {
            Squarecalculator c = new Squarecalculator();
            int square = c.func1();
            Console.WriteLine(" Square of  "    + c.n +   "  is  "   + square);
        }
    }
}
