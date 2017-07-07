using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.TrackDownloader
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> blacklistedWords = Console.ReadLine().Split(' ').ToList();
            List<string> result = new List<string>();

            char[] delimiters = new char[] { ' ', '.', '(', ')', '\'', '_' };

            string input = Console.ReadLine();

            List<string> filenames = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToList();

            bool isBlackListed = false;

            while (input != "end")
            {

                for (int i = 0; i < blacklistedWords.Count; i++)
                {
                    if (input.Contains(blacklistedWords[i]))
                    {
                        isBlackListed = true;
                        break;
                    }
                }

                if (!isBlackListed)
                {
                    result.Add(input);
                }

                isBlackListed = false;
                input = Console.ReadLine();
                filenames = input.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToList();
            }


            result.Sort();
            Console.WriteLine(string.Join("\n", result));
        }
    }
}
