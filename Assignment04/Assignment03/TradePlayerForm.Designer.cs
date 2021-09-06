
namespace Assignment03
{
    partial class TradePlayerForm
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
            this.PlayerNameLabel = new System.Windows.Forms.Label();
            this.TeamNameLabel = new System.Windows.Forms.Label();
            this.CurrentTeamLabel = new System.Windows.Forms.Label();
            this.NewSquadLabel = new System.Windows.Forms.Label();
            this.newTeamListBox = new System.Windows.Forms.ListBox();
            this.acceptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayerNameLabel
            // 
            this.PlayerNameLabel.AutoSize = true;
            this.PlayerNameLabel.Font = new System.Drawing.Font("Snap ITC", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PlayerNameLabel.ForeColor = System.Drawing.Color.Maroon;
            this.PlayerNameLabel.Location = new System.Drawing.Point(33, 30);
            this.PlayerNameLabel.Name = "PlayerNameLabel";
            this.PlayerNameLabel.Size = new System.Drawing.Size(153, 51);
            this.PlayerNameLabel.TabIndex = 0;
            this.PlayerNameLabel.Text = "label1";
            // 
            // TeamNameLabel
            // 
            this.TeamNameLabel.AutoSize = true;
            this.TeamNameLabel.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TeamNameLabel.ForeColor = System.Drawing.Color.Black;
            this.TeamNameLabel.Location = new System.Drawing.Point(33, 119);
            this.TeamNameLabel.Name = "TeamNameLabel";
            this.TeamNameLabel.Size = new System.Drawing.Size(123, 44);
            this.TeamNameLabel.TabIndex = 1;
            this.TeamNameLabel.Text = "label2";
            // 
            // CurrentTeamLabel
            // 
            this.CurrentTeamLabel.AutoSize = true;
            this.CurrentTeamLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CurrentTeamLabel.ForeColor = System.Drawing.Color.Black;
            this.CurrentTeamLabel.Location = new System.Drawing.Point(33, 175);
            this.CurrentTeamLabel.Name = "CurrentTeamLabel";
            this.CurrentTeamLabel.Size = new System.Drawing.Size(167, 29);
            this.CurrentTeamLabel.TabIndex = 2;
            this.CurrentTeamLabel.Text = "Current Team";
            // 
            // NewSquadLabel
            // 
            this.NewSquadLabel.AutoSize = true;
            this.NewSquadLabel.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NewSquadLabel.ForeColor = System.Drawing.Color.Black;
            this.NewSquadLabel.Location = new System.Drawing.Point(507, 80);
            this.NewSquadLabel.Name = "NewSquadLabel";
            this.NewSquadLabel.Size = new System.Drawing.Size(148, 36);
            this.NewSquadLabel.TabIndex = 3;
            this.NewSquadLabel.Text = "New Team";
            // 
            // newTeamListBox
            // 
            this.newTeamListBox.BackColor = System.Drawing.Color.Purple;
            this.newTeamListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.newTeamListBox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.newTeamListBox.FormattingEnabled = true;
            this.newTeamListBox.ItemHeight = 25;
            this.newTeamListBox.Location = new System.Drawing.Point(459, 119);
            this.newTeamListBox.Name = "newTeamListBox";
            this.newTeamListBox.Size = new System.Drawing.Size(258, 229);
            this.newTeamListBox.TabIndex = 4;
            // 
            // acceptButton
            // 
            this.acceptButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.acceptButton.Location = new System.Drawing.Point(452, 387);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(112, 34);
            this.acceptButton.TabIndex = 5;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cancelButton.Location = new System.Drawing.Point(599, 387);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(112, 34);
            this.cancelButton.TabIndex = 6;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // TradePlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.newTeamListBox);
            this.Controls.Add(this.NewSquadLabel);
            this.Controls.Add(this.CurrentTeamLabel);
            this.Controls.Add(this.TeamNameLabel);
            this.Controls.Add(this.PlayerNameLabel);
            this.Name = "TradePlayerForm";
            this.Text = "TradePlayerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PlayerNameLabel;
        private System.Windows.Forms.Label TeamNameLabel;
        private System.Windows.Forms.Label CurrentTeamLabel;
        private System.Windows.Forms.Label NewSquadLabel;
        private System.Windows.Forms.ListBox newTeamListBox;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;
    }
}