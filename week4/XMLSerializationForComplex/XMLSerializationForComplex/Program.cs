using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XMLSerializationForComplex
{
   
    class Program
    {
        static void Xmls()
        {
            XmlSerializer xs = new XmlSerializer(typeof(Complex));
            FileStream fs = new FileStream("dat.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            string line = Console.ReadLine();
            string[] s = line.Split(' ');
            string a = s[0];
            string b = s[1];
            string[] d = a.Split('/');
            string[] v = b.Split('/');

            int a1 = int.Parse(d[0]);
            int a2 = int.Parse(d[1]);
            int b1 = int.Parse(v[0]);
            int b2 = int.Parse(v[1]);

            Complex t1 = new Complex(a1, a2);
            Complex t2 = new Complex(b1, b2);
            Complex t3 = t1.Add(t2);
            Complex t4 = t1 - t2;
            Complex t5 = t1 * t2;
            Complex t6 = t1 / t2;
            t3.Simplify();
            t4.Simplify();
            t5.Simplify();
            t6.Simplify();
            
            try
            {
                xs.Serialize(fs, t3);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                fs.Close();
            }
            Console.ReadKey();
        }
        
        static void Deserialization()
        {
            string line = Console.ReadLine();
            string[] s = line.Split(' ');
            string a = s[0];
            string b = s[1];
            string[] d = a.Split('/');
            string[] v = b.Split('/');

            int a1 = int.Parse(d[0]);
            int a2 = int.Parse(d[1]);
            int b1 = int.Parse(v[0]);
            int b2 = int.Parse(v[1]);

            Complex t1 = new Complex(a1, a2);
            Complex t2 = new Complex(b1, b2);
            Complex t3 = t1.Add(t2);
            Complex t4 = t1 - t2;
            Complex t5 = t1 * t2;
            Complex t6 = t1 / t2;
            t3.Simplify();
            t4.Simplify();
            t5.Simplify();
            t6.Simplify();
            
            XmlSerializer xs = new XmlSerializer(typeof(Complex));
            FileStream fs = new FileStream("data.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Complex c = xs.Deserialize(fs) as Complex;
            fs.Close();
            Console.WriteLine("Multplication" + "  " + t5);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Xmls();
            Deserialization();

        }
    }
}
