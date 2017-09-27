using System;

namespace _15.NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());
            int peshoHealth = 100;
            int goshoHealth = 100;
            int round = 0;

            string winner = String.Empty;

            for (int i = 1; i < 10000; i++)
            {
                if (i % 2 != 0)
                {
                    round++;
                    goshoHealth -= peshoDamage;
                    if (goshoHealth <= 0)
                    {
                        winner = "Pesho";
                        break;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and " +
                        $"reduced Gosho to {goshoHealth} health.");
                }
                else
                {
                    round++;
                    peshoHealth -= goshoDamage;
                    if (peshoHealth <= 0)
                    {
                        winner = "Gosho";
                        break;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and " +
                        $"reduced Pesho to {peshoHealth} health.");
                }

                if (i % 3 == 0)
                {
                    goshoHealth += 10;
                    peshoHealth += 10;
                }
            }

            Console.WriteLine($"{winner} won in {round}th round.");
        }
    }
}
