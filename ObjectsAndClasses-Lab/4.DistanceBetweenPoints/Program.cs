using System;
using System.Linq;

namespace _4.DistanceBetweenPoints
{
    class ReadPoint
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    class Program
    {
        static void Main()
        {
            int[] input1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            ReadPoint p1 = new ReadPoint {X = input1[0], Y = input1[1]};
            ReadPoint p2 = new ReadPoint {X = input2[0], Y = input2[1]};

            Console.WriteLine("{0:F3}", CalcDistance(p1, p2));
        }

        static double CalcDistance(ReadPoint p1, ReadPoint p2)
        {
            int a = p1.X - p2.X;
            int b = p1.Y - p2.Y;

            return Math.Sqrt(a * a + b * b);
        }
    }
}
