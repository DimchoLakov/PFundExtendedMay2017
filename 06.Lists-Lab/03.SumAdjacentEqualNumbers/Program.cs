using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> list = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            double sum = 0d;
            int index = 0;

            while (index < list.Count - 1)
            {
                double currentNum = list[index];
                double nextNum = list[index + 1];

                if (currentNum == nextNum)
                {
                    sum = currentNum + nextNum;
                    list.RemoveAt(index + 1);
                    list[index] = sum;
                    if (index > 0)
                    {
                        index--;
                    }
                }
                else
                {
                    index++;
                }                
            }
            
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
