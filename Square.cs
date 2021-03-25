using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06_bpc_oop
{
    public sealed class Square : Object2D
    {
        private double a;
        public double A
        {
            get
            { return a; }
            set
            {
                if (value <= 0.0)
                    throw new ArgumentException("The argument cannot be negative or equal to zero.");
                a = value;
            }
        }
        public Square(double a)
        {
            A = a;
        }
        public override double SurfaceArea()
        {
            return A * A;
        }
        public override string ToString()
        {
            return String.Format("Square: a = {0:f2}; S = {1:f2}", A, SurfaceArea());
        }
    }
}
