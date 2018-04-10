using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Bonus_Task
{
    class Program
    {
        static void F1(Shop shop)
        {
            FileStream fs = new FileStream(@"data.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xml = new XmlSerializer(typeof(Shop));
            xml.Serialize(fs, shop);
            fs.Close();
        } 
        static Shop F2()
        {
            FileStream fs = new FileStream(@"data.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xml = new XmlSerializer(typeof(Shop));
            Shop sh = xml.Deserialize(fs) as Shop;
            fs.Close();
            return sh;

        }
      

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

                Console.WriteLine("If you want to continue your last shop, please press [1]");

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
                    Console.WriteLine("If you want to buy a book press [C] after write the name of the book");
                    Console.SetCursorPosition(0, 27);
                    Console.WriteLine("If you want to save changes press [2]");
                    ConsoleKeyInfo keyInfo = Console.ReadKey();

                    if(keyInfo.Key == ConsoleKey.C)
                    {
                        Console.Clear();
                        string name = Console.ReadLine();
                        shop.BuyShop(name);
                        shop.TheAmountOfBooks();

                    }
                    if(keyInfo.Key == ConsoleKey.NumPad2)
                    {
                        F1(shop);
                    }
                  


                }
                if (info.Key == ConsoleKey.NumPad1)
                {
                    shop = F2();
                }


                Console.ReadKey();

            }
        }
    }
}
