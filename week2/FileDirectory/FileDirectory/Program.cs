using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace fileDirectory
{
    class Program
    {
        static void ex1()
        {
            FileInfo f = new FileInfo(@"C:\Users\Compag\Desktop\PP-2\week2\fileDirectory\example.txt");
            Console.WriteLine(f.FullName);
            Console.WriteLine(f.Name);
            Console.WriteLine(f.DirectoryName);
            Console.ReadKey();
        }

        static void ex2()
        {
            DirectoryInfo d = new DirectoryInfo(@"C:\Users\Compag\Desktop\PP-2");
            Console.WriteLine(d.FullName);
            Console.WriteLine(d.Name);
            Console.ReadKey();
        }

        static void ex3(string path)
        {
            DirectoryInfo d = new DirectoryInfo(path);
            FileInfo[] files = d.GetFiles();
            DirectoryInfo[] directories = d.GetDirectories();

            Console.WriteLine("files:");
                foreach(FileInfo file in files)
            {
                Console.WriteLine(file.Name);
            }
            Console.ReadKey();
        }

        static void Depth(int line)
        {
            for (int i = 0; i < line * 2; i++)
                Console.WriteLine(" ");
        }

        static void ex4(string path, int line)
        {
            DirectoryInfo d = new DirectoryInfo(path);
            FileInfo[] files = d.GetFiles();
            foreach (FileInfo file in files)
            {
                Depth(line);
                Console.WriteLine(file.Name);

            }
            DirectoryInfo[] directories = d.GetDirectories();
            foreach(DirectoryInfo directory in directories)
            {
                Depth(line);
                Console.WriteLine(directory.Name);
                ex4(directory.FullName, line + 1);
            }
        }

        static void Main(string[] args)
        {
            ex4(@"C:\Users\Compag\Desktop\PP-2", 0);
            Console.ReadKey();
        }
    }
}
