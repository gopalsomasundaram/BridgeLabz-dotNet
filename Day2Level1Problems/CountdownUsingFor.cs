using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day2Level1Problems
{
    internal class CountdownUsingFor
    {
        public static void startCount()
        {
            int startNum = Convert.ToInt32(Console.ReadLine());
            for (; startNum > 0; --startNum)
            {
                Console.WriteLine(startNum);
            }
        }
    }
}
