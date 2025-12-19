using System;
using System.Collections.Generic;
using System.Net.Cache;
using System.Text;

namespace ConsoleAppTest.Day4Level2Problems
{
    internal class YoungestTallest
    {
        public int FindYoungest(int[] arr)
        {
            if (arr[0] < arr[1])
            {
                if (arr[0] < arr[2]) return arr[0];
                else return arr[2];
            }
            else
            {
                if (arr[2] < arr[1]) return arr[2];
                else return arr[1];
            }
        }
        public int FindTallest(int[] arr)
        {
            if (arr[0] > arr[1])
            {
                if (arr[0] > arr[2]) return arr[0];
                else return arr[2];
            }
            else
            {
                if (arr[2] > arr[1]) return arr[2];
                else return arr[1];
            }
        }
        public static void Main()
        {
            Console.WriteLine("Enter the age of the three friends:");
            int[] age = new int[3];
            age[0] = int.Parse(Console.ReadLine());
            age[1] = int.Parse(Console.ReadLine());
            age[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height of the three friends");
            int[] height = new int[3];
            height[0] = int.Parse(Console.ReadLine());
            height[1] = int.Parse(Console.ReadLine());
            height[2] = int.Parse(Console.ReadLine());
            var obj = new YoungestTallest();
            Console.WriteLine($"{obj.FindTallest(height)} is the tallest and {obj.FindYoungest(age)} is the youngest");
        }

    }
}
