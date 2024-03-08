using System;

namespace RPS
{
    class Program
    {
        private static void Main(string[] args)
        {
            int result = RockPaperScissors(args[0], args[1]);
            switch (result)
            {
                case 0:
                    Console.WriteLine("It's a draw!");
                    break;
                case 1:
                    Console.WriteLine("Player 1 wins!");
                    break;
                case 2:
                    Console.WriteLine("Player 2 wins!");
                    break;
            }
        }

        private static int RockPaperScissors(string player1, string player2)
        {
            GameItem p1 = (GameItem)Enum.Parse(typeof(GameItem), player1);
            GameItem p2 = (GameItem)Enum.Parse(typeof(GameItem), player2);

            GameStatus res;

            if (p1 == p2)
            {
                res = 0; // Draw
            }
            else if (((p1 == GameItem.Rock) && (p2 == GameItem.Scissors)) ||
                ((p1 == GameItem.Scissors) && (p2 == GameItem.Paper)) ||
                ((p1 == GameItem.Paper) && (p2 == GameItem.Rock)))
            {
                res = GameStatus.Player1Wins; // Player 1 wins
            }
            else
            {
                res = GameStatus.Player2Wins; // Player 2 wins
            }

            return (int)res;
        }
    }
}
