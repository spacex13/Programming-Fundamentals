using System;
using System.Collections.Generic;
using System.Linq;
namespace _01.Phonebook
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().ToArray();
            var phonebook = new Dictionary<string, string>();

            while (input[0] != "END")
            {
                if (input[0].Contains("A"))
                {
                    string name = input[1];
                    string number = input[2];

                    phonebook[name] = number;
                }
                else if (input[0].Contains("S"))
                {
                    string name = input[1];
                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phonebook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }

                input = Console.ReadLine().Split().ToArray();
            }
        }
    }
}
