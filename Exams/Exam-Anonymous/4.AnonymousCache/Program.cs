using System;
using System.Collections.Generic;
using System.Linq;
namespace _4.AnonymousCache
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(new string[]{" -> ", " | "}, StringSplitOptions.RemoveEmptyEntries).ToList();
            Dictionary<string, Dictionary<int, string>> data = new Dictionary<string, Dictionary<int, string>>();
            KeyValuePair<string, Dictionary<int, string>> cache = new KeyValuePair<string, Dictionary<int, string>>();
            while (input[0] != "thetinggoesskrra")
            {
                if (input.Count == 1)
                {
                    string dataSet = input[0];
                    if (!data.ContainsKey(dataSet))
                    {
                        data.Add(dataSet, new Dictionary<int, string>());
                        if (cache.Key == dataSet)
                        {
                            Dictionary<int, string> size = cache.Value; 
                            data[dataSet] = size;
                        }
                    }
                }
                else
                {
                    string dataSet = input[2];
                    int dataSize = int.Parse(input[1]);
                    string dataKey = input[0];

                    if (!data.ContainsKey(dataSet))
                    {
                        cache.Add(dataSet, dataKey);
                        cache.Add(dataSet, new Dictionary<int, string>());
                        cache[dataSet][dataSize] = dataKey;
                    }
                    else
                    {
                        data[dataSet][dataSize] = dataKey;
                    }
                }

                input = Console.ReadLine().Split(new string[] { " -> ", " | " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }

            foreach (var dataSet in data.OrderByDescending(x => x.Value.Keys.Sum()))
            {
                Console.WriteLine($"Data Set: {dataSet.Key}, Total Size: {dataSet.Value.Keys.Sum()}");
                foreach (var dataKey in dataSet.Value)
                {
                    Console.WriteLine($"$.{dataKey.Value}");
                }
                break;
            }
        }
    }
}
