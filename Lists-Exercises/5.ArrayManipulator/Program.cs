using System;
using System.Collections.Generic;
using System.Linq;
namespace _5.ArrayManipulator
{
    class Program
    {
        static void Main()
        {
            List<int> integers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string[] command = Console.ReadLine().Split().ToArray();

            while (command[0] != "print")
            {
                switch (command[0])
                {
                    case "add":
                        int index = Convert.ToInt32(command[1]);
                        int element = Convert.ToInt32(command[2]);
                        integers.Insert(index, element);
                        break;

                    case "addMany":
                        index = Convert.ToInt32(command[1]);
                        List<int> array = command.Skip(2).Select(int.Parse).ToList();
                        integers.InsertRange(index, array);
                        break;

                    case "contains":
                        element = Convert.ToInt32(command[1]);
                        Console.WriteLine(integers.IndexOf(element));
                        break;

                    case "remove":
                        index = Convert.ToInt32(command[1]);
                        integers.RemoveAt(index);
                        break;

                    case "shift":
                        int positions = Convert.ToInt32(command[1]);
                        positions = positions % integers.Count;
                        var rem = integers.Take(positions).ToList();
                        integers.RemoveRange(0, positions);
                        integers.AddRange(rem);
                        break;

                    case "sumPairs":
                        for (int i = 0; i < integers.Count - 1; i++)
                        {
                            var sum = integers[i] + integers[i + 1];
                            integers[i] = sum;
                            integers.RemoveAt(i + 1);
                        }
                        break;
                }

                command = Console.ReadLine().Split().ToArray();
            }

            Console.WriteLine("[{0}]", string.Join(", ", integers));
        }
    }
}
