using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            SortedDictionary<double, int> dict = new SortedDictionary<double, int>();


            foreach (double num in numbers)
            {
                if (dict.ContainsKey(num))
                {
                    dict[num]++;
                }
                else
                {
                    dict[num] = 1;
                }
            }

            foreach (KeyValuePair<double, int> number in dict)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
