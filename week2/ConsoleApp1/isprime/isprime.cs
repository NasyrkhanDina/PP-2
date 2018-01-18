using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1
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
            for (int i = 0; i < args.Length; i++)

                if (isPrime(int.Parse(args[i])))
                    Console.WriteLine(args[i]);

            Console.ReadKey();

        }

    }
}
