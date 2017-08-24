using System;

namespace _03.BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int totalMinutes = hours * 60 + minutes + 30;
            int resultHours = totalMinutes / 60;
            int resultMinutes = totalMinutes % 60;

            if (resultMinutes > 59)
            {
                resultHours--;
            }
            if (resultHours > 23)
            {
                resultHours -= 24;
            }
            Console.WriteLine($"{resultHours}:{resultMinutes:00}");
        }
    }
}
