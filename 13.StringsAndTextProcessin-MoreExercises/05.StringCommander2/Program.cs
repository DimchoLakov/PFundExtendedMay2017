using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.StringCommander2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(' ');
                string command = tokens[0];

                switch (command)
                {
                    case "Left":
                        int moveLeftTimes = int.Parse(tokens[1]);
                        int stepsLeft = moveLeftTimes % text.Length;
                        text = text.Substring(stepsLeft) + text.Substring(0, stepsLeft);
                        break;
                    case "Right":
                        int moveRightTimes = int.Parse(tokens[1]);
                        int stepsRight = moveRightTimes % text.Length;
                        text = text.Substring(text.Length - stepsRight) + text.Substring(0, text.Length - stepsRight);
                        break;
                    case "Insert":
                        int index = int.Parse(tokens[1]);
                        string strToInsert = tokens[2];
                        text = text.Insert(index, strToInsert);
                        break;

                    case "Delete":
                        int startIndex = int.Parse(tokens[1]);
                        int length = int.Parse(tokens[2]);
                        text = text.Remove(startIndex, length - startIndex + 1);
                        break;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(text);
        }
    }
}
