using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SortArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(' ').ToArray();
            var something = text[0].CompareTo(text[1]);
            BubleSortArr(text);

            Console.WriteLine(string.Join(" ", text));
        }

        static void BubleSortArr(string[] numbers)
        {
            bool swapped = true;
            while (swapped)
            {
                swapped = false;
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i].CompareTo(numbers[i + 1]) > 0)
                    {
                        Swap(numbers, i, i + 1);
                        swapped = true;
                        break;
                    }
                }
            }
        }

        static void Swap(string[] numbers, int first, int second)
        {
            string temp = numbers[first];
            numbers[first] = numbers[second];
            numbers[second] = temp;
        }
    }
}
