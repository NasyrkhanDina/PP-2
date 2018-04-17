using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace CarGame
{
    class Car
    {
        public GraphicsPath path;
        public int direction = 0;
        public int x, y;

        public Car(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Draw(Graphics g)
        {
            path = new GraphicsPath();
            int w = 60;
            int h = 10;
            path.AddRectangle(new Rectangle(x, y, w, h));
            path.AddPolygon(new[] {
                new Point(x + 5, y),//140
            new Point(x + w -5, y),//180
            new Point(x + w - 9, y-10), // 100
            new Point(x + 9, y - 10)}); //220
            path.AddEllipse(new Rectangle(x + 10, y + h - 2, 5, 5));
            path.AddEllipse(new Rectangle(x + w - 10, y + h - 2, 5, 5));


            g.DrawPath(new Pen(Color.Black, 3), path);

        }

        public void Move()
        {
            if(direction == 0)
            {
                x++;
            }
        }
    }
}
