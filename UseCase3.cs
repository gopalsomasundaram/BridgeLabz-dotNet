using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest
{
    internal class UseCase3
    {
        public static int GetOption()
        {
            Random random = new Random();
            return random.Next(1, 4);
        }
    }
}
