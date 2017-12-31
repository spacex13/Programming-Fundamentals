using System;
using System.Linq;
namespace _07.SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var biggerArr = Math.Max(arr1.Length, arr2.Length);
            int[] sumArr = new int[biggerArr];

            for (int i = 0; i < biggerArr; i++)
            {
                sumArr[i] = arr1[i%arr1.Length] + arr2[i%arr2.Length];
            }

            Console.WriteLine(String.Join(" ", sumArr));
        }
    }
}
