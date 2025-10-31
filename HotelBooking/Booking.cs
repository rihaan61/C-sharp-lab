using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking
{
    public class Booking
    {
        public string service;
        public int days;
        private string guestname;
        public Booking(string name)
        {
            string guestname = name;
            int days = 3;
            Console.WriteLine($"guest name:{guestname} for  {days} days");
        }
        public void Book(string name, int days)
        {
            this.days = days;
            Console.WriteLine($"new guest:{name} for {days} days");
        }
        public void  Hotel(string name,int days,string service)
        {
            this.service = service;
            Console.WriteLine($"guest named {name} asked service for {days} days Service::{service} ");

        }
    }
}
