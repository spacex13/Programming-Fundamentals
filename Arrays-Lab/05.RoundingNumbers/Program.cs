using System;
using System.Linq;
namespace _05.RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double[] rounded = new double[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                rounded[i] = Math.Round(arr[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{arr[i]} => {rounded[i]}");
            }

        }
    }
}
