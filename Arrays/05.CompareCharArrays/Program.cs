using System;
using System.Linq;
namespace _05.CompareCharArrays
{
    class Program
    {
        static void Main()
        {
            var arr1 = Console.ReadLine().Split().Select(char.Parse).ToArray();
            var arr2 = Console.ReadLine().Split().Select(char.Parse).ToArray();

            for (int i = 0; i < Math.Min(arr1.Length, arr2.Length); i++)
            {
                if (arr1[i] > arr2[i])
                {
                    Console.WriteLine(String.Join("", arr2));
                    Console.WriteLine(String.Join("", arr1));
                    break;
                }
                if (arr1[i] < arr2[i])
                {
                    Console.WriteLine(String.Join("", arr1));
                    Console.WriteLine(String.Join("", arr2));
                    break;
                }

                if (arr1[i] == arr2[i])
                {
                    if (i == Math.Min(arr1.Length, arr2.Length) - 1 && arr1.Length < arr2.Length)
                    {
                        Console.WriteLine(String.Join("", arr1));
                        Console.WriteLine(String.Join("", arr2));
                        break;
                    }
                    else if (i == Math.Min(arr1.Length, arr2.Length) - 1 && arr1.Length > arr2.Length)
                    {
                        Console.WriteLine(String.Join("", arr2));
                        Console.WriteLine(String.Join("", arr1));
                        break;
                    }
                    else if (i == arr1.Length - 1 && arr1.Length == arr2.Length)
                    {
                        Console.WriteLine(String.Join("", arr2));
                        Console.WriteLine(String.Join("", arr1));
                        break;
                    }
                }
            }
        }
    }
}
