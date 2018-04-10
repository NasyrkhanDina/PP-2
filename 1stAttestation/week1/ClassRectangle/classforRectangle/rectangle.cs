using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classforRectangle
{
    class Rectangle
    {
        public int width, height, area, per;

        public Rectangle(int w, int h)
        {
            this.width = w;
            this.height = h;
            findArea();
            findPer();
        }

        public void findArea()
        {
            area = width * height;
        }
        public void findPer()
        {
            per = 2 * (width + height);
        }

        public override string ToString()
        {
            return area + " " + per;
        }

    }
}
