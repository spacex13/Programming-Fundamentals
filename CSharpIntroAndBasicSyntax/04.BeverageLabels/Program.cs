using System;

namespace _04.BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameOfDrink = Console.ReadLine();
            var volumeOfDrink = int.Parse(Console.ReadLine());
            var energyPer100ml = int.Parse(Console.ReadLine());
            var sugarPer100ml = int.Parse(Console.ReadLine());

            double energy = volumeOfDrink * energyPer100ml / 100.0;
            double sugar = volumeOfDrink * sugarPer100ml / 100.0;

            Console.WriteLine($"{volumeOfDrink}ml {nameOfDrink}:");
            Console.WriteLine($"{energy}kcal, {sugar}g sugars");

        }
    }
}
