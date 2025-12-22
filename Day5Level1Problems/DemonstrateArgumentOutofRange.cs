using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day5Level1Problems
{

    internal class DemonstrateArgumentOutofRange
    {
        static void CauseArgOutOfRange()
        {
            string a = "this";
            try
            {
                Console.WriteLine(a.Substring(4, 6));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Argument out of range Exception Caught " + ex.Message);
            }
        }
        public static void Main()
        {
            CauseArgOutOfRange();
        }
    }
}
