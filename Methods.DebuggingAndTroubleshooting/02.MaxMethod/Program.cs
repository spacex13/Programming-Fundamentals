using System;
namespace _02.MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int max = GetMax(GetMax(a, b), GetMax(b, c));
            Console.WriteLine(max);
        }

        static int GetMax(int a, int b)
        {   
            return Math.Max(a, b);
        }
    }
}
