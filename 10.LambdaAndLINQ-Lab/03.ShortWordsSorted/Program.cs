using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine()
                .Split(new char[] {' ', '.', ',', ':', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?'},
                    StringSplitOptions.RemoveEmptyEntries).ToList();

            text = text.Where(x => x.Length < 5).OrderBy(x => x).Select(x => x.ToLower()).Distinct().ToList();

            Console.WriteLine(string.Join(", ", text));

        }
    }
}
