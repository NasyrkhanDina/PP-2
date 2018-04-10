using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Compag\Desktop\kek.txt");
            string s = sr.ReadToEnd();
            string[] a = s.Split(' ');

            int mini = 10000;
            int maxi = -100;

            for (int i = 0; i < a.Length; i++)
            {
                int test = int.Parse(a[i]);
                bool k = true;

                if (test == 1)
                {
                    continue;
                }

                else
                {
                    for (int j = 2; j <= Math.Sqrt(test); j++)
                    {
                        if (test % j == 0)
                        {
                            k = false;
                        }
                    }
                }
                if (k)
                {
                    mini = Math.Min(test, mini);
                    maxi = Math.Max(test, maxi);
                }
            }
            StreamWriter sw = new StreamWriter(@"C:\Users\Compag\Desktop\answer.txt");
            sw.WriteLine(mini);
            sw.WriteLine(maxi);
            sr.Close();
            sw.Close();
            Console.ReadKey();
        }
    }
}
