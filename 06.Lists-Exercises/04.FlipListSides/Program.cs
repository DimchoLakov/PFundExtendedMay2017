using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FlipListSides
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> firstHalf = new List<int>();
            List<int> secondHalf = new List<int>();
            List<int> result = new List<int>();

            int firstElement = numbers[0];
            int lastElement = numbers[numbers.Count - 1];
            int middleElement = 0;

            if (numbers.Count % 2 != 0)
            {
                middleElement = numbers[numbers.Count / 2];
            }

            for (int i = 1; i < numbers.Count / 2; i++)
            {
                firstHalf.Add(numbers[i]);
            }

            if (numbers.Count % 2 == 0)
            {
                for (int i = numbers.Count / 2; i < numbers.Count - 1; i++)
                {
                    secondHalf.Add(numbers[i]);
                }
            }
            else
            {
                for (int i = numbers.Count / 2 + 1; i < numbers.Count - 1; i++)
                {
                    secondHalf.Add(numbers[i]);
                }
            }

            firstHalf.Reverse();
            secondHalf.Reverse();
            result.Add(firstElement);
            result.AddRange(secondHalf);
            if (numbers.Count % 2 != 0)
            {
                result.Add(middleElement);
            }
            result.AddRange(firstHalf);
            result.Add(lastElement);
            if (numbers.Count > 3)
            {
                Console.WriteLine(string.Join(" ", result));
            }
            else if (numbers.Count > 0)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
