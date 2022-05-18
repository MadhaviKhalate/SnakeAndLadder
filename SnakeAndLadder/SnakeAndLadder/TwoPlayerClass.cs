using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class TwoPlayerClass
    {
        Random rand = new Random();
        int player1Position = 0, player2Position = 0, number, turn = 1,
            updatePosition, check, diceRollCount = 0, NO_PLAY = 0, LADDER = 1, 
            SNAKE = 2, END_WIN_POSITION = 100, i, j, player1DiceCount = 0, player2DiceCount = 0;
        public void startGame()
        {
            Console.WriteLine("Start playing snake and ladder game");
            Console.WriteLine("Start position of first player " + player1Position);
            Console.WriteLine("Start position of second player " + player2Position);

            while (player1Position < END_WIN_POSITION && player2Position < END_WIN_POSITION)
            {
                check = rand.Next(0, 3);
                number = rand.Next(1, 7);
                //Console.WriteLine("Player get number " + number);
                if (turn == 1)
                {
                    turn += 1;
                    player1DiceCount++;
                    if (check == LADDER)
                    {
                        player1Position += number;
                        Console.WriteLine("Moves ahead by " + number);
                    }
                    else if (check == SNAKE)
                    {
                        player1Position -= number;
                        Console.WriteLine("Moves behind by " + number);
                        if (player1Position < 0)
                        {
                            player1Position = 0;
                        }
                    }
                    else
                    {
                        player1Position += NO_PLAY;
                    }
                    if (player2Position > 100)
                    {
                        player2Position -= number;
                        //updatePosition = 100 - player2Position;
                        //player2Position += updatePosition;
                    }
                    Console.WriteLine("Current position of player1 " + player1Position);
                }
                else
                {
                    turn -= 1;
                    player2DiceCount++;
                    if (check == LADDER)
                    {
                        player2Position += number;
                        Console.WriteLine("Moves ahead by " + number);
                    }
                    else if (check == SNAKE)
                    {
                        player2Position -= number;
                        Console.WriteLine("Moves behind by " + number);
                        if (player2Position < 0)
                        {
                            player2Position = 0;
                        }
                    }
                    else
                    {
                        player2Position += NO_PLAY;
                    }
                    if (player2Position > 100)
                    {
                        player2Position -= number;
                        //updatePosition = 100 - player2Position;
                        //player2Position += updatePosition;
                    }
                    Console.WriteLine("Current position of player2 " + player2Position);
                }

            }
            Console.WriteLine(player1DiceCount + " number of times player1 played");
            Console.WriteLine(player2DiceCount + " number of times player2 played");
            diceRollCount = player1DiceCount + player2DiceCount;
            Console.WriteLine(diceRollCount + " number of times dice was rolled");

            if (player1Position == 100)
                Console.WriteLine("\n Player1 won the game ");
            else
                Console.WriteLine("\n Player2 won the game ");
        }
    }
}
