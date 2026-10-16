using System;
using System.Drawing;
using System.Windows.Forms;

namespace BasketballSimulator
{
    public partial class Form1 : Form
    {
        // Αντικείμενα Ομάδων
        private Team homeTeam;
        private Team awayTeam;

        // Μεταβλητές Χρόνου (10 λεπτά = 600 δευτερόλεπτα)
        private int timeLeftSeconds = 600;

        // Γεννήτρια τυχαίων αριθμών για τα σουτ
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        // Αρχικοποίηση Ομάδων και Παικτών
        private void InitializeGame()
        {
            homeTeam = new Team("Olympiacos");
            homeTeam.AddPlayer(new Player("Vezenkov", 14));
            homeTeam.AddPlayer(new Player("Fournier", 94));
            homeTeam.AddPlayer(new Player("Milutinov", 33));

            awayTeam = new Team("Panathinaikos");
            awayTeam.AddPlayer(new Player("Nunn", 25));
            awayTeam.AddPlayer(new Player("Sloukas", 10));
            awayTeam.AddPlayer(new Player("Lessort", 26));

            timeLeftSeconds = 600; // Reset χρόνου (10 λεπτά)
            btnShoot2.Enabled = true;
            btnShoot3.Enabled = true;

            UpdateScoreboard();

            rtbLog.Clear();
            rtbLog.AppendText("=== GAME STARTED ===" + Environment.NewLine);
            rtbLog.AppendText($"Matchup: {homeTeam.Name} vs {awayTeam.Name}" + Environment.NewLine);
            rtbLog.AppendText("Press a button to shoot!" + Environment.NewLine + Environment.NewLine);
        }

        // Ενημέρωση του Scoreboard και του Χρονόμετρου
        private void UpdateScoreboard()
        {
            lblHomeScore.Text = $"{homeTeam.Name}: {homeTeam.Score}";
            lblAwayScore.Text = $"{awayTeam.Name}: {awayTeam.Score}";

            // Format χρόνου σε MM:SS
            int minutes = timeLeftSeconds / 60;
            int seconds = timeLeftSeconds % 60;
            lblTimer.Text = $"{minutes:D2}:{seconds:D2}";
        }

        // Γενική μέθοδος για εκτέλεση σουτ
        private void Shoot(int points, int successChancePercent)
        {
            if (timeLeftSeconds <= 0) return;

            // Κάθε επίθεση διαρκεί τυχαία από 12 έως 24 δευτερόλεπτα
            int possessionTime = random.Next(12, 25);
            timeLeftSeconds -= possessionTime;

            if (timeLeftSeconds <= 0)
            {
                timeLeftSeconds = 0;
                UpdateScoreboard();
                EndGame();
                return;
            }

            // Επιλογή τυχαίας ομάδας (50% πιθανότητα)
            Team attackingTeam = (random.Next(0, 2) == 0) ? homeTeam : awayTeam;
            int randomPlayerIndex = random.Next(0, attackingTeam.Roster.Count);
            Player shooter = attackingTeam.Roster[randomPlayerIndex];

            int roll = random.Next(1, 101);
            bool isSuccess = roll <= successChancePercent;

            if (isSuccess)
            {
                attackingTeam.AddScore(points);
                shooter.AddPoints(points);

                rtbLog.SelectionColor = Color.LawnGreen;
                rtbLog.AppendText($"[{lblTimer.Text}] BASKET! {shooter.Name} ({attackingTeam.Name}) scored {points} pts!" + Environment.NewLine);
            }
            else
            {
                rtbLog.SelectionColor = Color.Tomato;
                rtbLog.AppendText($"[{lblTimer.Text}] MISSED! {shooter.Name} ({attackingTeam.Name}) missed {points}-pt shot." + Environment.NewLine);
            }

            UpdateScoreboard();

            rtbLog.SelectionStart = rtbLog.Text.Length;
            rtbLog.ScrollToCaret();
        }

        // Λήξη Αγώνα
        private void EndGame()
        {
            btnShoot2.Enabled = false;
            btnShoot3.Enabled = false;

            rtbLog.SelectionColor = Color.Yellow;
            rtbLog.AppendText(Environment.NewLine + "=== GAME OVER ===" + Environment.NewLine);

            string winnerMessage = "";
            if (homeTeam.Score > awayTeam.Score)
                winnerMessage = $"{homeTeam.Name} WINS!";
            else if (awayTeam.Score > homeTeam.Score)
                winnerMessage = $"{awayTeam.Name} WINS!";
            else
                winnerMessage = "IT'S A DRAW!";

            MessageBox.Show($"FINAL SCORE\n{homeTeam.Name}: {homeTeam.Score}\n{awayTeam.Name}: {awayTeam.Score}\n\n{winnerMessage}", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnShoot2_Click(object sender, EventArgs e) => Shoot(2, 60);
        private void btnShoot3_Click(object sender, EventArgs e) => Shoot(3, 35);

        private void btnReset_Click(object sender, EventArgs e)
        {
            homeTeam.ResetScore();
            awayTeam.ResetScore();
            InitializeGame();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            string statsMessage = $"=== STATS: {homeTeam.Name} ===\n\n";
            foreach (var player in homeTeam.Roster)
                statsMessage += $"#{player.Number} {player.Name}: {player.TotalPoints} pts\n";

            statsMessage += $"\n=== STATS: {awayTeam.Name} ===\n\n";
            foreach (var player in awayTeam.Roster)
                statsMessage += $"#{player.Number} {player.Name}: {player.TotalPoints} pts\n";

            MessageBox.Show(statsMessage, "Match Box Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}