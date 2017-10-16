using System;
using System.Collections.Generic;
using System.Linq;
namespace _3.SearchForANumber
{
    class Program
    {
        static void Main()
        {
            List<int> integers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int elementsToTake = numbers[0];
            int elementsToDelete = numbers[1];
            int lastNum = numbers[2];

            List<int> newList = new List<int>(integers.Take(elementsToTake));
            newList.RemoveRange(0, elementsToDelete);

            if (newList.Contains(lastNum))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
