using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day4Level3Problems
{
    internal class Collinearity
    {
        static double getSlope(int x1,int y1, int x2, int y2)
        {
            double slope = (double)(y2 - y1) / (x2 - x1);
            return slope;
        }
        static bool checkCollinear(int x1,int y1, int x2, int y2, int x3, int y3)
        {
            double slopeAB = getSlope(x1, y1, x2, y2);
            double slopeBC = getSlope(x2, y2, x3, y3);
            double slopeAC = getSlope(x1, y1, x3, y3);
            return ((slopeAB == slopeBC) && (slopeBC == slopeAC) && (slopeAB == slopeAC));
        }
        static bool CheckCollinearUsingArea(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            double area = (0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)));
            if (area == 0.0d)
            {
                return true;
            }
            else return false;
        }
        public static void Main()
        {
            int x1, y1, x2, y2, x3, y3;
            Console.WriteLine("Enter the X coordinates of point A");
            x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Y coordinates of point A");
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the X coordinates of point B");
            x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Y coordinates of point B");
            y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the X coordinates of point C");
            x3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Y coordinates of point C");
            y3 = int.Parse(Console.ReadLine());

            if(checkCollinear(x1, y1, x2, y2, x3, y3))
            {
                Console.WriteLine("They are collinear");
            }
            else
            {
                Console.WriteLine("They are not collinear");
            }
            if(CheckCollinearUsingArea(x1, y1, x2, y2, x3, y3))
            {
                Console.WriteLine("They are collinear");
            }
            else
            {
                Console.WriteLine("They are not collinear");
            }
        }
    }
}
