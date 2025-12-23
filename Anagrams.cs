using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest
{
    internal class Anagrams
    {
        static bool AreAnagrams(string str1, string str2)
        {
            if(str1.Length!= str2.Length)
            {
                return false;
            }
            char[] arr1 = str1.ToCharArray();
            char[] arr2 = str2.ToCharArray();

            Array.Sort(arr1);
            Array.Sort(arr2);

            for(int i = 0; i < arr1.Length; ++i)
            {
                if (arr1[i] != arr2[i])
                {
                    return false;
                }
            }
            return true;
        }
        public static void Main()
        {
            Console.WriteLine("Enter the first string:");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter the second string:");
            string str2 = Console.ReadLine();
            if (AreAnagrams(str1,str2))
            {
                Console.WriteLine("They are anagrams");
            }
            else
            {
                Console.WriteLine("They are not anagrams");
            }
        }
    }
}
