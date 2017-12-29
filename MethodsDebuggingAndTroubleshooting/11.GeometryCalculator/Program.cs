﻿using System;
namespace _11.GeometryCalculator
{
    public class Program
    {
        public static void Main()
        {
            string figureType = Console.ReadLine();
            Console.WriteLine("{0:F2}", CalculateArea(figureType));
        }

        public static double CalculateArea(string figureType)
        {
            double area = 0;
            if (figureType == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                area = side * height / 2;
            }
            else if (figureType == "square")
            {
                double side = double.Parse(Console.ReadLine());
                area = side * side;
            }
            else if (figureType == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                area = width * height;
            }
            else if (figureType == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                area = Math.PI * radius * radius;
            }

            return area;
        }
    }
}
