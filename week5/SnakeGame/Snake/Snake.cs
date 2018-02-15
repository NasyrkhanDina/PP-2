using System;
using System.Collections.Generic;

namespace Snake
{
    class Snake
    {
        public List<Point> body;
        public string sign;
        ConsoleColor color;
     
        public Snake()
        {
            body = new List<Point>();
            body.Add(new Point(5, 5));
            color = ConsoleColor.Yellow;
            sign = "*";
           
        }
       public void AddBody()
        {
            body.Add(new Point(0, 0));
        }
       
        public void Move(int dx, int dy)
        {
           
            for(int i = body.Count - 1; i > 0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }
            body[0].x += dx;
            body[0].y += dy;

            if (body[0].x < 1)
                body[0].x = Console.WindowWidth - 1;
            if (body[0].x > Console.WindowWidth - 1)
                body[0].x = 1;

            if (body[0].y < 1)
                body[0].y = Console.WindowHeight - 1;
            if (body[0].y > Console.WindowHeight - 1)
                body[0].y = 1;
        }
        public void Draw()
        {
            for (int i = 0; i < body.Count; i++)
            {
                if (i == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                }
                else
                    Console.ForegroundColor = color;

               // Console.CursorVisible = false;
                Console.SetCursorPosition(body[i].x, body[i].y);
                Console.Write(sign);

            }
        }
        public bool CollisionWithWall(Wall w)
        {
            foreach(Point p in w.body)
            {
                if (p.x == body[0].x && p.y == body[0].y)
                    return true;
            }
            return false;
        }
        public bool Collision() // Snake's collision with its own body
        {
            for(int i = 1; i < body.Count; i++)
            {
                if (body[0].x == body[i].x && body[0].y == body[i].y)
                    return true;
            }
            return false;
        }
      
        public bool Eat(Food f)
        {
            if(body[0].x == f.x && body[0].y == f.y)
            {
               // body.Add(new Point(0, 0));
                return true;
            }
            return false;
        }

        /*public bool NewLevel(int level)
        {
            if (body.Count >= level * 5)
            {
                return true;
            }
            return false;
        }
        */

    }
}
