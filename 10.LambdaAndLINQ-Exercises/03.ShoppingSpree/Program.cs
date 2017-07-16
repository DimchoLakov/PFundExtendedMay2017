using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            Dictionary<string, double> products = new Dictionary<string, double>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(' ');
                string name = tokens[0];
                double price = double.Parse(tokens[1]);

                if (! products.ContainsKey(name))
                {
                    products.Add(name, price);
                }
                else
                {
                    if (products[name] > price)
                    {
                        products[name] = price;
                    }
                }


                input = Console.ReadLine();
            }

            double sum = products.Values.Sum();

            if (sum > budget)
            {
                Console.WriteLine($"Need more money... Just buy banichka");
            }
            else
            {
                foreach (KeyValuePair<string, double> namePrice in products.OrderByDescending(p => p.Value).ThenBy(name => name.Key.Length))
                {
                    Console.WriteLine($"{namePrice.Key} costs {namePrice.Value:f2}");
                }
            }

        }
    }
}
