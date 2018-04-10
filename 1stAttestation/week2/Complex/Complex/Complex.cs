using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    class Complex
    {
        public int x, y;
        public Complex() { }

        public Complex(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex n = new Complex();

            n.x = c1.x + c2.x;
            n.y = c1.y + c2.y;
            n.Simplify();

            return n;

        }
        public static Complex operator -(Complex c1, Complex c2)
        {
            Complex n = new Complex();

            n.x = c1.x - c2.x;
            n.y = c1.y - c2.y;
            n.Simplify();

            return n;
        }
        public static Complex operator *(Complex c1, Complex c2)
        {
            Complex n = new Complex();

            n.x = c1.x * c2.x;
            n.y = c1.y * c2.y;
            n.Simplify();

            return n;
        }
        public static Complex operator /(Complex c1, Complex c2)
        {
            Complex n = new Complex();

            n.x = c1.x / c2.x;
            n.y = c1.y / c2.y;
           n.Simplify();

            
            return n;
        }

        public void Simplify()
        {
            int _x = this.y;
            int _y = this.y;

            while(_x > 0 && _y > 0)
            {
                if (_x > _y)
                    _x = _x % _y;
                else
                    _y = _y % _x;
            }

            int gcd = _x + _y;
            this.x /= gcd;
            this.y /= gcd;
        }




        public override string ToString()
        {
            return x + " " + y;
        }
    }
}
