using System;

namespace _08.SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int count = 0;
            for (int i = 1; i < 10000; i+=2)
            {
                count++;
                sum += i;
                Console.WriteLine(i);
                if (count == n)
                {
                    break;
                }
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
