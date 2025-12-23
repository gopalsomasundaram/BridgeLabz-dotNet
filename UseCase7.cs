using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTest
{
    internal class UseCase7
    {
        public static void Main()
        {
            int playerAPosition = UseCase1.StartPlayer();
            int playerBPosition = UseCase1.StartPlayer();
            var objA = new UseCase6();
            var objB = new UseCase6();
            while (true) { 
                //player A plays
                while (true)
                {
                    int dieMove = UseCase2.GetRandomDie();
                    objA.IncrementDieThrows();
                    Console.WriteLine($"Player A get a die roll of {dieMove}");
                    int moveOption = UseCase3.GetOption();
                    if(moveOption == 1)
                    {
                        Console.WriteLine("player A gets option of no play");
                        //no play
                        break;
                    }else if(moveOption == 2)
                    {
                        Console.WriteLine("Player A gets option of ladder he can play again after this move");
                        //ladder
                        playerAPosition = UseCase5.IncrementPosition(playerAPosition, dieMove);
                        Console.WriteLine($"After moving forward Player A is at position {playerAPosition}");
                        if(playerAPosition == 99)
                        {
                            Console.WriteLine("Player A wins");
                            Console.WriteLine($"Player A threw the dice {objA.GetDieThrows()} times to win");
                            return;
                        }
                        continue;//player plays again when ladder

                    }
                    else
                    {
                        Console.WriteLine("Player A gets option of snake ");
                        playerAPosition = UseCase4.DecrementPosition(playerAPosition, dieMove);
                        Console.WriteLine($"After moving backward player A is at position of {playerAPosition}");
                        break;
                    }
                }
                //player b plays
                while (true)
                {
                    int dieMove = UseCase2.GetRandomDie();
                    objB.IncrementDieThrows();
                    Console.WriteLine($"Player B get a die roll of {dieMove}");
                    int moveOption = UseCase3.GetOption();
                    if (moveOption == 1)
                    {
                        Console.WriteLine("player B gets option of no play");
                        //no play
                        break;
                    }
                    else if (moveOption == 2)
                    {
                        Console.WriteLine("Player B gets option of ladder he can play again after this move");
                        //ladder
                        playerBPosition = UseCase5.IncrementPosition(playerBPosition, dieMove);
                        Console.WriteLine($"After moving forward Player B is at position {playerBPosition}");
                        if (playerBPosition == 99)
                        {
                            Console.WriteLine("Player B wins");
                            Console.WriteLine($"Player B threw the dice {objB.GetDieThrows()} times to win");
                            return;
                        }
                        continue;//player plays again when ladder

                    }
                    else
                    {
                        Console.WriteLine("Player B gets option of snake ");
                        playerBPosition = UseCase4.DecrementPosition(playerBPosition, dieMove);
                        Console.WriteLine($"After moving backward player B is at position of {playerBPosition}");
                        break;
                    }
                }
            }
        }
    }
}
