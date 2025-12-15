using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day1Level2Problems
{
    class AtheleteRunning
    {
        public static void calc()
        {
            int side1 = Convert.ToInt32(Console.ReadLine());
            int side2 = Convert.ToInt32(Console.ReadLine());
            int side3 = Convert.ToInt32(Console.ReadLine());
            int perimeter = side1 + side2 + side3;
            Console.WriteLine($"The total number of rounds the athlete will run is {(double)5/perimeter:f2} to complete 5 km");
        }
    }
}
