using System;
using System.Linq;

namespace _2.RandomizeWords
{
    class Program
    {
        static void Main()
        {

            var input = Console.ReadLine().Split(' ').ToArray();

            Random rnd = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                int index = rnd.Next(0, input.Length);
                string oldValue = input[i];
                input[i] = input[index];
                input[index] = oldValue;
            }

            Console.WriteLine(String.Join(Environment.NewLine, input));

            //Another solution:
            
            //string[] input = Console.ReadLine().Split();
            //Random random = new Random();

            //for (int i = 0; i < input.Length; i++)
            //{
            //    int firstWord = random.Next(0, input.Length);
            //    int secondWord = random.Next(0, input.Length);

            //    string changer = input[firstWord];
            //    input[firstWord] = input[secondWord];
            //    input[secondWord] = changer;
            //}

            //Console.WriteLine(string.Join("\n", input));
        }
    }
}
