using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace Tank
{
    class Tank
    {
        public GraphicsPath path;
        public int direction = 0;
        public int x, y;

        public Tank(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Draw(Graphics g)
        {
            path = new GraphicsPath();
            int w = 30;
            int h = 30;
            path.AddRectangle(new Rectangle(x, y, w, h));
            path.AddEllipse(new Rectangle(x, y, w, h));
            if(direction == 0)
            {
                path.AddLine(x + w / 2, y + h / 2, x + w + w / 2, y + h / 2);

            }

            if(direction == 1)
            {
                path.AddLine(x + w / 2, y + h / 2, x + w / 2, y + h + h / 2);

            }

            g.DrawPath(new Pen(Color.Red, 3), path);
        }

        public void Move()
        {
            if(direction == 0)
            {
                x++;
            }
            if(direction == 1)
            {
                y++;
            }
        }
    }
}
