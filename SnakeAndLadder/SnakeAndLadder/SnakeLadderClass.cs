using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class SnakeLadderClass
    {
        Random rand = new Random();
        int playerPosition, number, updatePosition, check, diceRollCount = 0, NO_PLAY=0, 
            LADDER = 1, SNAKE = 2, END_WIN_POSITION = 100;
        public void startGame()
        {
            Console.WriteLine("Start playing snake and ladder game");
            Console.WriteLine("Start position " + playerPosition);
            
            for (playerPosition = 0; playerPosition < END_WIN_POSITION;)
            {
                check = rand.Next(0, 3);
                number = rand.Next(1, 7);
                Console.WriteLine("Player get number " + number);

                if (check == LADDER)
                {
                    playerPosition += number;
                    Console.WriteLine("Moves ahead by " + number);
                }
                else if (check == SNAKE)
                {
                    playerPosition -= number;
                    Console.WriteLine("Moves behind by " + number);
                    if (playerPosition < 0)
                    {
                        playerPosition = 0;
                    }
                }
                else
                {
                    playerPosition += NO_PLAY;
                }
                diceRollCount++;
                Console.WriteLine("position after every die roll " + diceRollCount);
            }
                if (playerPosition > 100)
                {
                    playerPosition -= number;
                    updatePosition = 100 - playerPosition;
                    playerPosition += updatePosition;
                    
                }
            Console.WriteLine("\n Current position of player " + playerPosition);
            Console.WriteLine(diceRollCount + " number of times dice was rolled");
        }
    }
}
