using System;

namespace _04.BeverageLabels
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int sugar = int.Parse(Console.ReadLine());

            double energyForOneMl = energy / 100.0;
            double sugerForOneMl = sugar / 100.0;
            double energyForGivenVolume = energyForOneMl * volume;
            double sugarForGivenVolume = sugerForOneMl * volume;

            Console.WriteLine($"{volume}ml {productName}:");
            Console.WriteLine($"{energyForGivenVolume}kcal, {sugarForGivenVolume}g sugars");
        }
    }
}
