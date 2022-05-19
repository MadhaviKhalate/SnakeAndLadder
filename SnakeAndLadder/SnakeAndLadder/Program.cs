// See https://aka.ms/new-console-template for more information
namespace SnakeAndLadder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TwoPlayerClass Players1 = new TwoPlayerClass();
            TwoPlayerClass Players2 = new TwoPlayerClass();

            while (Players1.playerPosition < 100 && Players2.playerPosition < 100)
            {
                Players1.Playing();

                if (Players1.playerPosition == 100)
                {
                    Console.Write("Player1 won");
                    break;
                }

                Players2.Playing();

                if (Players2.playerPosition == 100)
                {
                    Console.Write("Player2 won");
                }
                Console.WriteLine();

            }
        }
    }
}