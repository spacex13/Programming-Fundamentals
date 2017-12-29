using System;
using System.Linq;

namespace _6.RectanglePosition
{
    class Rectangle
    {
        public int Left { get; set; }
        public int Top { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public int Right()
        {
            return Left + Width;
        }

        public int Bottom()
        {
            return Top + Height;
        }
    }

    class Program
    {
        static void Main()
        {
            var input1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Rectangle rect1 = new Rectangle {Left = input1[0], Top = input1[1], Width = input1[2], Height = input1[3]};
            Rectangle rect2 = new Rectangle { Left = input2[0], Top = input2[1], Width = input2[2], Height = input2[3] };

            if (isInside(rect1, rect2))
            {
                Console.WriteLine("Inside");
            }
            else
            {
                Console.WriteLine("Not inside");
            }
        }

        static bool isInside(Rectangle r1, Rectangle r2)
        {
            bool left = r1.Left >= r2.Left;
            bool right = r1.Right() <= r2.Right();
            bool top = r1.Top <= r2.Top;
            bool bottom = r1.Bottom() <= r2.Bottom();

            if (left && right && top && bottom)
            {
                return true;
            }

            return false;
        }
    }
}
