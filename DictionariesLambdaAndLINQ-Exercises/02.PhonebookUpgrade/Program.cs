using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PhonebookUpgrade
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().ToArray();
            var phonebook = new SortedDictionary<string, string>();

            while (input[0] != "END")
            {
                if (input[0] == "A")
                {
                    string name = input[1];
                    string number = input[2];

                    phonebook[name] = number;
                }
                else if (input[0] == "S")
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
                else if (input[0] == "ListAll")
                {
                    foreach (var person in phonebook)
                    {
                        Console.WriteLine($"{person.Key} -> {person.Value}");
                    }
                }

                input = Console.ReadLine().Split().ToArray();
            }
        }
    }
}
