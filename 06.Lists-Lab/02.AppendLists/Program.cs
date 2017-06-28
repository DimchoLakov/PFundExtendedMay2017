using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split('|').ToList();
            List<string> result = new List<string>();

            for (int i = input.Count - 1; i >= 0; i--)
            {
                result.AddRange(input[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
