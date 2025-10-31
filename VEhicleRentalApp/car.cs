using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VEhicleRentalApp
{
    public class car:vehicle
    {
        public int seatno;
        public string fueltype;
        public car(string Model, string Brand, int Rentalprice, int Seatno, string Fueltype) : base(Model,Brand,Rentalprice)
        {
            seatno = Seatno;
            fueltype = Fueltype;
        }
    public void display1()
        {
            Console.WriteLine("No of seats available="+seatno);
            Console.WriteLine("fuel type=" + fueltype);
        }
    }
}
