namespace WinClient
{
    partial class MainForm
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
            this.lstMovies = new System.Windows.Forms.ListBox();
            this.grpMovie = new System.Windows.Forms.GroupBox();
            this.lblTitleLabel = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblYearLabel = new System.Windows.Forms.Label();
            this.grpMovie.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstMovies
            // 
            this.lstMovies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstMovies.FormattingEnabled = true;
            this.lstMovies.ItemHeight = 23;
            this.lstMovies.Location = new System.Drawing.Point(26, 20);
            this.lstMovies.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.lstMovies.Name = "lstMovies";
            this.lstMovies.Size = new System.Drawing.Size(343, 418);
            this.lstMovies.TabIndex = 0;
            this.lstMovies.SelectedIndexChanged += new System.EventHandler(this.lstMovies_SelectedIndexChanged);
            // 
            // grpMovie
            // 
            this.grpMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMovie.Controls.Add(this.lblYear);
            this.grpMovie.Controls.Add(this.lblYearLabel);
            this.grpMovie.Controls.Add(this.lblTitle);
            this.grpMovie.Controls.Add(this.lblTitleLabel);
            this.grpMovie.Location = new System.Drawing.Point(374, 21);
            this.grpMovie.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.grpMovie.Name = "grpMovie";
            this.grpMovie.Padding = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.grpMovie.Size = new System.Drawing.Size(475, 417);
            this.grpMovie.TabIndex = 1;
            this.grpMovie.TabStop = false;
            this.grpMovie.Text = "Movie Details";
            // 
            // lblTitleLabel
            // 
            this.lblTitleLabel.AutoSize = true;
            this.lblTitleLabel.Location = new System.Drawing.Point(15, 35);
            this.lblTitleLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTitleLabel.Name = "lblTitleLabel";
            this.lblTitleLabel.Size = new System.Drawing.Size(74, 23);
            this.lblTitleLabel.TabIndex = 0;
            this.lblTitleLabel.Text = "Title: ";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(119, 35);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(140, 23);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "dummy text";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(119, 58);
            this.lblYear.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(140, 23);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "dummy text";
            // 
            // lblYearLabel
            // 
            this.lblYearLabel.AutoSize = true;
            this.lblYearLabel.Location = new System.Drawing.Point(15, 58);
            this.lblYearLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblYearLabel.Name = "lblYearLabel";
            this.lblYearLabel.Size = new System.Drawing.Size(74, 23);
            this.lblYearLabel.TabIndex = 2;
            this.lblYearLabel.Text = "Year: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 449);
            this.Controls.Add(this.grpMovie);
            this.Controls.Add(this.lstMovies);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "MainForm";
            this.Text = "Movie Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpMovie.ResumeLayout(false);
            this.grpMovie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstMovies;
        private System.Windows.Forms.GroupBox grpMovie;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTitleLabel;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblYearLabel;
    }
}

