using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest
{
    internal class Palindrome
    {
        static bool IsPalindrome(string text)
        {
            bool flag = true;
            int left = 0;
            int right = text.Length-1;
            while (left < right)
            {
                if (text[left] != text[right])
                {
                    flag = false;
                }
                left++;
                right--;
            }
            return flag;
        }
        public static void Main()
        {
            Console.WriteLine("Enter the string to be checked for palindrome:");
            string str = Console.ReadLine();
            if (IsPalindrome(str))
            {
                Console.WriteLine("Given string is a palindrome");
            }
            else
            {
                Console.WriteLine("Given string is not a palindrome");
            }
        }
    }
}
