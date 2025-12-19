using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day4Level2Problems
{
    internal class CheckLeapYear
    {
        bool IsLeapYear(int year)
        {
            if((year%4==0 && year % 100 != 0) || (year % 400 == 0))
            {
                return true;
            }
            else { return false; }
        }
        public static void Main()
        {
            Console.WriteLine("Enter the year");
            int year = int.Parse(Console.ReadLine());
            if (year < 1582) { Console.WriteLine("Progtam only works after the year 1582 in the Gregorian calendar");return; }
            var obj = new CheckLeapYear();
            if (obj.IsLeapYear(year))
            {
                Console.WriteLine($"{year} is a Leap Year");
            }
            else Console.WriteLine($"{year} is not a Leap Year");
        }
    }
}
