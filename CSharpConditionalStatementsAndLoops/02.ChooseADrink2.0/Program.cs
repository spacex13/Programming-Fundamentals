using System;

namespace _02.ChooseADrink2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            var quantityOfDrinks = int.Parse(Console.ReadLine());
            double cost;

            if (profession == "Athlete")
            {
                var waterCost = 0.70;
                cost = quantityOfDrinks * waterCost;
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                var coffeeCost = 1.00;
                cost = quantityOfDrinks * coffeeCost;
            }
            else if (profession == "SoftUni Student")
            {
                var beerCost = 1.70;
                cost = quantityOfDrinks * beerCost;
            }
            else
            {
                var teaCost = 1.20;
                cost = quantityOfDrinks * teaCost;
            }
            Console.WriteLine($"The {profession} has to pay {cost:F2}.");
        }
    }
}
