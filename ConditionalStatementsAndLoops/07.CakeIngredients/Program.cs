using System;

namespace _07.CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int count = 0;

            while (command != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {command}.");
                count++;
                command = Console.ReadLine();
            }

            Console.WriteLine($"Preparing cake with {count} ingredients.");
        }
    }
}
