using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedComplex
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] ss = s.Split(' ');
            string a = ss[0];
            string b = ss[1];
            string[] c = a.Split('/');
            string[] d = b.Split('/');

            int a1 = int.Parse(c[0]);
            int a2 = int.Parse(c[1]);
            int b1 = int.Parse(d[0]);
            int b2 = int.Parse(d[1]);

            Complex kek1 = new Complex(a1, a2);
            Complex kek2 = new Complex(b1, b2);

            Complex kek3 = kek1.Add(kek2);
            Complex kek4 = kek1 + kek2;
            Complex kek5 = kek1 - kek2;
            Complex kek6 = kek1 * kek2;
            Complex kek7 = kek1 / kek2;

            Console.WriteLine("add" + " " + kek3);
            Console.WriteLine("plus" + " " + kek4);
            Console.WriteLine("minus" + " " + kek5);
            Console.WriteLine("multiply" + " " + kek6);
            Console.WriteLine("division" + " " + kek7);

            Console.ReadKey();
        }
    }
}
