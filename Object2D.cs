using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06_bpc_oop
{
    public abstract class Object2D : I2D, IComparable
    {
        public abstract double SurfaceArea();
        public int CompareTo(Object obj)
        {
            if (obj == null)
                return 1;
            else if ((obj as Object2D) == null)
                throw new ArgumentException("The object entered to compare does not have the Object2D parent.");
            else
                return SurfaceArea().CompareTo(((Object2D)obj).SurfaceArea());
        }
    }
}
