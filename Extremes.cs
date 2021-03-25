using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv06_bpc_oop
{
    public class Extremes
    {
        public static T Largest<T>(T[] compared) where T : IComparable
        {
            if (compared.Length <= 0)
                throw new ArgumentException("The zero-length array entered.");
            
            T largest = compared[0];
            foreach (T index in compared)
            {
                if (largest.CompareTo(index) > 0)
                    largest = index;
            }
            return largest;
        }
        public static T Smallest<T>(T[] compared) where T : IComparable
        {
            if (compared.Length <= 0)
                throw new ArgumentException("The zero-length array entered.");

            T smallest = compared[0];
            foreach (T index in compared)
            {
                if (smallest.CompareTo(index) < 0)
                    smallest = index;
            }
            return smallest;
        }
    }
}
