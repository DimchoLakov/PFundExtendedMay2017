using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(new String[] { " -> " },StringSplitOptions.RemoveEmptyEntries);
                
                string color = tokens[0];

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }

                string[] clothesInput = tokens[1].Split(',');

                for (int j = 0; j < clothesInput.Length; j++)
                {
                    string clothes = clothesInput[j];

                    if (!wardrobe[color].ContainsKey(clothes))
                    {
                        wardrobe[color].Add(clothes, 1);
                    }
                    else
                    {
                        wardrobe[color][clothes]++;
                    }
                }
            }

            string[] searchClothes = Console.ReadLine().Split(' ');
            string searchColor = searchClothes[0];
            string searchItem = searchClothes[1];

            foreach (KeyValuePair<string, Dictionary<string, int>> clothesPair in wardrobe)
            {
                Console.WriteLine($"{clothesPair.Key} clothes:");

                foreach (KeyValuePair<string, int> item in clothesPair.Value)
                {
                    if (clothesPair.Key == searchColor && item.Key == searchItem)
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value}");
                    }
                }
            }

        }
    }
}
