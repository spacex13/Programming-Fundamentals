using System;
namespace _03.WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int maxQuantity = 255;
            int sum = 0;
            bool insufficient = false; 

            for (int i = 0; i < n; i++)
            {
                int quantityToPour = int.Parse(Console.ReadLine());
                sum += quantityToPour;

                if (maxQuantity < sum)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sum -= quantityToPour;
                    insufficient = true;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
