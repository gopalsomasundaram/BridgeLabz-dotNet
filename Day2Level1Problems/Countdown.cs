using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day2Level1Problems
{
    internal class Countdown
    {
        public static void startCount()
        {
            int startNum = Convert.ToInt32(Console.ReadLine());
            while (startNum > 0)
            {
                Console.WriteLine(startNum);
                startNum -= 1;
            }
        }
    }
}
