using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day3Level1Problems
{
    internal class TwoDToOneD
    {
        public static void convert()
        {
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            int[,] arr = new int[rows, columns];
            for(int i = 0; i < rows; ++i)
            {
                for(int j = 0; j < columns; ++j)
                {
                    arr[i,j] = int.Parse(Console.ReadLine());
                }
            }
            int[] OneD = new int[rows * columns];
            int index = 0; 
            for (int i = 0; i < rows; ++i)
            {
                for (int j = 0; j < columns; ++j)
                {
                    OneD[index++] = arr[i,j]; 
                }
            }
            Console.WriteLine("The one dimensional array: ");
            foreach(int i in OneD)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
