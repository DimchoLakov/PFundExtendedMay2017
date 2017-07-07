using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MirrorImage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nums = Console.ReadLine().Split(' ').ToList();

            string input = Console.ReadLine();

            while (input != "Print")
            {
                int n = int.Parse(input);

                List<string> firstHalf = new List<string>(); 
                List<string> secondsHalf = new List<string>();
                string midNumber = nums[n];

                for (int i = 0; i < n; i++)
                {
                    firstHalf.Add(nums[i]);
                }
                firstHalf.Reverse();

                for (int i = n + 1; i < nums.Count; i++)
                {
                    secondsHalf.Add(nums[i]);
                }
                secondsHalf.Reverse();

                nums.Clear();
                nums.AddRange(firstHalf);
                nums.Add(midNumber);
                nums.AddRange(secondsHalf);

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
