using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.TearListInHalf
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> result = new List<int>();
            for (int i = 0; i < numbers.Count / 2; i++)
            {
                var digitToSplit = numbers[numbers.Count / 2 + i].ToString();
                var splittedDigit = digitToSplit.ToCharArray();
                var firstHalf = splittedDigit[0].ToString();
                var secondHalf = splittedDigit[1].ToString();

                result.Add(int.Parse(firstHalf));
                result.Add(numbers[i]);
                result.Add(int.Parse(secondHalf));
            }
            Console.WriteLine(string.Join(" ", result));
            
        }
    }
}
