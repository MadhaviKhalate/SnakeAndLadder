// See https://aka.ms/new-console-template for more information
namespace SnakeAndLadder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SnakeLadderClass snakeladder = new SnakeLadderClass();
            TwoPlayerClass twoplayer = new TwoPlayerClass();
            snakeladder.startGame();
            twoplayer.startGame();
        }
    }
}