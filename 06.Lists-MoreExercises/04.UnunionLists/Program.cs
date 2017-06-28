using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.UnunionLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> primalInput = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> primalList = primalInput.Distinct().ToList();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
                List<int> temp = input.Distinct().ToList();


                for (int j = 0; j < temp.Count; j++)
                {
                    if (primalList.Contains(temp[j]))
                    {
                        primalList.Remove(temp[j]);
                        temp.Remove(temp[j]);
                        j--;
                    }
                }

                for (int j = 0; j < temp.Count; j++)
                {
                    if (!primalList.Contains(temp[j]))
                    {
                        primalList.Add(temp[j]);
                        j--;
                    }
                }

            }

            Console.WriteLine(string.Join(" ", primalList.OrderBy(a => a)));

        }
    }
}
