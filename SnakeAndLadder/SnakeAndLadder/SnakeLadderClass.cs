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
        int startPosition = 0, number;
        public void startGame()
        {
            number = rand.Next(1, 7);
            Console.WriteLine("Start playing snake and ladder game");
            Console.WriteLine("Start position " + startPosition);
            Console.WriteLine("Player get number " + number);
        }

    }
}
