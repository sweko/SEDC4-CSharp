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
            this.lblYear = new System.Windows.Forms.Label();
            this.lblYearLabel = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitleLabel = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblDirectorLabel = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblDurationLabel = new System.Windows.Forms.Label();
            this.lblGenres = new System.Windows.Forms.Label();
            this.lblGenresLabel = new System.Windows.Forms.Label();
            this.lblCastLabel = new System.Windows.Forms.Label();
            this.lblCast = new System.Windows.Forms.Label();
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
            this.grpMovie.Controls.Add(this.lblCast);
            this.grpMovie.Controls.Add(this.lblCastLabel);
            this.grpMovie.Controls.Add(this.lblGenres);
            this.grpMovie.Controls.Add(this.lblGenresLabel);
            this.grpMovie.Controls.Add(this.lblDuration);
            this.grpMovie.Controls.Add(this.lblDurationLabel);
            this.grpMovie.Controls.Add(this.lblDirector);
            this.grpMovie.Controls.Add(this.lblDirectorLabel);
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
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(119, 104);
            this.lblDirector.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(140, 23);
            this.lblDirector.TabIndex = 5;
            this.lblDirector.Text = "dummy text";
            // 
            // lblDirectorLabel
            // 
            this.lblDirectorLabel.AutoSize = true;
            this.lblDirectorLabel.Location = new System.Drawing.Point(15, 104);
            this.lblDirectorLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblDirectorLabel.Name = "lblDirectorLabel";
            this.lblDirectorLabel.Size = new System.Drawing.Size(112, 23);
            this.lblDirectorLabel.TabIndex = 4;
            this.lblDirectorLabel.Text = "Director: ";
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(119, 81);
            this.lblDuration.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(140, 23);
            this.lblDuration.TabIndex = 7;
            this.lblDuration.Text = "dummy text";
            // 
            // lblDurationLabel
            // 
            this.lblDurationLabel.AutoSize = true;
            this.lblDurationLabel.Location = new System.Drawing.Point(15, 81);
            this.lblDurationLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblDurationLabel.Name = "lblDurationLabel";
            this.lblDurationLabel.Size = new System.Drawing.Size(120, 23);
            this.lblDurationLabel.TabIndex = 6;
            this.lblDurationLabel.Text = "Duration: ";
            // 
            // lblGenres
            // 
            this.lblGenres.AutoSize = true;
            this.lblGenres.Location = new System.Drawing.Point(119, 127);
            this.lblGenres.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblGenres.Name = "lblGenres";
            this.lblGenres.Size = new System.Drawing.Size(140, 23);
            this.lblGenres.TabIndex = 9;
            this.lblGenres.Text = "dummy text";
            // 
            // lblGenresLabel
            // 
            this.lblGenresLabel.AutoSize = true;
            this.lblGenresLabel.Location = new System.Drawing.Point(15, 127);
            this.lblGenresLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblGenresLabel.Name = "lblGenresLabel";
            this.lblGenresLabel.Size = new System.Drawing.Size(100, 23);
            this.lblGenresLabel.TabIndex = 8;
            this.lblGenresLabel.Text = "Genres: ";
            // 
            // lblCastLabel
            // 
            this.lblCastLabel.AutoSize = true;
            this.lblCastLabel.Location = new System.Drawing.Point(15, 150);
            this.lblCastLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblCastLabel.Name = "lblCastLabel";
            this.lblCastLabel.Size = new System.Drawing.Size(72, 23);
            this.lblCastLabel.TabIndex = 10;
            this.lblCastLabel.Text = "Cast: ";
            // 
            // lblCast
            // 
            this.lblCast.AutoSize = true;
            this.lblCast.Location = new System.Drawing.Point(119, 173);
            this.lblCast.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblCast.Name = "lblCast";
            this.lblCast.Size = new System.Drawing.Size(140, 23);
            this.lblCast.TabIndex = 11;
            this.lblCast.Text = "dummy text";
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
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblDurationLabel;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblDirectorLabel;
        private System.Windows.Forms.Label lblGenres;
        private System.Windows.Forms.Label lblGenresLabel;
        private System.Windows.Forms.Label lblCast;
        private System.Windows.Forms.Label lblCastLabel;
    }
}

