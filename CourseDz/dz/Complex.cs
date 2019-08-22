using System;
using System.Collections.Generic;
using System.Text;

namespace dz
{
    public class Complex
    {
        public double X { get; }
        public double I { get; }

        public Complex(double x,double i)
        {
            X = x;
            I = i;
        }

        public Complex Plus(Complex a)
        {
            return new Complex(a.X + X, a.I + I);
        }
        public Complex Substruct(Complex a)
        {
            return new Complex(a.X -X, a.I - I);
        }
        public override string ToString()
        {
            if (I >= 0)
            {
                return $"{X}+{I}i";
            }
            else
            {
                return $"{X}-{I*(-1)}i";
            }
        }
    }
}
