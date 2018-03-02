using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Midterm
{
    class Car
    {
        public int x, y, speed;

        public Car(int _x, int _y, int _speed)
        {
            x = _x;
            y = _y;
            speed = _speed;
        }

        public void DrawCar()
        {
            Console.SetCursorPosition(x, y);
            StreamReader sr = new StreamReader(@"C:\Users\Compag\Desktop\PP-2\Midterm\cars.txt");
            string s = sr.ReadToEnd();
            Console.WriteLine(s);
        }

        public void Move()
        {
            x += speed;
        }

        public void Up()
        {
            y--;
        }

        public void Down()
        {
            y++;
        }
    }
}
