using System;
namespace _16.ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            bool areEqual = false;

            if (Math.Max(num1, num2) - Math.Min(num1, num2) <= eps)
            {
                areEqual = true;
            }

            if (areEqual)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
