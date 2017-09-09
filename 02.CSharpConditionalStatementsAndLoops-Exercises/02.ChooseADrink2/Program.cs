using System;

namespace _02.ChooseADrink2
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            string drink = string.Empty;
            double price = 0d;

            if (profession == "Athlete")
            {
                drink = "Water";
                price = 0.7;
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                drink = "Coffee";
                price = 1.00;
            }
            else if (profession == "SoftUni Student")
            {
                drink = "Beer";
                price = 1.7;
            }
            else
            {
                drink = "Tea";
                price = 1.2;
            }
            double total = price * quantity;
            Console.WriteLine($"The {profession} has to pay {total:f2}.");
        }
    }
}
