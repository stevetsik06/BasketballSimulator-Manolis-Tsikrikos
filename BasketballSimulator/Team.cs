using System;
using System.Collections.Generic;

namespace BasketballSimulator
{
    public class Team
    {
        // Ιδιότητες
        public string Name { get; set; }
        public int Score { get; set; }
        public List<Player> Roster { get; set; }

        // Κατασκευαστής
        public Team(string name)
        {
            Name = name;
            Score = 0;
            Roster = new List<Player>();
        }

        // Μέθοδος προσθήκης παίκτη στο ρόστερ
        public void AddPlayer(Player player)
        {
            Roster.Add(player);
        }

        // Μέθοδος σκοραρίσματος
        public void AddScore(int points)
        {
            Score += points;
        }

        // Μέθοδος επαναφοράς (Reset)
        public void ResetScore()
        {
            Score = 0;
            foreach (var player in Roster)
            {
                player.TotalPoints = 0;
            }
        }
    }
}