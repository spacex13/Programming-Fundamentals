using System;

namespace _03.RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string discountPackage = Console.ReadLine();
            int hallPrice = 0;

            if (countOfPeople <= 50)
            {
                hallPrice = 2500;
                Console.WriteLine("We can offer you the Small Hall");
            }
            else if (countOfPeople <= 100)
            {
                hallPrice = 5000;
                Console.WriteLine("We can offer you the Terrace");
            }
            else if (countOfPeople <= 120)
            {
                hallPrice = 7500;
                Console.WriteLine("We can offer you the Great Hall");
            }
            else
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }

            int packageCost = 0;
            int discount = 0;

            if (discountPackage == "Normal")
            {
                packageCost = 500;
                discount = 5;
            }
            else if (discountPackage == "Gold")
            {
                packageCost = 750;
                discount = 10;
            }
            else if (discountPackage == "Platinum")
            {
                packageCost = 1000;
                discount = 15;
            }

            if (countOfPeople <= 120)
            {
                int sum = hallPrice + packageCost;
                double total = sum - discount / 100.0 * sum;
                double pricePerPerson = total / countOfPeople;
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
            }
        }
    }
    }
}
