using System;
using System.Linq;
namespace _02.RotateAndSum
{
    class Program
    {
        static void Main()
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            int n = arr.Length;

            int[] sum = new int[n];
            for (int r = 1; r <= k; r++)
            {
                int lastN = arr[arr.Length - 1];
                for (int i = arr.Length - 1; i > 0; i--)
                {
                    arr[i] = arr[i - 1];
                    sum[i] += arr[i];
                }
                arr[0] = lastN;
                sum[0] += arr[0];
            }
            Console.WriteLine(String.Join(" ", sum));
        }
    }
}
