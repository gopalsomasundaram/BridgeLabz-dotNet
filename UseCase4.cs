using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest
{
    internal class UseCase4
    {
        public static int DecrementPosition(int currentPosition,int dieRoll)
        {
            if(currentPosition-dieRoll < 0)
                return 0;
            else return currentPosition - dieRoll;
        }
    }
}
