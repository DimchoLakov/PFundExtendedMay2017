using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.NoteStatistics
{
    class Program
    {
        static void Main()
        {
            List<double> frequencies = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            Dictionary<double, string> dict = new Dictionary<double, string>()
            {
            {261.63,"C"},
            {277.18,"C#"},
            {293.66,"D"},
            {311.13,"D#"},
            {329.63,"E"},
            {349.23,"F"},
            {369.99,"F#"},
            {392.00,"G"},
            {415.30,"G#"},
            {440.00,"A"},
            {466.16,"A#"},
            {493.88,"B"},
            };

            string[] notes = new string[frequencies.Count];
            string[] naturals = new string[frequencies.Count];
            string[] sharps = new string[frequencies.Count];
            double naturalsSum = 0d;
            double sharpsSum = 0d;
            int index = 0;
            foreach (var item in frequencies)
            {
                if (dict.ContainsKey(item))
                {
                    notes[index] += dict[item];
                }
                if (dict[item].ToString().Length == 1)
                {
                    naturals[index] += dict[item];
                    naturalsSum += frequencies[index];
                }
                else
                {
                    sharps[index] += dict[item];
                    sharpsSum += frequencies[index];
                }

                index++;
            }

            List<string> nats = naturals.ToList();
            List<string> shps = sharps.ToList();
            for (int i = 0; i < nats.Count; i++)
            {
                if (nats[i] == null)
                {
                    nats.Remove(nats[i]);
                    i--;
                }
            }
            for (int i = 0; i < shps.Count; i++)
            {
                if (shps[i] == null)
                {
                    shps.Remove(shps[i]);
                    i--;
                }
            }


            Console.WriteLine("Notes: " + string.Join(" ", notes));
            Console.WriteLine("Naturals: " + string.Join(", ", nats));
            Console.WriteLine("Sharps: " + string.Join(", ", shps));
            Console.WriteLine($"Naturals sum: {Math.Round(naturalsSum, 2)}");
            Console.WriteLine($"Sharps sum: {Math.Round(sharpsSum, 2)}");
            
        }
    }
}
