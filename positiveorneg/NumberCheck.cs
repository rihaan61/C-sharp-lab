using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace positiveorneg
{
    internal class NumberCheck
    {
        public int n = 8;
        public void Checknumb()
        {
            if (n > 0)
            {
                Console.WriteLine("The number is positive");
                
            }
            else if (n < 0)
            {
                Console.WriteLine("The number is negative");
                
            }
            else
            {
                Console.WriteLine("The number is zero");
                 
            }
        }
    }
}