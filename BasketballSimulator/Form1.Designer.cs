using System;

namespace BasketballSimulator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpScoreboard = new System.Windows.Forms.GroupBox();
            this.lblAwayScore = new System.Windows.Forms.Label();
            this.lblHomeScore = new System.Windows.Forms.Label();
            this.btnShoot2 = new System.Windows.Forms.Button();
            this.btnShoot3 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.btnStats = new System.Windows.Forms.Button();
            this.lblTimer = new System.Windows.Forms.Label();
            this.grpScoreboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpScoreboard
            // 
            this.grpScoreboard.Controls.Add(this.lblTimer);
            this.grpScoreboard.Controls.Add(this.lblAwayScore);
            this.grpScoreboard.Controls.Add(this.lblHomeScore);
            this.grpScoreboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.grpScoreboard.ForeColor = System.Drawing.Color.White;
            this.grpScoreboard.Location = new System.Drawing.Point(150, 20);
            this.grpScoreboard.Name = "grpScoreboard";
            this.grpScoreboard.Size = new System.Drawing.Size(580, 100);
            this.grpScoreboard.TabIndex = 0;
            this.grpScoreboard.TabStop = false;
            this.grpScoreboard.Text = "SCOREBOARD";
            // 
            // lblAwayScore
            // 
            this.lblAwayScore.AutoSize = true;
            this.lblAwayScore.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblAwayScore.ForeColor = System.Drawing.Color.Yellow;
            this.lblAwayScore.Location = new System.Drawing.Point(290, 35);
            this.lblAwayScore.Name = "lblAwayScore";
            this.lblAwayScore.Size = new System.Drawing.Size(103, 28);
            this.lblAwayScore.TabIndex = 1;
            this.lblAwayScore.Text = "AWAY: 0";
            // 
            // lblHomeScore
            // 
            this.lblHomeScore.AutoSize = true;
            this.lblHomeScore.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblHomeScore.ForeColor = System.Drawing.Color.Yellow;
            this.lblHomeScore.Location = new System.Drawing.Point(20, 35);
            this.lblHomeScore.Name = "lblHomeScore";
            this.lblHomeScore.Size = new System.Drawing.Size(103, 28);
            this.lblHomeScore.TabIndex = 0;
            this.lblHomeScore.Text = "HOME: 0";
            // 
            // btnShoot2
            // 
            this.btnShoot2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.btnShoot2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShoot2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnShoot2.ForeColor = System.Drawing.Color.White;
            this.btnShoot2.Location = new System.Drawing.Point(150, 450);
            this.btnShoot2.Name = "btnShoot2";
            this.btnShoot2.Size = new System.Drawing.Size(160, 50);
            this.btnShoot2.TabIndex = 1;
            this.btnShoot2.Text = "2PT SHOOT";
            this.btnShoot2.UseVisualStyleBackColor = false;
            this.btnShoot2.Click += new System.EventHandler(this.btnShoot2_Click);
            // 
            // btnShoot3
            // 
            this.btnShoot3.BackColor = System.Drawing.Color.Crimson;
            this.btnShoot3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShoot3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnShoot3.ForeColor = System.Drawing.Color.White;
            this.btnShoot3.Location = new System.Drawing.Point(360, 450);
            this.btnShoot3.Name = "btnShoot3";
            this.btnShoot3.Size = new System.Drawing.Size(160, 50);
            this.btnShoot3.TabIndex = 2;
            this.btnShoot3.Text = "3PT SHOOT";
            this.btnShoot3.UseVisualStyleBackColor = false;
            this.btnShoot3.Click += new System.EventHandler(this.btnShoot3_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.SteelBlue;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(570, 450);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(160, 50);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "NEW GAME";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // rtbLog
            // 
            this.rtbLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.rtbLog.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.rtbLog.ForeColor = System.Drawing.Color.SpringGreen;
            this.rtbLog.Location = new System.Drawing.Point(150, 140);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(580, 280);
            this.rtbLog.TabIndex = 4;
            this.rtbLog.Text = "";
            // 
            // btnStats
            // 
            this.btnStats.BackColor = System.Drawing.Color.MediumPurple;
            this.btnStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStats.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnStats.ForeColor = System.Drawing.Color.White;
            this.btnStats.Location = new System.Drawing.Point(360, 505);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(160, 40);
            this.btnStats.TabIndex = 5;
            this.btnStats.Text = "BOX SCORE / STATS";
            this.btnStats.UseVisualStyleBackColor = false;
            this.btnStats.Click += new System.EventHandler(this.btnStats_Click);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.lblTimer.ForeColor = System.Drawing.Color.Cyan;
            this.lblTimer.Location = new System.Drawing.Point(504, 73);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(70, 24);
            this.lblTimer.TabIndex = 6;
            this.lblTimer.Text = "10:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnStats);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnShoot3);
            this.Controls.Add(this.btnShoot2);
            this.Controls.Add(this.grpScoreboard);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basketball Match Simulator 2026";
            this.grpScoreboard.ResumeLayout(false);
            this.grpScoreboard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpScoreboard;
        private System.Windows.Forms.Label lblAwayScore;
        private System.Windows.Forms.Label lblHomeScore;
        private System.Windows.Forms.Button btnShoot2;
        private System.Windows.Forms.Button btnShoot3;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Label lblTimer;
    }
}