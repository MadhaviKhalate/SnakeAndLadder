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
        int startPosition = 0, number, check, LADDER = 1, SNAKE = 2;
        public void startGame()
        {
            number = rand.Next(1, 7);
            check = rand.Next(0, 3);
            Console.WriteLine("Start playing snake and ladder game");
            Console.WriteLine("Start position " + startPosition);
            Console.WriteLine("Player get number " + number);
         
            if (check == LADDER)
            {
                startPosition += number;
                Console.WriteLine("Moves ahead by " + number);
                Console.WriteLine("Current position of player " + startPosition);
            }
            else if (check == SNAKE)
            {
                startPosition -= number;
                Console.WriteLine("Moves behind by " + number);
                Console.WriteLine("Current position of player " + startPosition);
            }
            else
                Console.WriteLine("NoPlay!!!!!  player stay in same position");
        }

    }
}
