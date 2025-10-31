using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace OnlineShoppimgManagementSystem
{
  public class payment
    {
        public int amount;
        public string creditcardno;
       public payment(int Amount,string Creditcardno)
        {
            this.amount = Amount;
            this.creditcardno = Creditcardno;
        }
      
    public void disppayment()
        
            {
                
            
            Console.WriteLine($"price of the product={amount}");
            Console.WriteLine($"Credit cardno{creditcardno}");
        }
    }
}
