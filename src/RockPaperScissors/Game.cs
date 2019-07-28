using System;
using System.Collections.Generic;
using System.Linq;

namespace RockPaperScissors
{
    public class Game
    {

        public static string[] rps_tournament_winner(dynamic[] tournament)
        {
            if (tournament[0] is string[])
                return Match(tournament[0], tournament[1]);

            return rps_tournament_winner(new[] { rps_tournament_winner(tournament[0]), rps_tournament_winner(tournament[1]) });
        }

        public static string[] Match(string[] player1, string[] player2)
        {
            if (!StrategyIsValid(player1[1]) || !StrategyIsValid(player2[1]))
                throw new Exception("NoSuchStrategyError.");

            //apenas para exibir a saíde
            string[] winner;
            string[] loser;

            if (MatchRule(player1, player2))
            {
                winner = player1;
                loser = player2;
            }
            else
            {
                winner = player2;
                loser = player1;
            }

            Console.WriteLine($"{winner[0]} would beat {loser[0]} ({winner[1]} > {loser[1]})");
            //fim


            return winner;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="player1"></param>
        /// <param name="player2"></param>
        /// <returns>True: player1 winner, False: player 2 winner</returns>
        private static bool MatchRule(string[] player1, string[] player2)
        {
            switch (player1[1])
            {
                case "R": return !(player2[1].Equals("P"));
                case "P": return !(player2[1].Equals("S"));
                default: return !(player2[1].Equals("R"));
            }
        }

        private static bool NumberOfPlayersIsValid(List<string[]> list) => (list == null || list.Count != 2);

        private static bool StrategyIsValid(string strategy) => new[] { "R", "P", "S" }.Any(s => s == strategy);
    }
}
