using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.ArrayHistogram
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ').ToArray();

            List<string> words = new List<string>();
            List<int> occurrences = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!words.Contains(arr[i]))
                {
                    words.Add(arr[i]);
                    occurrences.Add(1);
                }
                else
                {
                    int index = words.IndexOf(arr[i]);
                    occurrences[index]++;
                }
            }

            bool swapped = true;
            while (swapped)
            {
                swapped = false;
                for (int i = 0; i < occurrences.Count - 1; i++)
                {
                    if (occurrences[i] < occurrences[i + 1])
                    {
                        int occureTemp = occurrences[i];
                        occurrences[i] = occurrences[i + 1];
                        occurrences[i + 1] = occureTemp;

                        string wordTemp = words[i];
                        words[i] = words[i + 1];
                        words[i + 1] = wordTemp;
                        swapped = true;
                        break;
                        
                    }
                }
            }

            for (int i = 0; i < words.Count; i++)
            {
                double percentage = (occurrences[i] / (occurrences.Sum() * 1.0)) * 100.0;
                Console.WriteLine($"{words[i]} -> {occurrences[i]} times ({percentage:f2}%)");
            }
        }
        
    }
}
