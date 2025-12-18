using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Markup;

namespace ConsoleAppTest.Day2Level1Problems
{
    internal class SumTill0OrNegative
    {
        public static void startSum()
        {
            double total = 0.0;
            double value = Convert.ToDouble(Console.ReadLine()); ;
            while ((value != 0)||(value<=0))
            {
                total += value;
                value = Convert.ToDouble(Console.ReadLine());

            }
            Console.WriteLine(total);
        }
    }
}
