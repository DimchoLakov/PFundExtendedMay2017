using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.GroceryShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Dictionary<string, double> products = new Dictionary<string, double>();

            string pattern = @"\b[A-Z][a-z]+:\d+\.\d{2}$";

            while (input != "bill")
            {
                Regex product = new Regex(pattern);

                MatchCollection matches = product.Matches(input);

                foreach (Match match in matches)
                {
                    string[] nameAndPrice = match.Value.Split(':');
                    string productName = nameAndPrice[0];
                    double productPrice = double.Parse(nameAndPrice[1]);
                    if (! products.ContainsKey(productName))
                    {
                        products.Add(productName, productPrice);
                    }
                    else
                    {
                        products[productName] = productPrice;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (KeyValuePair<string, double> product in products.OrderByDescending(p => p.Value))
            {
                Console.WriteLine($"{product.Key} costs {product.Value:f2}");
            }
        }
    }
}
