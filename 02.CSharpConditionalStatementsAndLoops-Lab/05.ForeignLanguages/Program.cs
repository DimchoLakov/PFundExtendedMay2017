using System;

namespace _05.ForeignLanguages
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();

            if (country == "USA" || country == "England")
            {
                Console.WriteLine($"English");
            }
            else if (country == "Argentina" || country == "Spain" || country == "Mexico")
            {
                Console.WriteLine($"Spanish");
            }
            else
            {
                Console.WriteLine($"unknown");
            }
        }
    }
}
