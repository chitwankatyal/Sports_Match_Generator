
namespace Assignment03
{
    partial class AddPlayerForm
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
            this.newPlayerNameLabel = new System.Windows.Forms.Label();
            this.newPlayerTxtBox = new System.Windows.Forms.TextBox();
            this.labelnewTeam = new System.Windows.Forms.Label();
            this.addedTeamListBox = new System.Windows.Forms.ListBox();
            this.acceptButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newPlayerNameLabel
            // 
            this.newPlayerNameLabel.AutoSize = true;
            this.newPlayerNameLabel.Location = new System.Drawing.Point(72, 50);
            this.newPlayerNameLabel.Name = "newPlayerNameLabel";
            this.newPlayerNameLabel.Size = new System.Drawing.Size(111, 25);
            this.newPlayerNameLabel.TabIndex = 0;
            this.newPlayerNameLabel.Text = "Player Name";
            // 
            // newPlayerTxtBox
            // 
            this.newPlayerTxtBox.Location = new System.Drawing.Point(275, 50);
            this.newPlayerTxtBox.Name = "newPlayerTxtBox";
            this.newPlayerTxtBox.Size = new System.Drawing.Size(397, 31);
            this.newPlayerTxtBox.TabIndex = 1;
            // 
            // labelnewTeam
            // 
            this.labelnewTeam.AutoSize = true;
            this.labelnewTeam.Location = new System.Drawing.Point(72, 164);
            this.labelnewTeam.Name = "labelnewTeam";
            this.labelnewTeam.Size = new System.Drawing.Size(53, 25);
            this.labelnewTeam.TabIndex = 2;
            this.labelnewTeam.Text = "Team";
            // 
            // addedTeamListBox
            // 
            this.addedTeamListBox.FormattingEnabled = true;
            this.addedTeamListBox.ItemHeight = 25;
            this.addedTeamListBox.Location = new System.Drawing.Point(275, 164);
            this.addedTeamListBox.Name = "addedTeamListBox";
            this.addedTeamListBox.Size = new System.Drawing.Size(407, 204);
            this.addedTeamListBox.TabIndex = 3;
            // 
            // acceptButton
            // 
            this.acceptButton.Location = new System.Drawing.Point(107, 389);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(162, 45);
            this.acceptButton.TabIndex = 4;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.acceptButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(367, 389);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(160, 45);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.addedTeamListBox);
            this.Controls.Add(this.labelnewTeam);
            this.Controls.Add(this.newPlayerTxtBox);
            this.Controls.Add(this.newPlayerNameLabel);
            this.Name = "AddPlayerForm";
            this.Text = "AddPlayerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newPlayerNameLabel;
        private System.Windows.Forms.TextBox newPlayerTxtBox;
        private System.Windows.Forms.Label labelnewTeam;
        private System.Windows.Forms.ListBox addedTeamListBox;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Button cancelButton;
    }
}