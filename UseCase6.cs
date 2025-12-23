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
        public static void Main()
        {
            int playerPosition = UseCase1.StartPlayer();
            var obj = new UseCase6();
            while (true)
            {
                while (true)
                {
                    int dieMove = UseCase2.GetRandomDie();
                    obj.IncrementDieThrows();
                    Console.WriteLine($"Player gets a die roll of {dieMove}");
                    int moveOption = UseCase3.GetOption();
                    if (moveOption == 1)
                    {
                        Console.WriteLine("player gets option of no play");
                        //no play
                        break;
                    }
                    else if (moveOption == 2)
                    {
                        Console.WriteLine("Player gets option of ladder he can play again after this move");
                        //ladder
                        playerPosition = UseCase5.IncrementPosition(playerPosition, dieMove);
                        Console.WriteLine($"After moving forward Player is at position {playerPosition}");
                        if (playerPosition == 99)
                        {
                            Console.WriteLine("Player wins");
                            Console.WriteLine($"Player threw the dice {obj.GetDieThrows()} times to win");
                            return;
                        }
                        continue;//player plays again when ladder

                    }
                    else
                    {
                        Console.WriteLine("Player gets option of snake ");
                        playerPosition = UseCase4.DecrementPosition(playerPosition, dieMove);
                        Console.WriteLine($"After moving backward player is at position of {playerPosition}");
                        break;
                    }
                }
            }
        }
    }
}
