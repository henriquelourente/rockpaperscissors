using System;

namespace RockPaperScissors
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Start\n");

            var player1 = new[] { "Joao", "S" };
            var player2 = new[] { "Maria", "R" };

            var player3 = new[] { "Pedro", "P" };
            var player4 = new[] { "Marcos", "P" };

            var play1 = new[] { player1, player2 };
            var play2 = new[] { player3, player4 };

            Game.rps_tournament_winner(new[] { play1, play2 });
            Console.Read();
        }
    }
}
