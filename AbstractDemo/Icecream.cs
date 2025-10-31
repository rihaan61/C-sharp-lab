using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    public  class Icecream : Desert
    {
        public override void Preparedesert()
        {
            Console.WriteLine("Prepared desert for Icecream class::");
        }
        public override void Serve()
        {
            Console.WriteLine("Serving for Icecream class");
            base.Serve();
        }
    }
}
