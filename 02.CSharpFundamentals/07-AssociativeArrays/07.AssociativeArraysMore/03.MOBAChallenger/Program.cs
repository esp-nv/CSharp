using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MOBAChallenger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> playerStats = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, HashSet<string>> playerGames = new Dictionary<string, HashSet<string>>();

            string input;
            string output;

            while ((input = Console.ReadLine()) != "Season end")
            {
                if (input.Contains("->"))
                {
                    var tokens = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                    string playerName = tokens[0];
                    string gameName = tokens[1];
                    int points = int.Parse(tokens[2]);
                    if (!playerStats.ContainsKey(playerName))
                    {
                        playerStats[playerName] = new Dictionary<string, int>();
                        playerGames[playerName] = new HashSet<string>();
                    }
                    if (!playerGames[playerName].Contains(gameName) || playerStats[playerName][gameName] < points)
                    {
                        playerGames[playerName].Add(gameName);
                        playerStats[playerName][gameName] = points;
                    }
                }
                else if (input.Contains("vs"))
                {
                    var tokens = input.Split(" vs ", StringSplitOptions.RemoveEmptyEntries);
                    string firstPlayer = tokens[0];
                    string secondPlayer = tokens[1];
                    if (playerStats.ContainsKey(firstPlayer) && playerStats.ContainsKey(secondPlayer))
                    {
                        var firstPlayerGames = playerStats[firstPlayer].Keys.ToList();
                        var secondPlayerGames = playerStats[secondPlayer].Keys.ToList();
                        foreach (var game in firstPlayerGames)
                        {
                            if (secondPlayerGames.Contains(game))
                            {
                                if (playerStats[firstPlayer][game] > playerStats[secondPlayer][game])
                                {
                                    playerStats.Remove(secondPlayer);
                                    playerGames.Remove(secondPlayer);
                                }
                                else if (playerStats[firstPlayer][game] < playerStats[secondPlayer][game])
                                {
                                    playerStats.Remove(firstPlayer);
                                    playerGames.Remove(firstPlayer);
                                }
                                break;
                            }
                        }
                    }
                }
            }
            var sortedPlayers = playerStats
                .OrderByDescending(p => p.Value.Values.Sum())
                .ThenBy(p => p.Key);
            foreach (var player in sortedPlayers)
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");
                var sortedGames = player.Value
                    .OrderByDescending(g => g.Value)
                    .ThenBy(g => g.Key);
                foreach (var game in sortedGames)
                {
                    Console.WriteLine($"- {game.Key} <::> {game.Value}");
                }
            }
        }
    }
}
