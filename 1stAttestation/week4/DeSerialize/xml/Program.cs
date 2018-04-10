using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace xml
{
    class Program
    {
       /* static XmlSerializer SerializiationFunc()
        {
            XmlSerializer xs = new XmlSerializer(typeof(Complex));
            FileStream fs = new FileStream("data.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            xs.Serialize(fs, c);
            fs.Close();
            return xs;
        }
        static void DeserializationFunc()
        {
            XmlSerializer xs1 = new XmlSerializer(typeof(Complex));
            FileStream dfs = new FileStream("data.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Complex t6 = xs1.Deserialize(dfs) as Complex;
            Console.WriteLine("Deserialization " + t6);
            dfs.Close();
        }
        */
        
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] s = line.Split(' ');
            string[] s1 = s[0].Split('/');
            string[] s2 = s[1].Split('/');

            int a1 = int.Parse(s1[0]);
            int a2 = int.Parse(s1[1]);
            int b1 = int.Parse(s2[0]);
            int b2 = int.Parse(s2[1]);

            Complex k = new Complex(a1, a2);
            Complex m = new Complex(b1, b2);

            Complex t1 = k.Add(m);
            Complex t2 = k + m;
            Complex t3 = k - m;
            Complex t4 = k * m;
            Complex t5 = k / m;

            
            FileStream fs = new FileStream("data.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, t2);
            fs.Close();

            bf = new BinaryFormatter();
            FileStream fss = new FileStream("data.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Complex t6 = bf.Deserialize(fss) as Complex;
            Console.WriteLine("Deserialization" + t6);
            Console.ReadKey();

        }
    }
}
