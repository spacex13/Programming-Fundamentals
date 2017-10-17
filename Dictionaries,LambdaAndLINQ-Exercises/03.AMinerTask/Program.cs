using System;
using System.Collections.Generic;
namespace _03.AMinerTask
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            int lineCount = 1;
            var resources = new Dictionary<string, int>();
            string resource = "";
            int quantity = 0;

            while (input != "stop")
            {
                if (lineCount % 2 != 0)
                {
                    resource = input;
                }
                else if (lineCount % 2 == 0)
                {
                    quantity = Convert.ToInt32(input);
                    if (resources.ContainsKey(resource))
                    {
                        resources[resource] += quantity;
                    }
                    else
                    {
                        resources[resource] = quantity;
                    }
                }

                lineCount++;
                input = Console.ReadLine();
            }

            foreach (var res in resources)
            {
                Console.WriteLine($"{res.Key} -> {res.Value}");
            }
        }
    }
}
