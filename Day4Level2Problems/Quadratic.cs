using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day4Level2Problems
{
    internal class Quadratic
    {
        double[] GetRoots(double a, double b, double c)
        {
            double[] result = new double[2];
            double delta = Math.Pow(b, 2) + 4 * a * c;
            if (delta > 0)
            {
                result[0] = ((-1*b + delta) / (2 * a));
                result[1] = ((-1*b - delta) / (2 * a));
                return result;
            }else if (delta == 0)
            {
                result[0] = ((-1 * b) / (2 * a));
                return result;
            }
            else
            {
                return result;
            }
        }
        public static void Main()
        {
            Console.WriteLine("Enter a, b and c");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            var obj = new Quadratic();
            double[] result = obj.GetRoots(a,b,c);
            if (result[0]!= 0 && result[1] != 0)
            {
                Console.WriteLine($"Two roots are {result[0]} and {result[1]}");
            }
            else if (result[0] != 0 && result[1] == 0)
            {
                Console.WriteLine($"root is {result[0]}");
            }else
            {
                Console.WriteLine("No Roots");
            }
        }
    }
}
