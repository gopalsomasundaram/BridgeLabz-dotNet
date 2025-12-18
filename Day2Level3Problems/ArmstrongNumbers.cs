using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day2Level3Problems
{
    internal class ArmstrongNumbers
    {
        public static void check()
        {
            Console.WriteLine("Enter possible armstring number:");
            int originalNumber = int.Parse(Console.ReadLine());
            int number = originalNumber;
            int sum = 0;
            while (number != 0)
            {
                sum +=(int)Math.Pow( number % 10, 3);
                number /= 10;
            }
            if (sum == originalNumber)
            {
                Console.WriteLine("It is an armstrong number");
            }
            else Console.WriteLine("It is not an armstrong number");
        }
    }
}
