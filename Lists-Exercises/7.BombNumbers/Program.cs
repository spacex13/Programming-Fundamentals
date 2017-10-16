using System;
using System.Collections.Generic;
using System.Linq;
namespace _7.BombNumbers
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bomb = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
            {
                int bombCount = bomb[1];
                if (numbers[i] == bomb[0])
                {
                    int index = i - bombCount;
                    int count = 2 * bombCount + 1;
                    if (count + index > numbers.Count)
                    {
                        count = numbers.Count - index;
                    }
                    else if (i == 0)
                    {
                        index = 0;
                        count = bomb[1] + 1;
                    }
                    else if (i == bomb[0])
                    {
                        index = numbers.Count - 1 - bomb[1];
                        count = bomb[1];
                    }
                    numbers.RemoveRange(index, count);
                }
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }
    }
}
