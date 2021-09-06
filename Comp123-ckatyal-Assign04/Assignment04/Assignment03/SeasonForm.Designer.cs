
namespace Assignment03
{
    partial class SeasonForm
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
            this.DisplayeSeasonGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayeSeasonGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DisplayeSeasonGrid
            // 
            this.DisplayeSeasonGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DisplayeSeasonGrid.Location = new System.Drawing.Point(12, 12);
            this.DisplayeSeasonGrid.Name = "DisplayeSeasonGrid";
            this.DisplayeSeasonGrid.RowHeadersWidth = 62;
            this.DisplayeSeasonGrid.RowTemplate.Height = 33;
            this.DisplayeSeasonGrid.Size = new System.Drawing.Size(776, 413);
            this.DisplayeSeasonGrid.TabIndex = 0;
            // 
            // SeasonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DisplayeSeasonGrid);
            this.Name = "SeasonForm";
            this.Text = "SeasonForm";
            ((System.ComponentModel.ISupportInitialize)(this.DisplayeSeasonGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DisplayeSeasonGrid;
    }
}