using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cart
{
    interface Icard:Ipayment
    {

      
        void Payment(int cardno, int cv, int expirydate, string cardname);
  
    }
}
