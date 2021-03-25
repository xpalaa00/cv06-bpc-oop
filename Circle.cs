using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06_bpc_oop
{
    public sealed class Circle : Object2D
    {
        private double radius;
        public double Radius
        {
            get
            { return radius; }
            set
            {
                if (value <= 0.0)
                    throw new ArgumentException("The argument cannot be negative or equal to zero.");
                radius = value;
            }
        }
        public Circle(double r)
        {
            Radius = r;
        }
        public override double SurfaceArea()
        {
            return Math.PI * Math.Pow(Radius, 2.0);
        }
        public override string ToString()
        {
            return String.Format("Circle: r = {0:f2}; S = {1:f2}", Radius, SurfaceArea());
        }
    }
}
