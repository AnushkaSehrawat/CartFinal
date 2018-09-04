using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cart
{
    class payment : Ipayment
    {
        public payment(int paymentmode)
        {

            if (paymentmode == 1)
            {
                Console.WriteLine("Enter cardno:");
                int cardno = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter cvv:");
                int cv = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter Expiry Date:");
                int expirydate = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter Card Name:");
                string cardname = Console.ReadLine();

                new card().Payment(cardno, cv, expirydate, cardname);

            }
            else
            {
                pay();
            }

        }

        public void pay()
        {
            // code for payment
        }
    }
}
