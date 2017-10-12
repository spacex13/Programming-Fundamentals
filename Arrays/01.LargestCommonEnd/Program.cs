using System;
using System.Linq;

namespace _01.LargestCommonEnd
{
    class Program
    {
        static void Main()
        {
            var arr1 = Console.ReadLine().Split().ToArray();
            var arr2 = Console.ReadLine().Split().ToArray();

            int count = 0;
            if (arr1[0] == arr2[0])
            {
                for (int i = 0; i < Math.Min(arr1.Length, arr2.Length); i++)
                {
                    if (arr1[i] == arr2[i])
                        count++;
                }
            }
            else if (arr1[arr1.Length - 1] == arr2[arr2.Length - 1])
            {
                for (int i = 0; i < Math.Min(arr1.Length, arr2.Length); i++)
                {
                    if (arr1[arr1.Length - 1 - i] == arr2[arr2.Length - 1 - i])
                        count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
