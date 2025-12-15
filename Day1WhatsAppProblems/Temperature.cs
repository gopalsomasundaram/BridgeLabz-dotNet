using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day1WhatsAppProblems
{
    class Temperature
    {
        public static void checkTemp()
        {
            Console.WriteLine("Enter the temperature you want to check:");
            int temp = Convert.ToInt32(Console.ReadLine());
            if (temp < 0) Console.WriteLine("Freezing");
            else if (temp >= 0 && temp <= 20) Console.WriteLine("Cold");
            else if (temp >= 21 && temp <= 35) Console.WriteLine("Warm");
            else Console.WriteLine("Hot");
        }
    }
}
