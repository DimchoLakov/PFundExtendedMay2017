using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> left = nums.Take(nums.Count / 4).Reverse().ToList();
            List<int> right = nums.Skip((nums.Count / 4) * 3).Reverse().ToList();

            var rowTwo = nums.Skip(nums.Count / 4).Take((nums.Count / 4) * 2).ToList();
            var rowOne = left.Concat(right).ToList();
            var sum = rowOne.Select((x, index) => x + rowTwo[index]).ToList();

            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
