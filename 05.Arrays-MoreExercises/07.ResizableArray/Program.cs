using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.ResizableArray
{
    class Program
    {
        static int[] nums;
        static int currentIndex;
        static void Main(string[] args)
        {
            nums = new int[4];

            string[] input = Console.ReadLine().Split().ToArray();
            string command = input[0];

            currentIndex = 0;
            
            while (command != "end")
            {
                switch (command)
                {
                    case "push":

                        int numberToAdd = int.Parse(input[1]);
                        nums[currentIndex] = numberToAdd;
                        currentIndex++;

                        if (currentIndex >= nums.Length)
                        {
                            GrowArray();
                        }

                        break;
                    case "pop":

                        nums[currentIndex] = 0;
                        currentIndex--;

                        break;
                    case "removeAt":

                        int index = int.Parse(input[1]);
                        ShiftArray(index);
                        currentIndex--;

                        break;
                    case "clear":
                        
                        currentIndex = 0;

                        break;
                }
                input = Console.ReadLine().Split().ToArray();
                command = input[0];
            }

            PrintArray();

        }

        static void PrintArray()
        {
            for (int i = 0; i < currentIndex; i++)
            {
                Console.Write(nums[i] + " ");
            }
        }
        

        static void ShiftArray(int index)
        {
            for (int i = index + 1; i < currentIndex; i++)
            {
                nums[i - 1] = nums[i];
            }
        }

        static void GrowArray()
        {
            int[] extendedArray = new int[nums.Length * 2];

            for (int i = 0; i < currentIndex; i++)
            {
                extendedArray[i] = nums[i];
            }
            nums = extendedArray;
        }
    }
}