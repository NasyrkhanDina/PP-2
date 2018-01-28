using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lessPrime
{
    
    class Program
    {
        static bool isPrime(int n)
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;
            return true;
        }

        static void Main(string[] args)
        {
            string s1 = File.ReadAllText(@"C:\Users\Compag\Desktop\PP-2\week2\maxandmin\maximini.txt");
            string[] s2 = s1.Split(' ');
            int kek = 10000;
            foreach(string s in s2)
            {
                int ss = int.Parse(s);
                if ((isPrime(ss)) && ss < kek)
                    kek = ss;
            }

            StreamWriter sw = new StreamWriter(@"C:\Users\Compag\Desktop\PP-2\week2\maxandmin\leastprime.txt");
            sw.WriteLine(kek);
            sw.Close();
            Console.ReadKey();

        }
    }
}
