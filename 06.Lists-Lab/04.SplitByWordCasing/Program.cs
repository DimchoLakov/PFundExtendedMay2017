using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] characters = { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ', };
            List<string> text = Console.ReadLine().Split(characters, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> lowercase = new List<string>();
            List<string> uppercase = new List<string>();
            List<string> mixed = new List<string>();
            
            for (int i = 0; i < text.Count; i++)
            {
                char[] word = text[i].ToCharArray();
                bool isLower = CheckLower(word);
                bool isUpper = CheckUpper(word);

                if (isLower)
                {
                    lowercase.Add(text[i]);
                }
                else if (isUpper)
                {
                    uppercase.Add(text[i]);
                }
                else
                {
                    mixed.Add(text[i]);
                }

            }

            Console.WriteLine("Lower-case: " + string.Join(", ", lowercase));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixed));
            Console.WriteLine("Upper-case: " + string.Join(", ", uppercase));
        }

        static bool CheckLower(char[] word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (!char.IsLower(word[i]))
                {
                    return false;
                }
            }
            return true;
        }

        static bool CheckUpper(char[] word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (!char.IsUpper(word[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
