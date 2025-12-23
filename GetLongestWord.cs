using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest
{
    internal class GetLongestWord
    {
        static string LongestWord(string str)
        {
            string[] arr = str.Split(' ');
            int lenLargest = 0;
            int indexLargest = 0;
            for(int i = 0; i < arr.Length; ++i)
            {
                if (arr[i].Length > lenLargest)
                {
                    lenLargest = arr[i].Length;
                    indexLargest = i;
                }
            }
            return arr[indexLargest];
        }
        public static void Main()
        {
            Console.WriteLine("Enter sentence: ");
            string str = Console.ReadLine();
            Console.WriteLine($"Longest word in given sentence is {LongestWord(str)}");
        }
    }
}
