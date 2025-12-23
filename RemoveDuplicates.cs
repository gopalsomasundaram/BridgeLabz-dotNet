using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest
{
    internal class RemoveDuplicates
    {
        static string RemoveDuplicates(string text)
        {
            string result ="";
            for(int i = 0; i < text.Length; ++i)
            {
                if (!result.Contains(text[i]))
                {
                    result.Concat()
                }
            }
        }
        public static void Main()
        {
            Console.WriteLine("Enter the string to remove duplicates from");
            string str = Console.ReadLine();
            
        }
    }
}
