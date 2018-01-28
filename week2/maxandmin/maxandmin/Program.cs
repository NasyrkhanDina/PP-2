using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace maxandmin
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1;
            s1 = File.ReadAllText(@"C:\Users\Compag\Desktop\PP-2\week2\maxandmin\maximini.txt");
            string[] s2 = s1.Split(' ');
            int maxi = -10000;
            int mini = 10000;

           /* for(int i = 0; i < s2.Length; i++)
            {
                maxi = Math.Max(maxi, int.Parse(s2));
                mini = Math.Min(mini, int.Parse(s2));
            }
            */
            foreach(string s in s2)
            {
                maxi = Math.Max(maxi, int.Parse(s));
                mini = Math.Min(mini, int.Parse(s));
            }
            Console.WriteLine("Maximum is equal to" + " " + maxi);
            Console.WriteLine("Minimum is equal to" + " " + mini);
            Console.ReadKey();
        }
    }
}
