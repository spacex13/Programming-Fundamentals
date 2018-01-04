using System;
using System.Collections.Generic;
using System.Linq;
namespace _2.AnonymousThreat
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string[] command = Console.ReadLine().Split();

            while (command[0] != "3:1")
            {
                if (command[0] == "merge")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }

                    if (endIndex > input.Count - 1)
                    {
                        endIndex = input.Count - 1;
                    }

                    for (int i = startIndex; i < endIndex; i++)
                    {
                        input[startIndex] += input[startIndex + 1];
                        input.Remove(input[startIndex + 1]);
                    }
                }
                else if (command[0] == "divide")
                {
                    int index = int.Parse(command[1]);
                    int partitions = int.Parse(command[2]);
                    string element = input[index];
                    List<string> elements = new List<string>();
                    int count = element.Length / partitions;
                    

                    if (element.Length % partitions == 0)
                    {
                        while (element.Length > 0)
                        {
                            string sub = element.Substring(0, count);
                            elements.Add(sub);
                            element = element.Remove(0, count);
                        }
                    }
                    else
                    {
                        int lastCount = count + 1;

                        for (int i = 0; i <= element.Length - lastCount; i++)
                        {
                            string sub = element.Substring(0, count);
                            elements.Add(sub);
                            element = element.Remove(0, count);
                        }

                        elements.Add(element);
                    }

                    elements.Reverse();
                    input.RemoveAt(index);

                    for (int i = 0; i < elements.Count; i++)
                    {
                        input.Insert(index, elements[i]);
                    }
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(String.Join(" ", input));
        }
    }
}
