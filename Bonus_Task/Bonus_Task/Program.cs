using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bonus_Task
{
    class Program
    {
      

        static void Main(string[] args)
        {

            Console.CursorVisible = false;
            Console.SetCursorPosition(20, 10);
            Product product = new Product();
            Shop shop = new Shop();
            List<Product> list = new List<Product>();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Welcome to our shop");
                Console.SetCursorPosition(20, 12);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Press [Probel] to continue ");
                ConsoleKeyInfo info = Console.ReadKey();
                if (info.Key == ConsoleKey.Spacebar)
                {

                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(0, 1);
                    Console.WriteLine("Please, choose a genre of book you are searching for");

                    /*StreamReader sr = new StreamReader(@"C:\Users\Compag\Desktop\PP-2\Bonus_Task\Bonus_Task\list.txt");
                    string a = sr.ReadToEnd();
                    */

                    shop.ShowShop(list);
                    shop.PokazShop();


                    Console.SetCursorPosition(0, 25);
                    Console.WriteLine("If you want to buy a book press [C]");
                    ConsoleKeyInfo keyInfo = Console.ReadKey();

                    if(keyInfo.Key == ConsoleKey.C)
                    {
                        Console.Clear();
                        string name = Console.ReadLine();
                        shop.BuyShop(name);

                    }


                }
                Console.ReadKey();

            }


            



           // DirectoryInfo info = new DirectoryInfo(@"C:\Users\Compag\Desktop\PP-2\Bonus_Task\Bonus_Task\Shop.txt");
        }
    }
}
