using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MostValuedCustomer
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> productsData = new Dictionary<string, double>();

            Dictionary<string, List<string>> customersData = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "Shop is open")
            {
                string[] tokens = input.Split(' ');
                string productName = tokens[0];
                double productPrice = double.Parse(tokens[1]);

                productsData[productName] = productPrice;

                input = Console.ReadLine();
            }

            string secondInput = Console.ReadLine();

            while (secondInput != "Print")
            {
                string[] tokens = secondInput.Split(':');

                if (tokens[0] == "Discount")
                {
                    var discountedProducts = productsData.OrderByDescending(pr => pr.Value).Take(3)
                        .Select(pd => new KeyValuePair<string, double>(pd.Key, pd.Value * 0.9));

                    //Dictionary<string, double> discountedProducts = productsData.OrderByDescending(pr => pr.Value).Take(3)
                    //   .Select(pd => new KeyValuePair<string, double>(pd.Key, pd.Value * 0.9)).ToDictionary(pair => pair.Key, pair => pair.Value);

                    foreach (KeyValuePair<string, double> discProd in discountedProducts)
                    {
                        productsData[discProd.Key] = discProd.Value;
                    }
                }
                else
                {
                    string customerName = tokens[0];
                    string[] buyingProducts = tokens[1]
                        .Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);

                    if (! customersData.ContainsKey(customerName))
                    {
                        customersData.Add(customerName, new List<string>());
                    }

                    for (int i = 0; i < buyingProducts.Length; i++)
                    {
                        if (productsData.ContainsKey(buyingProducts[i]))
                        {
                            customersData[customerName].Add(buyingProducts[i]);
                        }
                    }
                }

                secondInput = Console.ReadLine();
            }

            var topCustomer = customersData.OrderByDescending(sp => sp.Value.Sum(product => productsData[product]))
                .First();

            string topCustomerName = topCustomer.Key;
            var topCustomerProductsBought = topCustomer.Value.Distinct().OrderByDescending(prod => productsData[prod]);

            Console.WriteLine($"Biggest spender: {topCustomerName}");
            Console.WriteLine($"^Products bought:");

            double total = topCustomer.Value.Sum(pd => productsData[pd]);

            foreach (string product in topCustomerProductsBought)
            {
                Console.WriteLine($"^^^{product}: {productsData[product]:f2}");
            }

            Console.WriteLine($"Total: {total:f2}");
        }
    }
}
