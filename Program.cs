using System;
using System.Linq;
using System.Collections.Generic;

namespace cv06_bpc_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] setA = new int[] {1, -5, 6, 3, 0};
            Console.WriteLine("{0:d}", Extremes.Largest(setA));
            Console.WriteLine("{0:d}", Extremes.Smallest(setA));
            Console.WriteLine();

            string[] setB = new string[] {"a4Fds", "F2f", "AFGfbL", "n", "56Ga"};
            Console.WriteLine("{0}", Extremes.Largest(setB));
            Console.WriteLine("{0}", Extremes.Smallest(setB));
            Console.WriteLine();

            Circle[] setC = new Circle[] {  new Circle(3.6),
                                            new Circle(6.8),
                                            new Circle(1.2),
                                            new Circle(4.9),
                                            new Circle(0.2) };
            Console.WriteLine("{0}", Extremes.Largest(setC));
            Console.WriteLine("{0}", Extremes.Smallest(setC));
            Console.WriteLine();

            Rectangle[] setD = new Rectangle[] {    new Rectangle(3.6, 2.4),
                                                    new Rectangle(6.8, 0.1),
                                                    new Rectangle(1.2, 5.4),
                                                    new Rectangle(4.9, 3.3),
                                                    new Rectangle(0.2, 7.4) };
            Console.WriteLine("{0}", Extremes.Largest(setD));
            Console.WriteLine("{0}", Extremes.Smallest(setD));
            Console.WriteLine();

            Object2D[] setE = new Object2D[] {  new Ellipse(4.3, 0.8),
                                                new Square(9.8),
                                                new Triangle(4.0, 6.2, 7.9),
                                                new Rectangle(5.8, 2.5),
                                                new Circle(1.1) };
            Console.WriteLine("{0}", Extremes.Largest(setE));
            Console.WriteLine("{0}", Extremes.Smallest(setE));
            Console.WriteLine();

            int[] setF = new int[] {1, 3, 5, 7, 9};
            IEnumerable<int> filteredSetF = from i in setF where i >= 4 && i <= 8 select i;
            foreach (int index in filteredSetF)
                Console.Write("{0} ", index);

            Console.ReadLine();
        }
    }
}
