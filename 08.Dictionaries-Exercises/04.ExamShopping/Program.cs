using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ExamShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> stock = new Dictionary<string, int>();

            AddProducts(stock);
            BuyProducts(stock);

            foreach (KeyValuePair<string, int> item in stock.Where(q => q.Value > 0))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
            
        }

        static void BuyProducts(Dictionary<string, int> stock)
        {
            string input = Console.ReadLine();
            string[] tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            while (input != "exam time")
            {
                string product = tokens[1];
                int quantity = int.Parse(tokens[2]);

                if (!stock.ContainsKey(product))
                {
                    Console.WriteLine($"{product} doesn't exist");
                }
                else if (stock.ContainsKey(product) && stock[product] <= 0)
                {
                    Console.WriteLine($"{product} out of stock");
                }
                else
                {
                    stock[product] -= quantity;
                }

                input = Console.ReadLine();
                tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }
        }

        static void AddProducts(Dictionary<string, int> stock)
        {
            string input = Console.ReadLine();
            string[] tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            while (input != "shopping time")
            {
                string product = tokens[1];
                int quantity = int.Parse(tokens[2]);

                if (!stock.ContainsKey(product))
                {
                    stock.Add(product, quantity);
                }
                else
                {
                    stock[product] += quantity;
                }

                input = Console.ReadLine();
                tokens = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

        }
    }
}
