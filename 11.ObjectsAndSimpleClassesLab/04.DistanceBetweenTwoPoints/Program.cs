using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DistanceBetweenTwoPoints
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point firstPoint = ReadPoint();
            Point secondPoint = ReadPoint();

            double distance = CalcDistance(firstPoint, secondPoint);

            Console.WriteLine($"{distance:f3}");
        }

        public static Point ReadPoint()
        {
            int[] pointParts = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            return new Point
            {
                X = pointParts[0],
                Y = pointParts[1]
            };
    }

        public static double CalcDistance(Point firstPoint, Point secondPoint)
        {
            var hypotenuse = Math.Sqrt(Math.Pow(firstPoint.X - secondPoint.X, 2) + Math.Pow(firstPoint.Y - secondPoint.Y, 2));
            return hypotenuse;
        }
    }
}
