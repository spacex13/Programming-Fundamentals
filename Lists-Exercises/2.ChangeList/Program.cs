using System;
using System.Collections.Generic;
using System.Linq;
namespace _2.ChangeList
{
    class Program
    {
        static void Main()
        {
            List<int> integers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string[] command = Console.ReadLine().Split();

            while (!command.Contains("Odd") && !command.Contains("Even"))
            {
                if (command[0] == "Delete")
                {
                    int element = Convert.ToInt32(command[1]);
                    integers.RemoveAll(x => x == element);
                }
                else if (command[0] == "Insert")
                {
                    int element = Convert.ToInt32(command[1]);
                    int position = Convert.ToInt32(command[2]);
                    integers.Insert(position, element);
                }
                command = Console.ReadLine().Split();
            }

            if (command[0] == "Odd")
            {
                foreach (var num in integers)
                {
                    if (num % 2 != 0)
                        Console.Write("{0} ", num);
                }
            }
            else if (command[0] == "Even")
            {
                foreach (var num in integers)
                {
                    if (num % 2 == 0)
                        Console.Write("{0} ", num);
                }
            }
            Console.WriteLine();
        }
    }
}
