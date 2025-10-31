using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
  public  abstract class Desert
    {
        public abstract void Preparedesert();
        public void Addsugar()
        {
            Console.WriteLine("Added sugar in Desert class:");
        }
        public virtual void Serve()
        {
            Console.WriteLine("serveed desert in base class::");
        }
    }
}
