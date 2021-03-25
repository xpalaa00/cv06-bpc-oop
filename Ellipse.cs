using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06_bpc_oop
{
    public sealed class Ellipse : Object2D
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

        private double b;
        public double B
        {
            get
            { return b; }
            set
            {
                if (value <= 0.0)
                    throw new ArgumentException("The argument cannot be negative or equal to zero.");
                b = value;
            }
        }
        public Ellipse(double a, double b)
        {
            A = a;
            B = b;
        }
        public override double SurfaceArea()
        {
            return Math.PI * A * B;
        }
        public override string ToString()
        {
            return String.Format("Ellipse: a = {0:f2}; b = {1:f2}; S = {2:f2}", A, B, SurfaceArea());
        }
    }
}
