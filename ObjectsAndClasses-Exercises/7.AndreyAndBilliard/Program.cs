using System;
using System.Collections.Generic;
using System.Linq;

namespace _7.AndreyAndBilliard
{
    class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> ShopList { get; set; }
        public decimal Bill { get; set; }
    }

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, decimal> shop = new Dictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('-');
                shop[input[0]] = decimal.Parse(input[1]);
            }

            string[] customerInput = Console.ReadLine().Split(',', '-');

            List<Customer> customers = new List<Customer>();

            while (customerInput[0] != "end of clients")
            {
                string name = customerInput[0];
                string product = customerInput[1];
                int quantity = int.Parse(customerInput[2]);

                if (!shop.ContainsKey(product))
                {
                    customerInput = Console.ReadLine().Split('-', ',');
                    continue;
                }

                if (customers.Any(x => x.Name == name))
                {
                    Customer existingCustomer = customers.First(x => x.Name == name);

                    if (existingCustomer.ShopList.ContainsKey(product))
                    {
                        existingCustomer.ShopList[product] += quantity;
                    }
                    else
                    {
                        existingCustomer.ShopList[product] = quantity;
                    }

                    existingCustomer.Bill += quantity * shop[product];
                }
                else
                {
                    Customer customer = new Customer
                    {
                        Name = name,
                        ShopList = new Dictionary<string, int> { { product, quantity } },
                        Bill = quantity * shop[product]
                    };

                    customers.Add(customer);
                }

                customerInput = Console.ReadLine().Split(',', '-');
            }

            decimal totalBill = 0;

            foreach (Customer customer in customers.OrderBy(x => x.Name))
            {
                Console.WriteLine(customer.Name);

                foreach (var item in customer.ShopList)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }

                totalBill += customer.Bill;

                Console.WriteLine($"Bill: {customer.Bill:F2}");
            }

            Console.WriteLine($"Total bill: {totalBill:F2}");
        }
    }
}
