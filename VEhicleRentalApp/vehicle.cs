using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VEhicleRentalApp
{
    public class vehicle
    {
        public string model;
        public string brand;
        public int rentalprice;

        public vehicle(string Model,string Brand,int Rentalprice)
        {
            model=Model;
            brand=Brand;
            rentalprice=Rentalprice;
        }
        public void display()
        {
            Console.WriteLine("Model=" + model);
            Console.WriteLine("Brand="  + brand);
            Console.WriteLine("Rental Price per day="+rentalprice);
        }
    }
}