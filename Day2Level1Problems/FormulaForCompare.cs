using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day2Level1Problems
{
    internal class FormulaForCompare
    {
        public static void calc()
        {
            int n = int.Parse(Console.ReadLine());
            int formula = n * (n + 1) / 2;
            int summ = 0;
            for(; n != 0;n--)
            {
                summ += n;
            }
            if (formula == summ)
            {
                Console.WriteLine("both are same");
            }
            else if (summ < formula)
            {
                Console.WriteLine("loop result is smaller");
            }
            else
            {
                Console.WriteLine("formula result is smaller");
            }
        }
    }
}
