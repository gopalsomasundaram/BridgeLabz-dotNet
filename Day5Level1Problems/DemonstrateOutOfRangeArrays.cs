using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day5Level1Problems
{
    internal class DemonstrateOutOfRangeArrays
    {
        static void CauseIndexOutOfRange()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };
            try
            {
                arr[16] = 11;
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index out of range exception caught: ");
                Console.WriteLine(ex.Message);
            }
        }
        public static void Main()
        {
            CauseIndexOutOfRange();
        }
    }
}
