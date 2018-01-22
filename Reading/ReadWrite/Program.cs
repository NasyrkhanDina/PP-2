using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace sr
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Compag\Desktop\PP-2\b.txt");
            string s = sr.ReadToEnd();

            Console.WriteLine(s);
            sr.Close();
            Console.ReadKey();

        }


