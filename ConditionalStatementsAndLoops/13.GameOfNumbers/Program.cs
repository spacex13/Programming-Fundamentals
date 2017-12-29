using System;

namespace _13.GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int num1 = 0;
            int num2 = 0;
            bool combo = false;
            int count = 0;

            for (int i = n; i <= m; i++)
            {
                for (int p = n; p <= m; p++)
                {
                    count++;
                    if (i + p == magicNumber)
                    {
                        num1 = i;
                        num2 = p;
                        combo = true;
                    }
                }
            }

            if (combo)
            {
                Console.WriteLine($"Number found! {num1} + {num2} = {magicNumber}");
            }
            else
            {
                Console.WriteLine($"{count} combinations - neither equals {magicNumber}");
            }
        }
    }
}
