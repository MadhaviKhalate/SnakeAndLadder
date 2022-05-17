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
        int startPosition, number, check, LADDER = 1, SNAKE = 2, END_WIN_POSITION = 100;
        public void startGame()
        {
            Console.WriteLine("Start playing snake and ladder game");
            Console.WriteLine("Start position " + startPosition);
            
            for (startPosition = 0; startPosition <= END_WIN_POSITION;)
            {
                check = rand.Next(0, 3);
                number = rand.Next(1, 7);
                Console.WriteLine("Player get number " + number);

                if (check == LADDER)
                {
                    startPosition += number;
                    Console.WriteLine("Moves ahead by " + number);
                }
                else if (check == SNAKE)
                {
                    startPosition -= number;
                    Console.WriteLine("Moves behind by " + number);
                    if (startPosition < 0)
                    {
                        startPosition = 0;
                    }

                }
                else
                {
                    Console.WriteLine("NoPlay!!!!");
                }
            }
            Console.WriteLine("Current position of player " + startPosition);

        }

    }
}
