using System;

namespace _05.FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            GetFibonacciNumber(num);
        }

        static void GetFibonacciNumber(int num)
        {
            int lastNum = 1;
            int fibNum = 1;
            int lastlastNum = 0;
            for (int i = 1; i <= num; i++)
            {
                fibNum = lastlastNum + lastNum;
                lastlastNum = lastNum;
                lastNum = fibNum;
            }
            Console.WriteLine(fibNum);
        }
    }
}
