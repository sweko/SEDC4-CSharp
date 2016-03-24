namespace LotrBattle
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
            this.lstGoodGuys = new System.Windows.Forms.ListBox();
            this.lstBadGuys = new System.Windows.Forms.ListBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnBattle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstGoodGuys
            // 
            this.lstGoodGuys.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstGoodGuys.FormattingEnabled = true;
            this.lstGoodGuys.ItemHeight = 24;
            this.lstGoodGuys.Location = new System.Drawing.Point(24, 24);
            this.lstGoodGuys.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lstGoodGuys.Name = "lstGoodGuys";
            this.lstGoodGuys.Size = new System.Drawing.Size(265, 388);
            this.lstGoodGuys.TabIndex = 0;
            // 
            // lstBadGuys
            // 
            this.lstBadGuys.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstBadGuys.FormattingEnabled = true;
            this.lstBadGuys.ItemHeight = 24;
            this.lstBadGuys.Location = new System.Drawing.Point(458, 24);
            this.lstBadGuys.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lstBadGuys.Name = "lstBadGuys";
            this.lstBadGuys.Size = new System.Drawing.Size(377, 388);
            this.lstBadGuys.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Location = new System.Drawing.Point(301, 24);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(145, 105);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate Armies";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnBattle
            // 
            this.btnBattle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBattle.Location = new System.Drawing.Point(301, 141);
            this.btnBattle.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnBattle.Name = "btnBattle";
            this.btnBattle.Size = new System.Drawing.Size(145, 105);
            this.btnBattle.TabIndex = 3;
            this.btnBattle.Text = "BATTLE!!";
            this.btnBattle.UseVisualStyleBackColor = true;
            this.btnBattle.Click += new System.EventHandler(this.btnBattle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 421);
            this.Controls.Add(this.btnBattle);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lstBadGuys);
            this.Controls.Add(this.lstGoodGuys);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstGoodGuys;
        private System.Windows.Forms.ListBox lstBadGuys;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnBattle;
    }
}

