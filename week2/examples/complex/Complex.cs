using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complex
{
    class Complex
    {
        public int a, b;
        public Complex() { }
        public Complex(int x, int y)
    {
        this.a = x; // 5/6
        this.b = y; // 1/2
    }

    public Complex Add(Complex c)
    {
        Complex res = new Complex((((this.a * c.a) / a)*b + ((this.a * c.a) / c.a)*c.b), this.a * c.a);
        // 16 12
        return res;
    }

    public static Complex operator +(Complex c1, Complex c2)
    {
            Complex res = new Complex();
    }
        public static Complex operator +(Complex c1, Complex c2)
        {
            Complex res = new Complex(c1.a + c2.a, c1.b + c2.b);
            res.Simplify();
            return res;
        }
        public void Simplify()
        {
            int _a = this.a;
            int _b = this.b;
            while(_a > 0 && _b > 0)
            {
                if (_a > _b)
                    _a = _a & _b;
                else
                    _b = _b % _a;
            }
            int gcd = _a + _b;
            this.a /= gcd;
            this.b /= gcd;
        }
        public override string ToString()
        {
            return a + "/" + b;
        }
    }
}
