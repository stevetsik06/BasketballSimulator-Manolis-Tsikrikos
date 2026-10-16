using System;

namespace BasketballSimulator
{
    public class Player
    {
        // Ιδιότητες (Properties)
        public string Name { get; set; }
        public int Number { get; set; }
        public int TotalPoints { get; set; }

        // Κατασκευαστής (Constructor)
        public Player(string name, int number)
        {
            Name = name;
            Number = number;
            TotalPoints = 0;
        }

        // Μέθοδος για προσθήκη πόντων
        public void AddPoints(int points)
        {
            TotalPoints += points;
        }
    }
}