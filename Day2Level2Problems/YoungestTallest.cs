using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day2Level2Problems
{
    internal class YoungestTallest
    {
        public static void find()
        {
            double age1, age2, age3;
            double height1, height2, height3;
            Console.WriteLine("Enter Ages of the 3 boys");
            age1 = double.Parse(Console.ReadLine());
            age2 = double.Parse(Console.ReadLine());
            age3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Heights of the 3 boys");
            height1 = double.Parse(Console.ReadLine());
            height2 = double.Parse(Console.ReadLine());
            height3 = double.Parse(Console.ReadLine());

            if (age1 < age2)
            {
                if (age1 < age3)
                {
                    Console.WriteLine($"{age1} is the youngest");
                }
                else Console.WriteLine($"{age3} is the youngest");
            }
            else
            {
                if (age2 < age3)
                {
                    Console.WriteLine($"{age2} is the youngest");
                }
                else Console.WriteLine($"{age3} is the youngest");
            }
            if (height1 > height2)
            {
                if (height1 > height3)
                {
                    Console.WriteLine($"{height1} is the tallest");
                }
                else Console.WriteLine($"{height3} is the tallest");
            }
            else
            {
                if (height2 > height3)
                {
                    Console.WriteLine($"{height2} is the tallest");
                }
                else Console.WriteLine($"{height3} is the tallest");
            }
        }
    }
}
