using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day4Level3Problems
{
    internal class Calendar
    {
        static string GetMonthName(int n)
        {
            string[] monthNames = new string[] { "january", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            return monthNames[n-1];
        }
        static bool IsLeapYear(int year)
        {
            if((year % 4 == 0 && year % 100 != 0)||(year%400 == 0))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static int NoOfDaysInMonth(int month,int year)
        {
            if(month == 2)
            {
                if (IsLeapYear(year))
                {
                    return 29;
                }
                else
                {
                    return 28;
                }
            }
            int[] daysInMonth = new int[] { 31, -1, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            return daysInMonth[month-1];
        }
        static int GetFirstDay(int y, int m)
        {
            int d = 1;
            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + (31 * m0) / 12) % 7;
            return d0;
        }
        public static void Main()
        {
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int day = GetFirstDay(year, month);

            Console.WriteLine(GetMonthName(month)+" "+year);
            string[] dayNames = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            for(int i = 0; i < 7 + day; ++i)
            {
                if (i < 6)
                {
                    Console.Write(dayNames[i] + " ");
                }
                else if (i == 6)
                {
                    Console.WriteLine(dayNames[i]);
                }
                else
                {
                    Console.Write("    ");
                }
                
            }
            int totalDaysInMonth = NoOfDaysInMonth(month, year);
            for(int i = 0; i < totalDaysInMonth; ++i)
            {
                if(day == 6)
                {
                    Console.WriteLine($"{i + 1,3} ");
                    day = 0;
                }
                else {
                    Console.Write($"{i + 1,3} ");
                    day++;
                }
            }

        }
    }
}
