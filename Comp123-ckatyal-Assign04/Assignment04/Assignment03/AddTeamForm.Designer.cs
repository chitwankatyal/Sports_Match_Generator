
namespace Assignment03
{
    partial class AddTeamForm
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
            this.newTeamNameLabel = new System.Windows.Forms.Label();
            this.newTeamNameTxtBox = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newTeamNameLabel
            // 
            this.newTeamNameLabel.AutoSize = true;
            this.newTeamNameLabel.Location = new System.Drawing.Point(108, 128);
            this.newTeamNameLabel.Name = "newTeamNameLabel";
            this.newTeamNameLabel.Size = new System.Drawing.Size(105, 25);
            this.newTeamNameLabel.TabIndex = 0;
            this.newTeamNameLabel.Text = "Team Name";
            // 
            // newTeamNameTxtBox
            // 
            this.newTeamNameTxtBox.Location = new System.Drawing.Point(345, 122);
            this.newTeamNameTxtBox.Name = "newTeamNameTxtBox";
            this.newTeamNameTxtBox.Size = new System.Drawing.Size(379, 31);
            this.newTeamNameTxtBox.TabIndex = 1;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(129, 251);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(155, 51);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(485, 251);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(155, 51);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.newTeamNameTxtBox);
            this.Controls.Add(this.newTeamNameLabel);
            this.Name = "AddTeamForm";
            this.Text = "AddTeamForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newTeamNameLabel;
        private System.Windows.Forms.TextBox newTeamNameTxtBox;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
    }
}