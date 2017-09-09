using System;

namespace _01.ChooseADrink
{
    class Program
    {
        static void Main(string[] args)
        {
            string profession = Console.ReadLine();

            string drink = string.Empty;

            if (profession == "Athlete")
            {
                drink = "Water";
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                drink = "Coffee";
            }
            else if (profession == "SoftUni Student")
            {
                drink = "Beer";
            }
            else
            {
                drink = "Tea";
            }
            Console.WriteLine(drink);
        }
    }
}
