using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cart
{
   public class Item
    {
       public string itemName;
        public int itemId;
        public int itemQuantity;
        public int itemPrice;

       public List<Item> itemsList = new List<Item>()
        {
            new Item
            {
               itemName="Abc",
               itemId=1,
               itemQuantity=30,
               itemPrice=1000,
            },
            new Item
            {
                itemName="XYZ",
               itemId=2,
               itemQuantity=50,
               itemPrice=2000,

            }
        };

    }
}
