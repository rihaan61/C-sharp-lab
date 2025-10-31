using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShoppimgManagementSystem
{
  public class product
    {
        public string modelname;
        public int price;
        public product()
        {
            modelname = "vivof21";
            price = 34887;
        }
    public void dispproduct()
        {
            Console.WriteLine($"Model Name={modelname}");
            Console.WriteLine($"Price of the product={price}");
        }
    }
}
