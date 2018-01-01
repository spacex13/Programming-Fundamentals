using System;
namespace _15.FastPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.Parse(Console.ReadLine());
            for (int currentNum = 2; currentNum <= maxNumber; currentNum++)
            {
                bool isPrime = true;
                for (int divider = 2; divider <= Math.Sqrt(currentNum); divider++)
                {
                    if (currentNum % divider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{currentNum} -> {isPrime}");
            }
        }
    }
}
