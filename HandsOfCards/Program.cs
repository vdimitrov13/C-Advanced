using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            var players = new Dictionary<string, HashSet<string>>();
            var handout = Console.ReadLine();

            while (handout != "JOKER")
            {
                var handoutTokens = handout.Split(':');
                var playersName = handoutTokens[0];
                var cards = handoutTokens[1].Split(',').Select(a => a.Trim()).ToArray();

                if (players.ContainsKey(playersName))
                {
                    players[playersName].UnionWith(cards);
                }
                else
                {
                    players[playersName] = new HashSet<string>(cards);
                }

                handout = Console.ReadLine();
            }

            printAllPlayers(players);
        }

        private static void printAllPlayers(Dictionary<string, HashSet<string>> players)
        {
            foreach (var p in players)
            {
                var score = CalculateScore(p.Value);
                Console.WriteLine($"{p.Key}: {score}");
            }
        }

        private static object CalculateScore(HashSet<string> cards)
        {
            var totalScore = 0;
            foreach (var card in cards)
            {
                var type = card.Last();
                var power = card.Substring(0, card.Length - 1);

                int score;
                var isDigit = int.TryParse(power, out score);

                if (!isDigit)
                {
                    switch (power)
                    {
                        case "J":
                            score = 11;
                            break;
                        case "Q":
                            score = 12;
                            break;
                        case "K":
                            score = 13;
                            break;
                        case "A":
                            score = 14;
                            break;
                    }
                }
                switch (type)
                {
                    case 'S':
                        score *= 4;
                        break;
                    case 'H':
                        score *= 3;
                        break;
                    case 'D':
                        score *= 2;
                        break;
                    case 'C':
                        score *= 1;
                        break;
                }
                totalScore += score;
            }
            return totalScore;
        }
    }
}
