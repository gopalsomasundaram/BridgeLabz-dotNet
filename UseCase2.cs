using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest
{
    internal class UseCase2
    {
        public static int GetRandomDie()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }
    }
}
