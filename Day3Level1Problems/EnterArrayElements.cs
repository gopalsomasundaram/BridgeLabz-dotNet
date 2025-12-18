using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day3Level1Problems
{
    internal class EnterArrayElements
    {
        public static void start()
        {
            double[] arr = new double[10];
            double total = 0.0;
            int index = 0;
            while (true)
            {
                double inp = double.Parse(Console.ReadLine());
                if ((inp == 0) || (inp < 0)||(index == 10)) break;
                arr[index++] = inp;
            }
            for(int i = 0; i < arr.Length; i++)
            {
                total += arr[i];
            }
            Console.WriteLine(total);
        }
    }
}
