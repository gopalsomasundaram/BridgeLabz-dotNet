using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day2Level3Problems
{
    internal class Count
    {
        public static void getCount()
        {
            int x = int.Parse(Console.ReadLine());
            int count=0;
            while (x != 0)
            {
                count++;
                x /= 10;
            }
            Console.WriteLine($"the number has {count} digits");
        }
    }
}
