using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp13
{
    class Program
    {
        static void F1()
        {
            XmlSerializer xs = new XmlSerializer(typeof(Complex));
            FileStream fs = new FileStream("test.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            Complex c = new Complex();

            try
            {
                xs.Serialize(fs, c);
            }
            catch (Exception e)
            {
                Console.WriteLine("error");
            }
            finally
            {
                fs.Close();
            }
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine(); // 1/2 and 3/4

            string[] s1 = s.Split(' ');

            string a = s1[0]; // 1/2
            string b = s1[1]; // 3/4

            string[] c = s1[0].Split('/'); // c[0] = 1; c[1] = 2;
            string[] d = s1[1].Split('/'); // d[0] = 3; d[1] = 4;

            Complex cpx = new Complex(int.Parse(c[0]), int.Parse(c[1]));
            Complex cpx2 = new Complex(int.Parse(d[0]), int.Parse(d[1]));

            Complex total = cpx.Add(cpx2);

            F1();

            // Console.WriteLine(total);

            Console.ReadKey();
        }
    }
}
