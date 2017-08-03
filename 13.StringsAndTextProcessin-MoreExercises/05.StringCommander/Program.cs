using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.StringCommander
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder(text);

            while (input != "end")
            {
                string[] tokens = input.Split(' ');
                string command = tokens[0];

                switch (command)
                {
                    case "Left":
                        int moveLeftTimes = int.Parse(tokens[1]);
                        int stepsLeft = moveLeftTimes % result.Length;
                        for (int i = 0; i < stepsLeft; i++)
                        {
                            char firstElement = result[0];
                            result.Remove(0, 1);
                            result.Append(firstElement, 1);
                        }
                        break;
                    case "Right":
                        int moveRightTimes = int.Parse(tokens[1]);
                        int stepsRight = moveRightTimes % result.Length;
                        for (int i = 0; i < stepsRight; i++)
                        {
                            char lastElement = result[result.Length - 1];
                            result.Remove(result.Length - 1, 1);
                            result.Insert(0, lastElement);
                        }
                        break;
                    case "Insert":
                        int index = int.Parse(tokens[1]);
                        string strToInsert = tokens[2];
                        result.Insert(index, strToInsert);
                        break;

                    case "Delete":
                        int startIndex = int.Parse(tokens[1]);
                        int length = int.Parse(tokens[2]);
                        result.Remove(startIndex, length - startIndex + 1);
                        break;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(result.ToString());
        }
    }
}
