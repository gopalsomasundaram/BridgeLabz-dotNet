using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day5Level1Problems
{
    internal class Substring
    {
        static string GetSubstring(string str, int a, int b)
        {
            char[] arr = new char[b - a + 1];
            int index = 0;
            for(int i = 0; i < str.Length; ++i)
            {
                if(i>=a && i <= b)
                {
                    arr[index++] = str[i];
                }
            }
            Console.WriteLine($"Substring from custom method: {string.Concat(arr)}");
            return string.Concat(arr);
        }
        public static void Main()
        {
            Console.WriteLine("Enter the string you want to get substring of: ");
            string str = Console.ReadLine();
            for(int i = 0; i < str.Length; ++i)
            {
                Console.WriteLine(i + " -> " + str[i]);
            }
            Console.WriteLine("Enter the start index of the substring");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the end index of the substring");
            int stop = int.Parse(Console.ReadLine());

            string sub = str.Substring(start,stop);
            Console.WriteLine($"Substring from string methods: {sub}");
            if(sub == GetSubstring(str, start, stop))
            {
                Console.WriteLine("Substring result of both are same");
            }
            else
            {
                Console.WriteLine("Substring results are different from both functions");
            }
        }
    }
}
