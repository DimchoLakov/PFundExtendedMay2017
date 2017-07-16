using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Winecraft
{
    class Program
    {
        static void Main(string[] args)
        {
            var grapes = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            var rounds = int.Parse(Console.ReadLine());
            var grapesCounter = grapes.Length;
            var workGrapes = new int[grapesCounter]; 

            while (grapesCounter >= rounds)
            {

                for (int counter = 0; counter < rounds; counter++)
                {

                    for (int index = 0; index < grapes.Length; index++)
                    {

                        for (int kindIndex = 1; kindIndex < grapes.Length - 1; kindIndex++)
                        {
                            if (grapes[kindIndex] > grapes[kindIndex - 1] && grapes[kindIndex] > grapes[kindIndex + 1])
                            {
                                workGrapes[kindIndex] = 1;
                                workGrapes[kindIndex - 1] = -1;
                                workGrapes[kindIndex + 1] = -1;
                            }
                        }
                        if (workGrapes[index] == 0 && grapes[index] > 0)
                        {
                            grapes[index]++;
                        }
                        else if (workGrapes[index] == 1)
                        {
                            grapes[index]++;
                            if (grapes[index - 1] > 0)
                            {
                                grapes[index - 1]--;
                                grapes[index]++;
                            }
                            if (grapes[index + 1] > 0)
                            {
                                grapes[index + 1]--;
                                grapes[index]++;
                            }
                            index++;
                        }
                    }
                }
                grapesCounter = grapes.Length;
                for (int index = 0; index < grapes.Length; index++)
                {
                    if (grapes[index] <= rounds)
                    {
                        grapes[index] = 0;
                        grapesCounter--;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", grapes.Where(x => x > 0)));
        }
    }
}
