using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Task
{
   public class Product
    {
        public string name;
        public int price;
        public int amount;

        public Product() { }

        public Product(string n, int p, int a)
        {
            name = n;
            price = p;
            amount = a;
        }
    }
}
