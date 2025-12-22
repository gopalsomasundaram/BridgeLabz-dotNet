using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest.Day5Level1Problems
{
    internal class DemonstrateNullReference
    {
        static void CauseNullReference()
        {
            string a = "yes";
            string b = null;
            try { Console.WriteLine($"{b[0]}"); }
            catch (NullReferenceException)
            {
                Console.WriteLine("null reference exception caught");
            }
            
        }
        public static void Main()
        {
            CauseNullReference();
        }
    }
}
