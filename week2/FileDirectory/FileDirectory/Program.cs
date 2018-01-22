using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileDirectory
{
    class Program
    {
        static void ex1()
        {
            FileInfo f = new FileInfo(@"C:\Users\Compag\Desktop\PP-2\text.txt");
            Console.WriteLine(f.Name);
            Console.WriteLine(f.FullName);
            Console.WriteLine(f.DirectoryName);
            Console.ReadKey();
        }
        static void ex2()
        {
            DirectoryInfo d = new DirectoryInfo(@"C: \Users\Compag\Desktop\PP - 2");
            Console.WriteLine(d.Name);
            Console.WriteLine(d.FullName);
            Console.ReadKey();
        }
            static void WriteEmptySpaces(int level)
            {
                for (int i = 0; i < level * 4; i++)
                    Console.Write(" ");

            }

            static void Ex4(string path, int level)
            {
                DirectoryInfo d = new DirectoryInfo(path);
                FileInfo[] files = d.GetFiles();
                foreach (FileInfo file in files)
                {
                    WriteEmptySpaces(level);
                    Console.WriteLine(file.Name);
                }
                DirectoryInfo[] directories = d.GetDirectories();
                foreach (DirectoryInfo directory in directories)
                {
                    WriteEmptySpaces(level);
                    Console.WriteLine(directory.Name);
                    Ex4(directory.FullName, level + 1);
                }
            }
            static void Main(string[] args)
            {
                Ex4(@"c:\users\a.akshabaev\desktop\test", 0);
                Console.ReadKey();
            }
        }
    }
}