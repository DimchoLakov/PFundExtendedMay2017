﻿using System;

namespace _06.TheatrePromotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayType = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            if (age < 0 || age > 122)
            {
                Console.WriteLine($"Error!");
                return;
            }
            switch (dayType)
            {
                case "Weekday":
                    if (age <= 18 || age > 64)
                    {
                        Console.WriteLine($"12$");
                    }
                    else
                    {
                        Console.WriteLine($"18$");
                    }
                    break;
                case "Weekend":
                    if (age <= 18 || age > 64)
                    {
                        Console.WriteLine($"15$");
                    }
                    else
                    {
                        Console.WriteLine($"20$");
                    }
                    break;
                case "Holiday":
                    if (age <= 18)
                    {
                        Console.WriteLine($"5$");
                    }
                    else if (age > 18 && age < 64)
                    {
                        Console.WriteLine($"12$");
                    }
                    else
                    {
                        Console.WriteLine($"10$");
                    }
                    break;
            }
        }
    }
}
