using System;
using System.Numerics;

namespace _13.Factorial
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(CalculateFactorial(n));
        }

        public static BigInteger CalculateFactorial(int n)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
