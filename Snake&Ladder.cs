using System;

namespace SnakeLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i >= 100; i++) ;
            {
                int player = 0;
                int playerPosition;
                int i = playerPosition;
                Random random = new Random();
                int diceOutcome = random.Next(1,7);
                Console.WriteLine("Number on the dice is " +diceOutcome);
                //random method for checking options
                //0=no move
                //1=ladder
                //2=snake
                Random random2 = new Random();
                int optionsCheck = random2.Next(0,3);
                Console.WriteLine("no move = 0");
                Console.WriteLine("ladder = 1");
                Console.WriteLine("snake = 2");
                Console.WriteLine("The option is " +optionsCheck);
               // if ladder then playerPosition = playerPosition+diceOutcome
               // if snake then playerPosition = playerPosition-diceOutcome
               // if no move then playerPosition = 0
    

                if (optionsCheck == 2)
                {
                    playerPosition = player - diceOutcome;
                    Console.WriteLine("The players position after dice throw is " + playerPosition);
                }
                else if (optionsCheck == 1)
                {
                    playerPosition = player + diceOutcome;
                    Console.WriteLine("The players position after dice throw is " + playerPosition);
                }
                else
                {
                    player = 0;
                    Console.WriteLine("The players position after dice throw is " + player);
                }
                if (playerPosition<0)
                {
                    playerPosition = 0;
                }
            }
        }

    }
}
