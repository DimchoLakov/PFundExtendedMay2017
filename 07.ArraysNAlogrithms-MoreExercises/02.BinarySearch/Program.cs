using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int searchElement = int.Parse(Console.ReadLine());

            LinearSeach(nums, searchElement);

            BinarySearch(nums, searchElement);



        }

        static void BinarySearch(int[] nums, int searchElement)
        {
            Array.Sort(nums);
            int counter = 0;
            int min = 0;
            int max = nums.Length - 1;

            while (min <= max)
            {
                int midpoint = (min + max) / 2;
                counter++;

                if (nums[midpoint] < searchElement)
                {
                    min = midpoint + 1;
                }

                if (nums[midpoint] > searchElement)
                {
                    max = midpoint - 1;
                }
                if (nums[midpoint] == searchElement)
                {
                    break;
                }
            }
            
            Console.WriteLine($"Binary search made {counter} iterations");
        }

        static void LinearSeach(int[] nums, int searchElement)
        {
            int counter = 0;
            bool isFound = false;
            for (int i = 0; i < nums.Length; i++)
            {
                counter++;
                if (nums[i] == searchElement)
                {
                    isFound = true;
                    break;
                }
            }
            if (isFound)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            Console.WriteLine($"Linear search made {counter} iterations");
        }
    }
}
