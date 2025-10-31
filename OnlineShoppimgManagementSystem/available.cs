using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace OnlineShoppimgManagementSystem
{
    public class available
    {
        public string model;

        public void disp()
        {
            Console.WriteLine("enter the model name:");
            string model = Console.ReadLine();
        if(model == "vivo")
            {
                Console.WriteLine("Selected model== vivo");
            }
            else
            {
                if (model == "oppo")
                {
                    Console.WriteLine("selected model==oppo");
                }
            }
        }
    }
}