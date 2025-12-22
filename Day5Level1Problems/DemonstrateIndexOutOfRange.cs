using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day5Level1Problems
{
    internal class DemonstrateIndexOutOfRange
    {
        static void CauseIndexException()
        {
            string a = "test";
            try { Console.WriteLine(a[5]); }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("index out of range exception caught" + e.Message);
            }
        }
        public static void Main()
        {
            CauseIndexException();
        }
    }
}
