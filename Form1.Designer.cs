namespace Space_Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SpaceShip = new System.Windows.Forms.PictureBox();
            this.Asteroid1 = new System.Windows.Forms.PictureBox();
            this.Asteroid2 = new System.Windows.Forms.PictureBox();
            this.Asteroid3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GameOverLabel = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SpaceShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Asteroid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Asteroid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Asteroid3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SpaceShip
            // 
            this.SpaceShip.Image = global::Space_Game.Properties.Resources.spaceship;
            this.SpaceShip.Location = new System.Drawing.Point(357, 349);
            this.SpaceShip.Name = "SpaceShip";
            this.SpaceShip.Size = new System.Drawing.Size(81, 60);
            this.SpaceShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SpaceShip.TabIndex = 0;
            this.SpaceShip.TabStop = false;
            // 
            // Asteroid1
            // 
            this.Asteroid1.Image = global::Space_Game.Properties.Resources.asterioid1;
            this.Asteroid1.Location = new System.Drawing.Point(346, 39);
            this.Asteroid1.Name = "Asteroid1";
            this.Asteroid1.Size = new System.Drawing.Size(64, 49);
            this.Asteroid1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Asteroid1.TabIndex = 1;
            this.Asteroid1.TabStop = false;
            // 
            // Asteroid2
            // 
            this.Asteroid2.Image = global::Space_Game.Properties.Resources.asterioid1;
            this.Asteroid2.Location = new System.Drawing.Point(639, 81);
            this.Asteroid2.Name = "Asteroid2";
            this.Asteroid2.Size = new System.Drawing.Size(64, 50);
            this.Asteroid2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Asteroid2.TabIndex = 2;
            this.Asteroid2.TabStop = false;
            // 
            // Asteroid3
            // 
            this.Asteroid3.Image = global::Space_Game.Properties.Resources.asterioid1;
            this.Asteroid3.Location = new System.Drawing.Point(54, 82);
            this.Asteroid3.Name = "Asteroid3";
            this.Asteroid3.Size = new System.Drawing.Size(63, 49);
            this.Asteroid3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Asteroid3.TabIndex = 3;
            this.Asteroid3.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.Timer);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Space_Game.Properties.Resources._3139930;
            this.pictureBox1.Location = new System.Drawing.Point(2, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(795, 465);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "Space Game";
            // 
            // GameOverLabel
            // 
            this.GameOverLabel.AutoSize = true;
            this.GameOverLabel.Font = new System.Drawing.Font("SimSun", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GameOverLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.GameOverLabel.Location = new System.Drawing.Point(296, 211);
            this.GameOverLabel.Name = "GameOverLabel";
            this.GameOverLabel.Size = new System.Drawing.Size(0, 35);
            this.GameOverLabel.TabIndex = 6;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("SimSun", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ScoreLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ScoreLabel.Location = new System.Drawing.Point(12, 397);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(0, 35);
            this.ScoreLabel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.GameOverLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Asteroid3);
            this.Controls.Add(this.Asteroid2);
            this.Controls.Add(this.Asteroid1);
            this.Controls.Add(this.SpaceShip);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.SpaceShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Asteroid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Asteroid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Asteroid3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox SpaceShip;
        private PictureBox Asteroid1;
        private PictureBox Asteroid2;
        private PictureBox Asteroid3;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label GameOverLabel;
        private Label ScoreLabel;
    }
}