using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xml
{
    [Serializable]
    class Complex
    {
        public int a, b;
        public Complex() { }
        public Complex(int _a, int _b)
        {
            this.a = _a;
            this.b = _b;
        }
        public override string ToString()
        {
            return a + "/" + b;
        }
        public Complex Add(Complex c)
        {
            Complex res = new Complex(this.a * c.b + c.a * this.b, this.b * c.b);
            res.Simplify();
            return res;
        }
        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex res = new Complex(c1.a * c2.b + c1.b * c2.a, c1.b * c2.b);
            res.Simplify();
            return res;
        }
        public static Complex operator -(Complex c1, Complex c2)
        {
            Complex res = new Complex(c1.a * c2.b - c1.b * c2.a, c1.b * c2.b);
            res.Simplify();
            return res;
        }
        public static Complex operator *(Complex c1, Complex c2)
        {
            Complex res = new Complex(c1.a*c2.a, c2.b*c1.b);
            res.Simplify();
            return res;
        }
        public static Complex operator /(Complex c1, Complex c2)
        {
            Complex res = new Complex(c1.a * c2.b, c2.b * c1.a);
            res.Simplify();
            return res;
        }

        public void Simplify()
        {
            int _a = this.a;
            int _b = this.b;

            while(_a > 0 && _b > 0)
            {
                if(_a > _b)
                {
                    _a %= _b;
                }
                else
                {
                    _b %= _a;
                }
            }
            int gcd = _a + _b;
            this.a /= gcd;
            this.b /= gcd;
        }


    }
}
