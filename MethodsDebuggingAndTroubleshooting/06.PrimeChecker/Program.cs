using System;
namespace _06.PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(n));
        }

        static bool IsPrime(long n)
        {
            if (n == 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            for (long i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
