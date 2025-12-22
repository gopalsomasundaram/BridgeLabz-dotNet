using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day4Level3Problems
{
    internal class EuclideanDistanceAndLineEquation
    {
        static double EuclideanDistance(int x1, int y1, int x2, int y2)
        {
            double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return distance;
        }

        static double[] LineEquation(int x1, int y1, int x2, int y2)
        {
            double slope = (double)(y2 - y1) / (x2 - x1);
            double b = y1 - slope * x1;
            double[] arr = new double[] { slope, b };
            return arr;
        }
        public static void Main()
        {
            Console.WriteLine("Enter the X co-ordinates of the first point");
            int x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Y co-ordinates of the first point");
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the X co-ordinates of the second point");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the X co-ordinates of the second point");
            int y2 = int.Parse(Console.ReadLine());
            double distance = EuclideanDistance(x1, y1, x2, y2);
            Console.WriteLine($"The Euclidean distance between the two points is {distance}");
            double[] result = LineEquation(x1, y1, x2, y2);
            Console.WriteLine($"y = {result[0]:f} * x + {result[1]:f}");
        }
    }
}
