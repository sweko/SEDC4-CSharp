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
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblCast = new System.Windows.Forms.Label();
            this.lblCastLabel = new System.Windows.Forms.Label();
            this.lblGenres = new System.Windows.Forms.Label();
            this.lblGenresLabel = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.lblDurationLabel = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblDirectorLabel = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblYearLabel = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTitleLabel = new System.Windows.Forms.Label();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.initToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpMovie.SuspendLayout();
            this.mainMenu.SuspendLayout();
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
            this.grpMovie.Controls.Add(this.btnDelete);
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
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(300, 342);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(165, 57);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete Movie";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(865, 24);
            this.mainMenu.TabIndex = 2;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.addPersonToolStripMenuItem,
            this.initToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem.Text = "Add Movie";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // addPersonToolStripMenuItem
            // 
            this.addPersonToolStripMenuItem.Name = "addPersonToolStripMenuItem";
            this.addPersonToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addPersonToolStripMenuItem.Text = "Add Person";
            this.addPersonToolStripMenuItem.Click += new System.EventHandler(this.addPersonToolStripMenuItem_Click);
            // 
            // initToolStripMenuItem
            // 
            this.initToolStripMenuItem.Name = "initToolStripMenuItem";
            this.initToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.initToolStripMenuItem.Text = "Init";
            this.initToolStripMenuItem.Click += new System.EventHandler(this.initToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 449);
            this.Controls.Add(this.grpMovie);
            this.Controls.Add(this.lstMovies);
            this.Controls.Add(this.mainMenu);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Name = "MainForm";
            this.Text = "Movie Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpMovie.ResumeLayout(false);
            this.grpMovie.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem initToolStripMenuItem;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolStripMenuItem addPersonToolStripMenuItem;
    }
}

