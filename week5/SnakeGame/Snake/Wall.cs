using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Snake
{
    class Wall
    {
        public List<Point> body;
        public string sign;
        public ConsoleColor color;

        public void Level(int level)
        {
            StreamReader sr = new StreamReader(@"C:\Users\Compag\Desktop\PP-2\week5\SnakeGame\Snake\level" + level + ".txt");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                for(int j = 0; j < s.Length; j++)
                {
                    if (s[j] == '*')
                        body.Add(new Point(j, i));
                }
            }
            sr.Close();
        }
        public Wall(int level)
        {
            body = new List<Point>();
            sign = "#";
            color = ConsoleColor.Magenta;
            Level(level);
        }
        public void Draw()
        {
            Console.ForegroundColor = color;
            foreach(Point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
            }
        }
}
