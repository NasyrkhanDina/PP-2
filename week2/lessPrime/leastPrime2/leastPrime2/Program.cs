using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Compag\Desktop\kek.txt");
            string s = sr.ReadToEnd();
            string[] a = s.Split(' ');

            int mini = 10000;

            for (int i = 0; i < a.Length; i++)
            {
                int test = int.Parse(a[i]);
                bool kek = true;

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
                            kek = false;
                        }
                    }
                }
                if (kek)
                {
                    mini = Math.Min(test, mini);
                }
            }
            StreamWriter sw = new StreamWriter(@"C:\Users\Compag\Desktop\answer.txt");

            sw.Write(mini);

            sw.Close();
            sr.Close();



        }
    }
}
