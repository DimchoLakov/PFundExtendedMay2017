using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Extremums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = Console.ReadLine().ToLower();
            string number = string.Empty;
            long minValue = long.MaxValue;
            long maxValue = long.MinValue;
            List<long> result = new List<long>();

            if (command == "min")
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    long shifting = 1;
                    number = nums[i].ToString();
                    minValue = long.MaxValue;
                    for (int j = 0; j < number.Length; j++)
                    {
                        long current = RotateShift(nums[i], shifting);
                        if (current < minValue)
                        {
                            minValue = current;
                            j--;
                        }
                        else
                        {
                            shifting++;
                        }
                    }
                    result.Add(minValue);
                }
            }
            else if (command == "max")
            {
                for (int i = 0; i < nums.Count; i++)
                {
                    long shifting = 1;
                    number = nums[i].ToString();
                    maxValue = long.MinValue;
                    for (int j = 0; j < number.Length; j++)
                    {
                        long current = RotateShift(nums[i], shifting);
                        if (current > maxValue)
                        {
                            maxValue = current;
                            j--;
                        }
                        else
                        {
                            shifting++;
                        }
                    }
                    result.Add(maxValue);
                }
            }

            Console.WriteLine(string.Join(", ", result));
            Console.WriteLine(result.Sum());

        }

        static long RotateShift(long value, long shift)
        {
            long len = (long)Math.Log10(value) + 1;
            shift %= len;
            if (shift < 0) shift += len;
            long pow = (long)Math.Pow(10, shift);
            long rotated = (value % pow) * (long)Math.Pow(10, len - shift) + value / pow;
            return rotated;
        }
    }
}
