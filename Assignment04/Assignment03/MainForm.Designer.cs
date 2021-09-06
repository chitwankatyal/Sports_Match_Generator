
namespace Assignment03
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.teamsListBox = new System.Windows.Forms.ListBox();
            this.playersListBox = new System.Windows.Forms.ListBox();
            this.tradePlayerButton = new System.Windows.Forms.Button();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.btnGenerateSeason = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // teamsListBox
            // 
            this.teamsListBox.BackColor = System.Drawing.Color.MistyRose;
            this.teamsListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.teamsListBox.FormattingEnabled = true;
            this.teamsListBox.ItemHeight = 28;
            this.teamsListBox.Location = new System.Drawing.Point(54, 32);
            this.teamsListBox.Name = "teamsListBox";
            this.teamsListBox.Size = new System.Drawing.Size(214, 340);
            this.teamsListBox.TabIndex = 0;
            this.teamsListBox.SelectedIndexChanged += new System.EventHandler(this.TeamsListBox_SelectedIndexChanged);
            // 
            // playersListBox
            // 
            this.playersListBox.BackColor = System.Drawing.Color.MistyRose;
            this.playersListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playersListBox.FormattingEnabled = true;
            this.playersListBox.ItemHeight = 25;
            this.playersListBox.Location = new System.Drawing.Point(513, 32);
            this.playersListBox.Name = "playersListBox";
            this.playersListBox.Size = new System.Drawing.Size(215, 354);
            this.playersListBox.TabIndex = 1;
            // 
            // tradePlayerButton
            // 
            this.tradePlayerButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tradePlayerButton.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tradePlayerButton.Location = new System.Drawing.Point(316, 316);
            this.tradePlayerButton.Name = "tradePlayerButton";
            this.tradePlayerButton.Size = new System.Drawing.Size(169, 43);
            this.tradePlayerButton.TabIndex = 2;
            this.tradePlayerButton.Text = "Trade Player";
            this.tradePlayerButton.UseVisualStyleBackColor = false;
            this.tradePlayerButton.Click += new System.EventHandler(this.TradePlayerButton_Click);
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.Location = new System.Drawing.Point(316, 86);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(169, 52);
            this.btnAddTeam.TabIndex = 3;
            this.btnAddTeam.Text = "Add Team";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            this.btnAddTeam.Click += new System.EventHandler(this.btnAddTeam_Click);
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(316, 192);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(169, 48);
            this.btnAddPlayer.TabIndex = 4;
            this.btnAddPlayer.Text = "Add Player";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            this.btnAddPlayer.Click += new System.EventHandler(this.btnAddPlayer_Click);
            // 
            // btnGenerateSeason
            // 
            this.btnGenerateSeason.Location = new System.Drawing.Point(172, 392);
            this.btnGenerateSeason.Name = "btnGenerateSeason";
            this.btnGenerateSeason.Size = new System.Drawing.Size(188, 46);
            this.btnGenerateSeason.TabIndex = 5;
            this.btnGenerateSeason.Text = "Generate Season";
            this.btnGenerateSeason.UseVisualStyleBackColor = true;
            this.btnGenerateSeason.Click += new System.EventHandler(this.btnGenerateSeason_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGenerateSeason);
            this.Controls.Add(this.btnAddPlayer);
            this.Controls.Add(this.btnAddTeam);
            this.Controls.Add(this.tradePlayerButton);
            this.Controls.Add(this.playersListBox);
            this.Controls.Add(this.teamsListBox);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox teamsListBox;
        private System.Windows.Forms.ListBox playersListBox;
        private System.Windows.Forms.Button tradePlayerButton;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.Button btnGenerateSeason;
    }
}

