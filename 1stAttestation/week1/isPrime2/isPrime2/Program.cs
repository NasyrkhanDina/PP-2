using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace isPrime2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] a = s.Split(' ');

            for(int i = 0; i < a.Length; i++)
            {
                int nums = int.Parse(a[i]);

                bool k = true;

                if (nums == 1)
                {
                    continue;
                }
                else
                {
                    for(int j = 2; j <= Math.Sqrt(nums); j++)
                    {
                        if(nums % j == 0)
                        {
                            k = false;
                        }
                    }

                }
                if(k == true)
                {
                    Console.Write(a[i] + ' ');
                }
            }
            Console.ReadKey();

        }
        
    }
}
