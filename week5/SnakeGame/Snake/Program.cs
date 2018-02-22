using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {

        static void F1(Snake snake)
        {
            FileStream fs = new FileStream("data.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, snake);
            fs.Close();
        }
        static Snake F2()
        {
            FileStream fs = new FileStream("data.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            Snake s = bf.Deserialize(fs) as Snake;
            fs.Close();
            return s;
        }


        static void F3(Wall wall)
        {
            FileStream fs = new FileStream("data1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, wall);
            fs.Close();
        }
        static Wall F4()
        {
            FileStream fs = new FileStream("data1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            Wall w = bf.Deserialize(fs) as Wall;
            fs.Close();
            return w;
        }

        static void F5(Food food)
        {
            FileStream fs = new FileStream("data2.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, food);
            fs.Close();
        }

        static Food F6()
        {
            FileStream fs = new FileStream("data2.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf = new BinaryFormatter();
            Food f = bf.Deserialize(fs) as Food;
            fs.Close();
            return f;
        }
        static int F7()
        {
            StreamReader sr = new StreamReader(@"C:\Users\Compag\Desktop\PP-2\week5\SnakeGame\Snake\points.txt");
            string s = sr.ReadLine();
            sr.Close();
            return int.Parse(s);
        }

        static void F8(int a)
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\Compag\Desktop\PP-2\week5\SnakeGame\Snake\points.txt");
            sw.WriteLine(a);
            sw.Close();

        }


        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 30);
            Console.CursorVisible = false;
            int level = 1;
            int score = 0;
            int points = F7();
            Wall wall = new Wall(level);
            Snake snake = new Snake();
            Food food = new Food();

            Console.WriteLine("If you want to start new game press R ");
            Console.WriteLine("If you want to continue last game press C");
            ConsoleKeyInfo key1 = Console.ReadKey();
          

            if(key1.Key == ConsoleKey.C)
            {
                snake = F2();
                wall = F4();
                points = F7();
                food = F6();
                score = snake.score;
            }

            Console.Clear();
            wall.WallDraw();
            snake.Draw();
            food.ShowFood();


            while (true)
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("High score : " + " " + points + "   Score: " + score + " " + "Level" + " " + level);
                Console.SetCursorPosition(0, 1);
                Console.WriteLine("If you want to safe current score, enter [5]");
                Console.SetCursorPosition(0, 2);
                Console.WriteLine("If you want to quit, enter [Escape] ");

                ConsoleKeyInfo info = Console.ReadKey();
                if (info.Key == ConsoleKey.UpArrow)
                {
                    snake.Move(0, -1);
                }
                if (info.Key == ConsoleKey.DownArrow)
                {
                    snake.Move(0, 1);
                }
                if (info.Key == ConsoleKey.LeftArrow)
                {
                    snake.Move(-1, 0);
                }
                if (info.Key == ConsoleKey.RightArrow)
                {
                    snake.Move(1, 0);
                }

                if (info.Key == ConsoleKey.R) // new game
                {
                    Console.Clear();

                    snake = new Snake();
                    level = 1;
                    score = 0;
                    wall = new Wall(level);
                }

                if(info.Key == ConsoleKey.NumPad5)
                {
                    snake.score = score;
                    F1(snake);
                    F3(wall);
                    F5(food);
                    F8(points);
                }
                if(info.Key == ConsoleKey.Escape)
                {
                    return;
                }
                if (snake.CollisionWithWall(wall) || snake.Collision())
                {
                    Console.Clear();
                    Console.SetCursorPosition(7, 7);
                    StreamReader sr = new StreamReader(@"C:\Users\Compag\Desktop\PP-2\week5\SnakeGame\Snake\gameover.txt");
                    string s = sr.ReadToEnd();
                    Console.WriteLine(s);
                    Console.WriteLine("High Score : " + points + "Your Score is " + score);

                    Console.ReadKey();
                    snake = new Snake();
                    level = 1;
                    wall = new Wall(level);
                    score = 0;

                   
                }
               /* while(!food.foodonwall(wall) || !food.foononsnake(snake))
                {
                    food.SetRandomPos();
                    Console.SetCursorPosition(food.x, food.y);
                    Console.Write("$");
                }
                */
                
                if (snake.Eat(food))
                {
                    snake.AddBody();
                    food.SetRandomPos();
                    score += 1;
                    points = Math.Max(points, score);
                    Console.SetCursorPosition(food.x, food.y);
                    Console.Write("$");
                    
                }
                if (score == level * 5)
                {
                    level++;
                    wall = new Wall(level);
                }

                Console.Clear();
                snake.Draw();
                food.ShowFood();
                wall.WallDraw();

            }
        }
    }
}
