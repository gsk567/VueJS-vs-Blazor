using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Shared
{
    public static class Functions
    {
        public static GameResult GetGameResult(string[] gameboard)
        {
            List<int[]> winnerCombination = new List<int[]>()
            {
                new int[3] { 0, 1, 2 },
                new int[3] { 3, 4, 5 },
                new int[3] { 6, 7, 8 },
                new int[3] { 0, 3, 6 },
                new int[3] { 1, 4, 7 },
                new int[3] { 2, 5, 8 },
                new int[3] { 0, 4, 8 },
                new int[3] { 2, 4, 6 }
            };

            foreach (var combination in winnerCombination)
            {
                if (gameboard[combination[0]] == gameboard[combination[1]] && gameboard[combination[1]] == gameboard[combination[2]] && gameboard[combination[0]] != null)
                {
                    GameResult result = new GameResult
                    {
                        WinnerCombination = new int[3] { combination[0], combination[1], combination[2] },
                        WinnerSign = gameboard[combination[0]]
                    };
                    return result;
                }
            }

            return null;
        }
    }
}
