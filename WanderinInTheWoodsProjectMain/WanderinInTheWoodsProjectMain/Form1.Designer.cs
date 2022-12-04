namespace WanderinInTheWoodsProjectMain
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.character1 = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.gameGrid = new System.Windows.Forms.GroupBox();
            this.character3 = new System.Windows.Forms.PictureBox();
            this.character2 = new System.Windows.Forms.PictureBox();
            this.character4 = new System.Windows.Forms.PictureBox();
            this.lblFound = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.character1)).BeginInit();
            this.gameGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.character3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.character2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.character4)).BeginInit();
            this.SuspendLayout();
            // 
            // character1
            // 
            this.character1.Image = ((System.Drawing.Image)(resources.GetObject("character1.Image")));
            this.character1.Location = new System.Drawing.Point(28, 36);
            this.character1.Name = "character1";
            this.character1.Size = new System.Drawing.Size(52, 50);
            this.character1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.character1.TabIndex = 0;
            this.character1.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // gameGrid
            // 
            this.gameGrid.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.gameGrid.Controls.Add(this.character4);
            this.gameGrid.Controls.Add(this.character2);
            this.gameGrid.Controls.Add(this.character3);
            this.gameGrid.Controls.Add(this.character1);
            this.gameGrid.Location = new System.Drawing.Point(46, 207);
            this.gameGrid.Name = "gameGrid";
            this.gameGrid.Size = new System.Drawing.Size(663, 501);
            this.gameGrid.TabIndex = 1;
            this.gameGrid.TabStop = false;
            this.gameGrid.Text = "The Woods";
            // 
            // character3
            // 
            this.character3.Image = ((System.Drawing.Image)(resources.GetObject("character3.Image")));
            this.character3.Location = new System.Drawing.Point(28, 429);
            this.character3.Name = "character3";
            this.character3.Size = new System.Drawing.Size(52, 50);
            this.character3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.character3.TabIndex = 1;
            this.character3.TabStop = false;
            // 
            // character2
            // 
            this.character2.Image = ((System.Drawing.Image)(resources.GetObject("character2.Image")));
            this.character2.Location = new System.Drawing.Point(593, 36);
            this.character2.Name = "character2";
            this.character2.Size = new System.Drawing.Size(52, 50);
            this.character2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.character2.TabIndex = 2;
            this.character2.TabStop = false;
            // 
            // character4
            // 
            this.character4.Image = ((System.Drawing.Image)(resources.GetObject("character4.Image")));
            this.character4.Location = new System.Drawing.Point(593, 429);
            this.character4.Name = "character4";
            this.character4.Size = new System.Drawing.Size(52, 50);
            this.character4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.character4.TabIndex = 3;
            this.character4.TabStop = false;
            // 
            // lblFound
            // 
            this.lblFound.AutoSize = true;
            this.lblFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFound.Location = new System.Drawing.Point(184, 82);
            this.lblFound.Name = "lblFound";
            this.lblFound.Size = new System.Drawing.Size(352, 29);
            this.lblFound.TabIndex = 2;
            this.lblFound.Text = "Peeps have found eachother!";
            this.lblFound.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 742);
            this.Controls.Add(this.lblFound);
            this.Controls.Add(this.gameGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Wandering In The Woods Simulation";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.character1)).EndInit();
            this.gameGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.character3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.character2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.character4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox character1;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.GroupBox gameGrid;
        private System.Windows.Forms.PictureBox character4;
        private System.Windows.Forms.PictureBox character2;
        private System.Windows.Forms.PictureBox character3;
        private System.Windows.Forms.Label lblFound;
    }
}

