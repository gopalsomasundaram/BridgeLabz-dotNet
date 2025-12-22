using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day4Level3Problems
{
    internal class MeanMaxMinHeights
    {
        int[] GenerateRandomHeights()
        {
            int[] arr = new int[11];
            Random random = new Random();
            for(int i = 0; i < 11; i++)
            {
                arr[i] = random.Next(150,251);
            }
            return arr;
        }
        int FindSum(int[] arr)
        {
            int sum = 0;
            foreach(int i in arr)
            {
                sum += i;
            }
            return sum;
        }
        int FindMean(int[] arr)
        {
            int mean = 0;
            return (FindSum(arr) / arr.Length);
        }
        int FindShortest(int[] arr)
        {
            int shortest = int.MaxValue;
            foreach(int i in arr)
            {
                shortest = Math.Min(shortest, i);
            }
            return shortest;
        }
        int FindTallest(int[] arr)
        {
            int tallest = 0;
            foreach (int i in arr)
            {
                tallest = Math.Max(tallest, i);
            }
            return tallest;
        }
        public static void Main()
        {
            var obj = new MeanMaxMinHeights();
            int[] arr = obj.GenerateRandomHeights();
            Console.WriteLine("The generated heights are: ");
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine($"The mean height is {obj.FindMean(arr)}");
            Console.WriteLine($"The max height is {obj.FindTallest(arr)}");
            Console.WriteLine($"The min height is {obj.FindShortest(arr)}");
        }
    }
}
