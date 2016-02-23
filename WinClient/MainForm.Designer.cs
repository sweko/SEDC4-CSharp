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
            this.SuspendLayout();
            // 
            // lstMovies
            // 
            this.lstMovies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstMovies.FormattingEnabled = true;
            this.lstMovies.Location = new System.Drawing.Point(12, 12);
            this.lstMovies.Name = "lstMovies";
            this.lstMovies.Size = new System.Drawing.Size(231, 355);
            this.lstMovies.TabIndex = 0;
            // 
            // grpMovie
            // 
            this.grpMovie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMovie.Location = new System.Drawing.Point(249, 12);
            this.grpMovie.Name = "grpMovie";
            this.grpMovie.Size = new System.Drawing.Size(455, 355);
            this.grpMovie.TabIndex = 1;
            this.grpMovie.TabStop = false;
            this.grpMovie.Text = "Movie Details";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 372);
            this.Controls.Add(this.grpMovie);
            this.Controls.Add(this.lstMovies);
            this.Name = "MainForm";
            this.Text = "Movie Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstMovies;
        private System.Windows.Forms.GroupBox grpMovie;
    }
}

