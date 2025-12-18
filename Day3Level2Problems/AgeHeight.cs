using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day3Level2Problems
{
    internal class AgeHeight
    {
        public static void getYoungestTallest()
        {
            int[] age = new int[3];
            int[] height = new int[3];
            int youngest = int.MaxValue;
            int tallest = 0;
            Console.WriteLine("Enter Age followed By Height of each person:");
            for(int i = 0; i < 3; ++i)
            {
                age[i] = int.Parse(Console.ReadLine());
                height[i] = int.Parse(Console.ReadLine());
                if (age[i]<youngest) youngest = age[i];
                if (height[i] > tallest) tallest = height[i];
            }
            Console.WriteLine($"The boy at position {age.IndexOf(youngest)+1} is youngest and boy at position {height.IndexOf(tallest)+1} is tallest");
        }
    }
}
