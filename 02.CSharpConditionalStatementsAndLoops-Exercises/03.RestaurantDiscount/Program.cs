using System;
using System.Security.Permissions;

namespace _03.RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            string hall = string.Empty;

            double price = 0d;
            int capacity = 0;

            if (groupSize <= 50)
            {
                price = 2500;
                hall = "Small Hall";
            }
            else if (groupSize <= 100)
            {
                price = 5000;
                hall = "Terrace ";
            }
            else if (groupSize <= 120)
            {
                price = 7500;
                hall = "Great Hall";
            }
            else
            {
                Console.WriteLine($"We do not have an appropriate hall.");
                return;
            }

            if (package == "Normal")
            {
                price += 500;
                price -= price * 0.05;
            }
            else if (package == "Gold")
            {
                price += 750;
                price -= price * 0.1;
            }
            else if (package == "Platinum")
            {
                price += 1000;
                price -= price * 0.15;
            }

            double pricePerPerson = price / groupSize;

            Console.WriteLine($"We can offer you the {hall}");
            Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
        }
    }
}
