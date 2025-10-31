using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructorexdemo
{
    public class democons
    {
        static int age;

        static  democons()
        {
            age = 28;
            Console.WriteLine("Hello");
        }
        public  static void say()
        {
            Console.WriteLine("Age="+age);
        }
    }
}
