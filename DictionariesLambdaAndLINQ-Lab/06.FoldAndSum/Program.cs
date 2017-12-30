using System;
using System.Linq;
namespace _06.FoldAndSum
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = array.Length / 4;

            var row1left = array.Take(k).Reverse().ToArray();
            var row1right = array.Reverse().Take(k).ToArray();

            var row1 = row1left.Concat(row1right).ToArray();
            var row2 = array.Skip(k).Take(2 * k).ToArray();

            var sum = row1.Select((x, i) => x + row2[i]);

            Console.WriteLine(String.Join(" ", sum));
        }
    }
}
