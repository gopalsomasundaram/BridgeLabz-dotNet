using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest
{
    internal class UseCase6
    {
        int DieThrows = 0;
        public void IncrementDieThrows()
        {
            DieThrows++;
        }
        public int GetDieThrows()
        {
            return DieThrows;
        }
    }
}
