using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_4
{
    public class Complex
    {
        public int x, y;
        public Complex() { }

        public Complex(int _x, int _y)
        {
            this.x = _x;
            this.y = _y;
        }

        public Complex Add(Complex c)
        {
            Complex res = new Complex(this.x * c.y + c.x * this.y, this.y * c.y);

            return res;
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex res = new Complex(c1.x + c2.y, c1.x + c2.y);

            return res;
        }

        public static Complex operator *(Complex c1, Complex c2)
        {
            Complex res = new Complex(c1.x * c2.x, c1.y * c2.y);

            return res;
        }

        public static Complex operator /(Complex c1, Complex c2)
        {
            Complex res = new Complex(c1.x / c2.x, c1.y / c2.y);

            return res;
        }

        public override string ToString()
        {
            return x + "/" + y;
        }
    }
}
