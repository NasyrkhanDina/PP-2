using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(5, 6);
            Complex c2 = new Complex(1, 2);
            Complex add = c1 + c2;
            Complex min = c1 - c2;
            Complex multi = c1 * c2;
            Complex div = c1 / c2;

            Console.WriteLine(add);
            Console.WriteLine(min);
            Console.WriteLine(multi);
            Console.WriteLine(div);
            Console.ReadKey();
            
        }
    }
}
