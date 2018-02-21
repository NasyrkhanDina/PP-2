using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Task
{
    class Shop
    {
        public List<Product> list = new List<Product>();
        string name;

        public Shop() { }

        public Shop(string name)
        {
            this.name = name;
        }

        public void ShowShop(List<Shop> s)
        {
            Console.Clear();

            //foreach(Shop p in s)

            for(int i = 1; i <= s.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(40, 15);
                Console.WriteLine(i + "." + s[i]);
                Console.WriteLine("");
                Console.WriteLine("Please, choose one of them.");
            }
        }

        public void OpenShop()
        {
            Console.Clear();

            while (true)
            {
                Console.Clear();
                for(int i = 1; i <= list.Count; i++)
                {
                    Console.WriteLine(i + "." + list[i].name + " " + list[i].amount + " " + list[i].price);

                }
            }
        }
    }
}
