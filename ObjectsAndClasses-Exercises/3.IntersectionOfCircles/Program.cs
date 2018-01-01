using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _3.IntersectionOfCircles
{
    class Circle
    {
        public double Radius { get; set; }
        public Point Center { get; set; }
    }

    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }

    class Program
    {
        static void Main()
        {
            var input1 = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var input2 = Console.ReadLine().Split().Select(double.Parse).ToArray();

            Circle c1 = new Circle
            {
                Center = new Point {X = input1[0], Y = input1[1]},
                Radius = input1[2]
            };

            Circle c2 = new Circle
            {
                Center = new Point { X = input2[0], Y = input2[1] },
                Radius = input2[2]
            };

            if (Intersect(c1, c2))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        static bool Intersect(Circle c1, Circle c2)
        {
            double d = Math.Sqrt(Math.Pow((c2.Center.X - c1.Center.X), 2) + Math.Pow((c2.Center.Y - c1.Center.Y), 2));

            if (d <= c1.Radius + c2.Radius)
            {
                return true;
            }

            return false;
        }
    }
}
