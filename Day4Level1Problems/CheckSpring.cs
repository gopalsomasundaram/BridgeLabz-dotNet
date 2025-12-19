using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day4Level1Problems
{
    internal class CheckSpring
    {
        bool SpringCheck(int month, int day)
        {
            if (month == 3 && day >= 20) return true;
            else if (month == 6 && day <= 20) return true;
            else if (month > 3 && month < 6) return true;
            else return false;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the month: ");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the day");
            int day = int.Parse(Console.ReadLine());
            if(month<=0 || month >12 || day <=0 || day > 31)
            {
                Console.WriteLine("Invalid Input");
                return;
            }
            var obj = new CheckSpring();
            bool result = obj.SpringCheck(month, day);
            if (result) Console.WriteLine("It is spring season");
            else Console.WriteLine("It is not spring season");
        }
    }
}
