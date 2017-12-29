using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.SalesReport
{
    class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }

        public double TotalSales
        {
            get { return Price * Quantity; }
            set { }
        }
    }

    class Program
    {
        static void Main()
        {
            int salesCount = int.Parse(Console.ReadLine());
            Sale[] sales = new Sale[salesCount];

            for (int i = 0; i < salesCount; i++)
            {
                sales[i] = ReadSale();
            }

            SortedDictionary<string, double> salesByTown = new SortedDictionary<string, double>();

            for (int i = 0; i < sales.Length; i++)
            {
                if (!salesByTown.ContainsKey(sales[i].Town))
                {
                    salesByTown.Add(sales[i].Town, sales[i].TotalSales);
                }
                else
                {
                    salesByTown[sales[i].Town] += sales[i].TotalSales;
                }
            }

            foreach (var sale in salesByTown)
            {
                Console.WriteLine("{0} -> {1:F2}", sale.Key, sale.Value);
            }
        }

        static Sale ReadSale()
        {
            string[] input = Console.ReadLine().Split().ToArray();

            Sale sale = new Sale();

            sale.Town = input[0];
            sale.Product = input[1];
            sale.Price = double.Parse(input[2]);
            sale.Quantity = double.Parse(input[3]);

            return sale;
        }
    }
}
