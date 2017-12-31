using System;
using System.Linq;

namespace _04.TripleSum
{
    class Program
    {
        static void Main()
        {
            var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool noTriples = true;

            for (int a = 0; a < arr.Length; a++)
            {
                for (int b = 0; b < arr.Length; b++)
                {
                    for (int c = 0; c < arr.Length; c++)
                    {
                        if (arr[a] + arr[b] == arr[c] && a < b)
                        {
                            noTriples = false;
                            Console.WriteLine($"{arr[a]} + {arr[b]} == {arr[c]}");
                            break;
                        }
                    }
                }
            }

            if (noTriples)
                Console.WriteLine("No");
        }
    }
}
