using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest
{
    internal class UseCase5
    {
        public static int IncrementPosition(int currentPosition,int dieRoll)
        {
            if(currentPosition+dieRoll> 99)
            {
                return currentPosition;
            }
            else
            {
                return currentPosition+dieRoll;
            }
        }
    }
}
