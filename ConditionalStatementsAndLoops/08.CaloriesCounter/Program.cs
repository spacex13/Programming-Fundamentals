using System;

namespace _08.CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfIngredients = int.Parse(Console.ReadLine());
            var caloriesCounter = 0;

            for (int i = 0; i < numberOfIngredients; i++)
            {
                string ingredient = Console.ReadLine().ToLower();
                switch (ingredient)
                {
                    case "cheese": caloriesCounter += 500; break;
                    case "tomato sauce": caloriesCounter += 150; break;
                    case "salami": caloriesCounter += 600; break;
                    case "pepper": caloriesCounter += 50; break;
                }
            }

            Console.WriteLine($"Total calories: {caloriesCounter}");
        }
    }
}
