using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _05.Boxes
{
    class Box
    {
        public Point UpperLeft { get; set; }
        public Point UpperRight { get; set; }
        public Point BottomLeft { get; set; }
        public Point BottomRight { get; set; }

        public int Width
        {
            get
            {
                return (int)Point.CalculateDistance(UpperLeft, UpperRight);
            }
        }

        public int Height
        {
            get
            {
                return (int)Point.CalculateDistance(UpperLeft, BottomLeft);
            }
        }

        public Box(Point upperLeft, Point upperRight, Point bottomLeft, Point bottomRight)
        {
            UpperLeft = upperLeft;
            UpperRight = upperRight;
            BottomLeft = bottomLeft;
            BottomRight = bottomRight;
        }

        public static int CalculatePerimeter(int width, int height)
        {
            return 2 * width + 2 * height;
        }

        public static int CalculateArea(int width, int height)
        {
            return width * height;
        }

    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static double CalculateDistance(Point firstPoint, Point secondPoint)
        {
            var hypotenuse = Math.Sqrt(Math.Pow(firstPoint.X - secondPoint.X, 2) + Math.Pow(firstPoint.Y - secondPoint.Y, 2));
            return hypotenuse;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] tokens = input.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);

                List<Point> points = new List<Point>();

                for (int i = 0; i < tokens.Length; i++)
                {
                    int[] coordinates = tokens[i].Split(':').Select(int.Parse).ToArray();

                    points.Add(new Point(coordinates[0], coordinates[1]));
                }

                Box box = new Box(points[0], points[1], points[2], points[3]);

                Console.WriteLine($"Box: {box.Width}, {box.Height}");

                int perimeter = Box.CalculatePerimeter(box.Width, box.Height);

                Console.WriteLine($"Perimeter: {perimeter}");

                int area = Box.CalculateArea(box.Width, box.Height);

                Console.WriteLine($"Area: {area}");

                input = Console.ReadLine();
            }

        }
    }
}
