using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day3Level1Problems
{
    internal class MeanHeight
    {
        public static void calc()
        {
            double[] playerHeights = new double[11];
            double sum = 0;
            for(int i = 0; i < playerHeights.Length; i++)
            {
                playerHeights[i] = double.Parse(Console.ReadLine());
                sum += playerHeights[i];
            }
            Console.WriteLine($"mean height of football team is {sum/11}");
        }
    }
}
