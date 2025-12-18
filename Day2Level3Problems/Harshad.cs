using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day2Level3Problems
{
    internal class Harshad
    {
        public static void check()
        {
            Console.WriteLine("Enter the number:");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int copy = n;
            while (copy != 0)
            {
                sum += copy % 10;
                copy /= 10;
            }
            if(n%sum == 0)
            {
                Console.WriteLine($"{n} is a harshad number");
            }
            else
            {
                Console.WriteLine($"{n} is not a harshad number");
            }
        }
    }
}
