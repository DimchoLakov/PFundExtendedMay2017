using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _02.StringDecryption
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> skipTake = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int skipCount = skipTake[0];
            int takeCount = skipTake[1];

            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var result = numbers.Where(x => x >= 65 && x <= 90).ToList();

            result = result.Skip(skipCount).Take(takeCount).ToList();

            List<char> finalResult = result.Select(x => (char) x).ToList();
            Console.WriteLine(string.Join("", finalResult));
        }
    }
}
