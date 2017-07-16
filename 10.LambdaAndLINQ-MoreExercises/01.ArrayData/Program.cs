using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ArrayData
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            double average = nums.Average();
            nums.RemoveAll(x => x < average);

            string command = Console.ReadLine();

            if (command == "Min")
            {
                Console.WriteLine(nums.Min());
            }
            else if (command == "Max")
            {
                Console.WriteLine(nums.Max());
            }
            else if (command == "All")
            {
                Console.WriteLine(string.Join(" ", nums.OrderBy(x => x)));
            }
        }
    }
}
