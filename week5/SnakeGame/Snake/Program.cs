using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
           // Console.SetWindowSize(35, 35);
           // int coo1 = random.Next(2, Console.WindowWidth - 2);
            //int coo2 = random.Next(2, Console.WindowHeight - 2);
            int level = 1;
            int score = 0;
            Wall wall = new Wall(level);
            Snake snake = new Snake();
            Food food = new Food();

            while (true)
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Score: " + score + " " + "Level" +" " + level);
                ConsoleKeyInfo info = Console.ReadKey();
                if(info.Key == ConsoleKey.UpArrow)
                {
                    snake.Move(0, -1);
                }
                if (info.Key == ConsoleKey.DownArrow)
                {
                    snake.Move(0, 1);
                }
                if (info.Key == ConsoleKey.LeftArrow)
                {
                    snake.Move(-1,0);
                }
                if (info.Key == ConsoleKey.RightArrow)
                {
                    snake.Move(1, 0);
                }

                if(info.Key == ConsoleKey.R) // new game
                {
                    snake = new Snake();
                    level = 1;
                    score = 0;
                    wall = new Wall(level);
                    //coo1 = random.Next(2, Console.WindowWidth - 2);
                    //coo2 = random.Next(2, Console.WindowHeight - 2);
                }
                if(snake.CollisionWithWall(wall) || snake.Collision())
                {
                    Console.Clear();
                    Console.SetCursorPosition(7, 7);
                    Console.WriteLine("GAME OVER!!!");
                    Console.ReadKey();
                    snake = new Snake();
                    level = 1;
                    wall = new Wall(level);
                   // level = 1;
                    score = 0;

                    // coo1 = random.Next(2, Console.WindowWidth - 2);
                    // coo2 = random.Next(2, Console.WindowHeight - 2);
                    //food = new Food();
                }
                /*if(!food.foodonwall(wall) || !food.foononsnake(snake))
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
                    Console.SetCursorPosition(food.x, food.y);
                    Console.Write("$");
                    
                   /* coo1 = random.Next(2, Console.WindowWidth - 2);
                    coo2 = random.Next(2, Console.WindowHeight - 2);
                    food = new Food(coo1, coo2);
    */            
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
