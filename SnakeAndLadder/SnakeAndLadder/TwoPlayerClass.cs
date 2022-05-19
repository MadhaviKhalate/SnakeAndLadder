using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class TwoPlayerClass
    {
        
        public int diceNo, playerPosition = 0;
        const int noPlay = 0, ladder = 1, snake = 2;
        Random random = new Random();
        public int RollingDice()
        {
            diceNo = random.Next(1, 7);
            return diceNo;
        }
        public void Playing()
        {
        repeat:
            int option = random.Next(3);
            switch (option)
            {
                case noPlay:
                    playerPosition += 0;
                    break;
                case ladder:
                    playerPosition += RollingDice();
                    break;
                case snake:
                    playerPosition -= RollingDice();
                    break;
                default:
                    break;
            }
            if (playerPosition < 0)
            {
                playerPosition = 0;
                Console.Write(" Players Position is " + playerPosition +"\t");
            }
            else if (playerPosition > 100)
            {
                playerPosition -= diceNo;
                Console.Write(" Players Position is " + playerPosition + "\t");
            }
            else
            {
                Console.Write(" Players position is " + playerPosition +"");
            }
            if (option == ladder)
            {
                if (playerPosition != 100)
                {
                    Console.WriteLine();
                    Console.WriteLine("Again got chance to roll dice");
                    goto repeat;
                }
                Console.WriteLine("\n");
            }
        }
    }
}
