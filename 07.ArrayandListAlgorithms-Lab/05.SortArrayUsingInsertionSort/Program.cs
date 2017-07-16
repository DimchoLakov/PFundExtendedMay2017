using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SortArrayUsingInsertionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool swapped = true;
            while (swapped)
            {
                swapped = false;
                for (int i = 1; i < numbers.Length - 1; i++)
                {
                    if (numbers[i - 1] > numbers[i + 1])
                    {
                        Swap(numbers, i - 1, i + 1);
                        swapped = true;
                        break;
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));

        }

        static void Swap(int[] numbers, int first, int second)
        {
            int temp = numbers[first];
            numbers[first] = numbers[second];
            numbers[second] = temp;
        }

    }
}
