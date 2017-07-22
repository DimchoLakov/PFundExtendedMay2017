using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _06.RectanglePosition
{
    public class Rectangle
    {
        public int Left { get; set; }
        public int Top { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Bottom
        {
            get
            {
                return Top + Height;
            }
        }

        public int Right
        {
            get
            {
                return Left + Width;
            }
        }

        public int CalcArea()
        {
            return Height * Width;
        }

        public bool IsInside(Rectangle rectangle)
        {
            var isLeftValid = rectangle.Left <= Left;
            var isTopValid = rectangle.Top <= Top;
            var isRightValid = rectangle.Right >= Right;
            var isBottomValid = rectangle.Bottom >= Bottom;

            return isLeftValid && isTopValid && isRightValid && isBottomValid;
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle firstRectangle = ReadRectangle();
            Rectangle secondRectangle = ReadRectangle();
            
            bool result = firstRectangle.IsInside(secondRectangle);
            
            string printResult = result ? $"Inside" : $"Not inside";
            
            Console.WriteLine(printResult);
        }

        public static Rectangle ReadRectangle()
        {
            int[] rectangleParts = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Rectangle rect = new Rectangle
            {
                Left = rectangleParts[0],
                Top = rectangleParts[1],
                Width = rectangleParts[2],
                Height = rectangleParts[3]
            };
            return rect;
        }
    }
}
