using System;
using System.Linq;
using System.Numerics;

namespace _1.AnonymousDownsite
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());
            decimal totalLoss = 0;

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split(new [] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string siteName = data[0];
                Console.WriteLine(siteName);

                decimal siteVisits = decimal.Parse(data[1]);
                decimal siteCommercialPricePerVisit = decimal.Parse(data[2]);
                decimal siteLoss = siteVisits * siteCommercialPricePerVisit;
                totalLoss += siteLoss;
            }

            BigInteger securityToken = BigInteger.Pow(securityKey, n);

            Console.WriteLine($"Total Loss: {totalLoss:F20}");
            Console.WriteLine($"Security Token: {securityToken}");
        }
    }
}
