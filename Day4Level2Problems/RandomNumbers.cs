using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day4Level2Problems
{
    internal class RandomNumbers
    {
        public int[] Generate4DigitRandomArray(int size)
        {
            Random random = new Random();
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = random.Next(1000, 10000);
            }
            return arr;
        }
        public double[] FindAverageMinMax(int[] numbers)
        {
            double[] result = new double[3];
            double average = 0;
            double max = 0;
            double min = double.MaxValue;
            for(int i = 0; i < numbers.Length; ++i)
            {
                max = Math.Max(max, numbers[i]);
                min = Math.Min(min, numbers[i]);
                average += numbers[i];
            }
            average = average / numbers.Length;
            result[0] = average;
            result[1] = min;
            result[2] = max;
            return result;
        }
        public static void Main()
        {
            Console.WriteLine("Enter the size of the array");
            int n = int.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Invalid Input");
                return;
            }
            var obj = new RandomNumbers();
            int[] test = obj.Generate4DigitRandomArray(n);
            Console.WriteLine("Random Number array is");
            foreach(int i in test)
            {
                Console.WriteLine(i);
            }
            double[] result = obj.FindAverageMinMax(test);
            Console.WriteLine($"Average is {result[0]}\nMin is {result[1]}\nMax is {result[2]}");
        }
    }
}
