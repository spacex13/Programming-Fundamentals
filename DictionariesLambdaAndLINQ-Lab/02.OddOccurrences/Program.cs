using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OddOccurrences
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().ToLower().Split().ToArray();
            var dict = new Dictionary<string, int>();

            foreach (var item in input)
            {
                if (dict.ContainsKey(item))
                {
                    dict[item]++;
                }
                else
                {
                    dict[item] = 1;
                }
            }

            List<string> result = new List<string>();

            foreach (var item in dict)
            { 
                if (item.Value % 2 != 0)
                {
                    result.Add(item.Key);
                }
            }
            Console.WriteLine(String.Join(", ", result));
        }
    }
}
