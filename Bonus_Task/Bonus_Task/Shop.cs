using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bonus_Task
{
    class Shop
    {
        public List<Product> list = new List<Product>();
        string name;

        public Shop() { }


        public void PokazShop()
        {
            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].name + " " + list[i].amount + " " + list[i].price);
            }
        }

        public void OpenShop()
        {
            list = new List<Product>();
            StreamReader sr = new StreamReader(@"C:\Users\Compag\Desktop\PP-2\Bonus_Task\Bonus_Task\" + name + ".txt");
            int n = int.Parse(sr.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string ss = Console.ReadLine();
                string[] sss = ss.Split(' ');
                string name = sss[0];
                int amount = int.Parse(sss[1]);
                int price = int.Parse(sss[2]);
                list.Add(new Product(name, amount, price));

            }
            sr.Close();
        }

        public void ShowShop(List<Product> p)
        {
           for(int i = 1; i <= p.Count; i++)
            {
                int x = 0, y = 0;
                Console.SetCursorPosition(x,y);
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(i + "." + p[i]);
                x++;
                y++;
                
            }
           
        }

        public void BuyShop(string name)
        {
        for(int i = 0; i < list.Count(); i++)
            {
                if(name == list[i].name)
                {
                    list[i].amount--;
                    
                }

            }
        }
    }
}
