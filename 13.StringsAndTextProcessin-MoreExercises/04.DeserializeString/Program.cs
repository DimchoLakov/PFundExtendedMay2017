using System;
using System.Linq;
using System.Text;

namespace _04.DeserializeString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            sb.Append(' ', 10000);
            while (input != "end")
            {
                string[] tokens = input.Split(new char[] { ':', '/' }, StringSplitOptions.RemoveEmptyEntries);
                char symbol = char.Parse(tokens[0]);
                int[] indexes = tokens.Skip(1).Select(int.Parse).ToArray();

                foreach (int index in indexes)
                {
                    sb.Replace(' ', symbol, index, 1);
                }
                input = Console.ReadLine();
            }
            string result = sb.ToString().Trim();
            Console.WriteLine(result);
        }
    }
}
