using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day2Level1Problems
{
    internal class SumTill0
    {
        public static void startSum()
        {
            double total = 0.0;
            double value = Convert.ToDouble(Console.ReadLine()); ;
            while(value != 0)
            {
                total += value;
                value = Convert.ToDouble(Console.ReadLine());
                
            }
            Console.WriteLine(total);
        }
    }
}
