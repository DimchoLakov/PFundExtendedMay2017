using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Placeholders
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            while (text != "end")
            {
                string[] tokens = text.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);

                string[] elements = tokens[1].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                string sentence = tokens[0];

                for (int i = 0; i < elements.Length; i++)
                {
                    if (sentence.Contains($"{{{i}}}"))
                    {
                        sentence = sentence.Replace($"{{{i}}}", elements[i]);
                    }
                }
                Console.WriteLine(sentence);

                text = Console.ReadLine();
            }
        }
    }
}
