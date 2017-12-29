using System;

namespace _12.TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());
            int sum = 0;
            int comboCount = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int p = 1; p <= m; p++)
                {
                    sum += 3 * (i * p);
                    comboCount++;
                    if (sum >= maxSum) break;
                }
                if (sum >= maxSum) break;
            }

            if (sum >= maxSum)
            {
                Console.WriteLine($"{comboCount} combinations");
                Console.WriteLine($"Sum: {sum} >= {maxSum}");
            }
            else
            {
                Console.WriteLine($"{comboCount} combinations");
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}
