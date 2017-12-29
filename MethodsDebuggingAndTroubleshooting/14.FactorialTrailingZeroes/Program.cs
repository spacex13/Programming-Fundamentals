using System;
using System.Numerics;
namespace _14.FactorialTrailingZeroes
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            CalculateFactorial(n);
        }

        public static void CalculateFactorial(int n)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            Console.WriteLine(CountZeroes(factorial));
        }

        public static int CountZeroes(BigInteger factorial)
        {
            string fact = factorial.ToString();
            int count = 0;
            for (int i = 1; i < fact.Length; i++)
            {
                if (factorial % 10 == 0)
                {
                    count++;
                    factorial /= 10;
                }
                else break;
            }
            return count;
        }
    }
}
