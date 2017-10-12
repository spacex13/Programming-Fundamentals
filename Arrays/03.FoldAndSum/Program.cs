using System;
using System.Linq;
namespace _03.FoldAndSum
{
    class Program
    {
        static void Main()
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = arr.Length / 4;
            int[] leftArr = arr.Take(k).ToArray();
            int[] middleArr = arr.Skip(k).Take(2 * k).ToArray();
            int[] rightArr = arr.Skip(3 * k).Take(k).ToArray();

            Array.Reverse(leftArr);
            Array.Reverse(rightArr);

            int[] foldedArr = leftArr.Concat(rightArr).ToArray();
            int[] sum = new int[arr.Length / 2];

            for (int i = 0; i < sum.Length; i++)
            {
                sum[i] = foldedArr[i] + middleArr[i];
            }

            Console.WriteLine(String.Join(" ", sum));
        }
    }
}
