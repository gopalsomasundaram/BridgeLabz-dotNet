using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day5Level1Problems
{
    internal class DemonstrateFormatExcepton
    {
        static void CauseFormatException()
        {
            try
            {
                int a = int.Parse(Console.ReadLine());
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Format Exception Caught");
                Console.WriteLine(ex.Message);
            }
        }
        public static void Main()
        {
            CauseFormatException();
        }
    }
}
