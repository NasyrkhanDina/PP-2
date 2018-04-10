using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Midterm
{
    class Program { 


        public static List<Car> cars = new List<Car>();
        public static int cnt;

        public static void ShowAllCars()
        {
            StreamReader sr = new StreamReader(@"C:\Users\Compag\Desktop\PP-2\Midterm\input.txt");

            cnt = int.Parse(sr.ReadLine());

            for(int i = 0; i < cnt; i++)
            {
                string a = sr.ReadLine();
                string[] b = a.Split(' ');
                Car car = new Car(int.Parse(b[0]), int.Parse(b[1]), int.Parse(b[2]));
                cars.Add(car);
            }

            sr.Close();

        }
        public static int wall = 100;
        public static double min = (wall - cars[0].x) * 1.0 / cars[0].speed;
        public static int index = 0;

        public static void CalculateMin()
        {
            min = (wall - cars[0].x) * 1.0 / cars[0].speed;
            index = 0;
            for(int i = 0; i < cnt; i++)
            {
                if (min > (wall - cars[0].x) * 1.0 / cars[0].speed)
                {
                    min = (wall - cars[0].x) * 1.0 / cars[0].speed;
                    index = i;
                }
            }
        }

        public static void MoveAllCars()
        {
            while (true)
            {
                Console.Clear();
                for (int i = 0; i < cnt; i++)
                {
                    cars[i].DrawCar();
                    cars[i].Move();


                }
                Thread.Sleep(1000);
            }
        }

        static void Main(string[] args)
        {
            ShowAllCars();
            CalculateMin();
            StreamWriter sw = new StreamWriter("output.txt");
            sw.Write(index);
            sw.Close();

            Thread thread = new Thread(MoveAllCars);
            thread.Start();

            while (true)
            {
                ConsoleKeyInfo info = Console.ReadKey();

                if (info.Key == ConsoleKey.UpArrow)
                    cars[1].Up();
                if (info.Key == ConsoleKey.DownArrow)
                    cars[1].Down();
            }

        }
    }
}
