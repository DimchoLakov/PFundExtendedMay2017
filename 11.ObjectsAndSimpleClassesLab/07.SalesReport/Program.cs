using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _07.SalesReport
{
    class Sale
    {
        public string Town { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }

        public double CalcSales
        {
            get
            {
                return Price * Quantity;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, double> dictSales = new Dictionary<string, double>();

            for (int i = 0; i < n; i++)
            {
                Sale currentSale = ReadSales();
                string town = currentSale.Town;
                double totalPrice = currentSale.CalcSales;

                if (! dictSales.ContainsKey(currentSale.Town))
                {
                    dictSales.Add(town, totalPrice);
                }
                else
                {
                    dictSales[town] += totalPrice;
                }
            }

            foreach (KeyValuePair<string, double> pair in dictSales.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value:f2}");
            }
        }

        public static Sale ReadSales()
        {
            string[] tokens = Console.ReadLine().Split(' ');
            var sale = new Sale
            {
                Town = tokens[0],
                Product = tokens[1],
                Price = double.Parse(tokens[2]),
                Quantity = double.Parse(tokens[3])
            };
            return sale;
        }
    }
}
