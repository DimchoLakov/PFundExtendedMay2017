using System;

namespace _12.NumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int.Parse(Console.ReadLine());
                Console.WriteLine($"It is a number.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Invalid input!");
            }
        }
    }
}
