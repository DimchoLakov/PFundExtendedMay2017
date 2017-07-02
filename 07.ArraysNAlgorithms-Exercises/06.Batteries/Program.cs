using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Batteries
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] capacities = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
             
            double[] usagePerHour = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

            int hoursToTest = int.Parse(Console.ReadLine());
            int batteryCount = 0;            
            for (int i = 0; i < capacities.Length; i++)
            {
                bool isDead = false;
                batteryCount++;
                double capacity = capacities[i];
                for (int j = 0; j < hoursToTest; j++)
                {
                    capacities[i] -= usagePerHour[i];
                    if (capacities[i] <= 0)
                    {
                        Console.WriteLine($"Battery {batteryCount}: dead (lasted {j + 1} hours)");
                        isDead = true;
                        break;
                    }
                }
                if (!isDead)
                {
                    double percentage = (capacities[i] / capacity) * 100d;
                    Console.WriteLine($"Battery {batteryCount}: {capacities[i]:f2} mAh ({percentage:f2})%");
                }
            }
        }
    }
}
