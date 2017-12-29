using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace _5.ClosestTwoPoints
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    class Program
    {
        static void Main()
        {
            Point[] points = ReadPoints();
            Point[] closestTwoPoints = FindClosestTwoPoints(points);

            Console.WriteLine("{0:F3}", CalculateDistance(closestTwoPoints[0], closestTwoPoints[1]));

            PrintPoint(closestTwoPoints[0]);
            PrintPoint(closestTwoPoints[1]);
        }

        static void PrintPoint(Point point)
        {
            Console.WriteLine("({0}, {1})", point.X, point.Y);
        }

        static Point[] ReadPoints()
        {
            int n = int.Parse(Console.ReadLine());

            Point[] points = new Point[n];

            for (int i = 0; i < n; i++)
            {
                points[i] = ReadPoint();
            }

            return points;
        }

        static Point ReadPoint()
        {
            int[] points = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Point p = new Point { X = points[0], Y = points[1] };

            return p;
        }

        static Point[] FindClosestTwoPoints(Point[] points)
        {
            double minDistance = double.MaxValue;
            Point[] closestPoints = null;

            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    double distance = CalculateDistance(points[i], points[j]);

                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        closestPoints = new Point[] { points[i], points[j] };
                    }

                }
            }

            return closestPoints;
        }

        static double CalculateDistance(Point p1, Point p2)
        {
            int a = p1.X - p2.X;
            int b = p1.Y - p2.Y;

            return Math.Sqrt(a * a + b * b);
        }
    }
}
