using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest
{
    internal class RemoveDuplicates
    {
        static string RemoveDupes(string text)
        {
            string result ="";
            for(int i = 0; i < text.Length; ++i)
            {
                if (result.IndexOf(text[i]) == -1)
                {
                    result = string.Concat(result, text[i]);
                }
            }
            return result;
        }
        public static void Main()
        {
            Console.WriteLine("Enter the string to remove duplicates from");
            string str = Console.ReadLine();
            string result = RemoveDupes(str);
            Console.WriteLine(result);
        }
    }
}
