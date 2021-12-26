
namespace Гонки
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblCoins = new System.Windows.Forms.Label();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.Car = new System.Windows.Forms.PictureBox();
            this.Coin3 = new System.Windows.Forms.PictureBox();
            this.Coin5 = new System.Windows.Forms.PictureBox();
            this.Coin4 = new System.Windows.Forms.PictureBox();
            this.Coin2 = new System.Windows.Forms.PictureBox();
            this.Coin6 = new System.Windows.Forms.PictureBox();
            this.Coin1 = new System.Windows.Forms.PictureBox();
            this.Enemy5 = new System.Windows.Forms.PictureBox();
            this.Enemy2 = new System.Windows.Forms.PictureBox();
            this.Enemy4 = new System.Windows.Forms.PictureBox();
            this.Enemy1 = new System.Windows.Forms.PictureBox();
            this.Enemy3 = new System.Windows.Forms.PictureBox();
            this.pbRoadLine1 = new System.Windows.Forms.PictureBox();
            this.pbRoadLine2 = new System.Windows.Forms.PictureBox();
            this.pbRoadLine3 = new System.Windows.Forms.PictureBox();
            this.pbBountRight = new System.Windows.Forms.PictureBox();
            this.pbBoundLeft = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoadLine1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoadLine2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoadLine3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBountRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoundLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCoins
            // 
            this.lblCoins.AutoSize = true;
            this.lblCoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCoins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblCoins.Location = new System.Drawing.Point(1, 0);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(114, 29);
            this.lblCoins.TabIndex = 5;
            this.lblCoins.Text = "Coins = 0";
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGameOver.ForeColor = System.Drawing.Color.DarkRed;
            this.lblGameOver.Location = new System.Drawing.Point(144, 248);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(272, 55);
            this.lblGameOver.TabIndex = 6;
            this.lblGameOver.Text = "Game Over";
            // 
            // GameTimer
            // 
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // Car
            // 
            this.Car.Image = ((System.Drawing.Image)(resources.GetObject("Car.Image")));
            this.Car.Location = new System.Drawing.Point(319, 429);
            this.Car.Name = "Car";
            this.Car.Size = new System.Drawing.Size(48, 102);
            this.Car.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Car.TabIndex = 7;
            this.Car.TabStop = false;
            // 
            // Coin3
            // 
            this.Coin3.Location = new System.Drawing.Point(180, 269);
            this.Coin3.Name = "Coin3";
            this.Coin3.Size = new System.Drawing.Size(25, 24);
            this.Coin3.TabIndex = 3;
            this.Coin3.TabStop = false;
            // 
            // Coin5
            // 
            this.Coin5.Image = ((System.Drawing.Image)(resources.GetObject("Coin5.Image")));
            this.Coin5.Location = new System.Drawing.Point(443, 43);
            this.Coin5.Name = "Coin5";
            this.Coin5.Size = new System.Drawing.Size(33, 35);
            this.Coin5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Coin5.TabIndex = 3;
            this.Coin5.TabStop = false;
            // 
            // Coin4
            // 
            this.Coin4.Image = ((System.Drawing.Image)(resources.GetObject("Coin4.Image")));
            this.Coin4.Location = new System.Drawing.Point(82, 359);
            this.Coin4.Name = "Coin4";
            this.Coin4.Size = new System.Drawing.Size(33, 35);
            this.Coin4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Coin4.TabIndex = 3;
            this.Coin4.TabStop = false;
            // 
            // Coin2
            // 
            this.Coin2.Image = ((System.Drawing.Image)(resources.GetObject("Coin2.Image")));
            this.Coin2.Location = new System.Drawing.Point(334, 315);
            this.Coin2.Name = "Coin2";
            this.Coin2.Size = new System.Drawing.Size(33, 35);
            this.Coin2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Coin2.TabIndex = 3;
            this.Coin2.TabStop = false;
            // 
            // Coin6
            // 
            this.Coin6.Image = ((System.Drawing.Image)(resources.GetObject("Coin6.Image")));
            this.Coin6.Location = new System.Drawing.Point(180, 36);
            this.Coin6.Name = "Coin6";
            this.Coin6.Size = new System.Drawing.Size(33, 35);
            this.Coin6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Coin6.TabIndex = 3;
            this.Coin6.TabStop = false;
            // 
            // Coin1
            // 
            this.Coin1.Image = ((System.Drawing.Image)(resources.GetObject("Coin1.Image")));
            this.Coin1.Location = new System.Drawing.Point(429, 366);
            this.Coin1.Name = "Coin1";
            this.Coin1.Size = new System.Drawing.Size(33, 35);
            this.Coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Coin1.TabIndex = 3;
            this.Coin1.TabStop = false;
            // 
            // Enemy5
            // 
            this.Enemy5.Image = ((System.Drawing.Image)(resources.GetObject("Enemy5.Image")));
            this.Enemy5.Location = new System.Drawing.Point(143, 315);
            this.Enemy5.Name = "Enemy5";
            this.Enemy5.Size = new System.Drawing.Size(47, 113);
            this.Enemy5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Enemy5.TabIndex = 2;
            this.Enemy5.TabStop = false;
            this.Enemy5.Click += new System.EventHandler(this.Enemy3_Click);
            // 
            // Enemy2
            // 
            this.Enemy2.Image = ((System.Drawing.Image)(resources.GetObject("Enemy2.Image")));
            this.Enemy2.Location = new System.Drawing.Point(180, 132);
            this.Enemy2.Name = "Enemy2";
            this.Enemy2.Size = new System.Drawing.Size(47, 113);
            this.Enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Enemy2.TabIndex = 2;
            this.Enemy2.TabStop = false;
            this.Enemy2.Click += new System.EventHandler(this.Enemy3_Click);
            // 
            // Enemy4
            // 
            this.Enemy4.Image = ((System.Drawing.Image)(resources.GetObject("Enemy4.Image")));
            this.Enemy4.Location = new System.Drawing.Point(68, 72);
            this.Enemy4.Name = "Enemy4";
            this.Enemy4.Size = new System.Drawing.Size(47, 113);
            this.Enemy4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Enemy4.TabIndex = 2;
            this.Enemy4.TabStop = false;
            this.Enemy4.Click += new System.EventHandler(this.Enemy3_Click);
            // 
            // Enemy1
            // 
            this.Enemy1.Image = ((System.Drawing.Image)(resources.GetObject("Enemy1.Image")));
            this.Enemy1.Location = new System.Drawing.Point(439, 180);
            this.Enemy1.Name = "Enemy1";
            this.Enemy1.Size = new System.Drawing.Size(47, 113);
            this.Enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Enemy1.TabIndex = 2;
            this.Enemy1.TabStop = false;
            this.Enemy1.Click += new System.EventHandler(this.Enemy3_Click);
            // 
            // Enemy3
            // 
            this.Enemy3.Image = ((System.Drawing.Image)(resources.GetObject("Enemy3.Image")));
            this.Enemy3.Location = new System.Drawing.Point(369, 19);
            this.Enemy3.Name = "Enemy3";
            this.Enemy3.Size = new System.Drawing.Size(47, 113);
            this.Enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Enemy3.TabIndex = 2;
            this.Enemy3.TabStop = false;
            this.Enemy3.Click += new System.EventHandler(this.Enemy3_Click);
            // 
            // pbRoadLine1
            // 
            this.pbRoadLine1.BackColor = System.Drawing.SystemColors.Control;
            this.pbRoadLine1.Location = new System.Drawing.Point(255, -41);
            this.pbRoadLine1.Name = "pbRoadLine1";
            this.pbRoadLine1.Size = new System.Drawing.Size(20, 173);
            this.pbRoadLine1.TabIndex = 1;
            this.pbRoadLine1.TabStop = false;
            // 
            // pbRoadLine2
            // 
            this.pbRoadLine2.BackColor = System.Drawing.SystemColors.Control;
            this.pbRoadLine2.Location = new System.Drawing.Point(255, 159);
            this.pbRoadLine2.Name = "pbRoadLine2";
            this.pbRoadLine2.Size = new System.Drawing.Size(20, 173);
            this.pbRoadLine2.TabIndex = 1;
            this.pbRoadLine2.TabStop = false;
            // 
            // pbRoadLine3
            // 
            this.pbRoadLine3.BackColor = System.Drawing.SystemColors.Control;
            this.pbRoadLine3.Location = new System.Drawing.Point(255, 359);
            this.pbRoadLine3.Name = "pbRoadLine3";
            this.pbRoadLine3.Size = new System.Drawing.Size(20, 221);
            this.pbRoadLine3.TabIndex = 1;
            this.pbRoadLine3.TabStop = false;
            // 
            // pbBountRight
            // 
            this.pbBountRight.BackColor = System.Drawing.SystemColors.Control;
            this.pbBountRight.Location = new System.Drawing.Point(492, -20);
            this.pbBountRight.Name = "pbBountRight";
            this.pbBountRight.Size = new System.Drawing.Size(17, 600);
            this.pbBountRight.TabIndex = 0;
            this.pbBountRight.TabStop = false;
            // 
            // pbBoundLeft
            // 
            this.pbBoundLeft.BackColor = System.Drawing.SystemColors.Control;
            this.pbBoundLeft.Location = new System.Drawing.Point(22, -20);
            this.pbBoundLeft.Name = "pbBoundLeft";
            this.pbBoundLeft.Size = new System.Drawing.Size(17, 600);
            this.pbBoundLeft.TabIndex = 0;
            this.pbBoundLeft.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(540, 555);
            this.Controls.Add(this.Car);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblCoins);
            this.Controls.Add(this.Coin3);
            this.Controls.Add(this.Coin5);
            this.Controls.Add(this.Coin4);
            this.Controls.Add(this.Coin2);
            this.Controls.Add(this.Coin6);
            this.Controls.Add(this.Coin1);
            this.Controls.Add(this.Enemy5);
            this.Controls.Add(this.Enemy2);
            this.Controls.Add(this.Enemy4);
            this.Controls.Add(this.Enemy1);
            this.Controls.Add(this.Enemy3);
            this.Controls.Add(this.pbRoadLine1);
            this.Controls.Add(this.pbRoadLine2);
            this.Controls.Add(this.pbRoadLine3);
            this.Controls.Add(this.pbBountRight);
            this.Controls.Add(this.pbBoundLeft);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoadLine1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoadLine2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRoadLine3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBountRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoundLeft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBoundLeft;
        private System.Windows.Forms.PictureBox pbBountRight;
        private System.Windows.Forms.PictureBox pbRoadLine3;
        private System.Windows.Forms.PictureBox pbRoadLine2;
        private System.Windows.Forms.PictureBox pbRoadLine1;
        private System.Windows.Forms.PictureBox Enemy3;
        private System.Windows.Forms.PictureBox Coin3;
        private System.Windows.Forms.Label lblCoins;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.PictureBox Coin1;
        private System.Windows.Forms.PictureBox Coin2;
        private System.Windows.Forms.PictureBox Coin4;
        private System.Windows.Forms.PictureBox Coin5;
        private System.Windows.Forms.PictureBox Coin6;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox Enemy1;
        private System.Windows.Forms.PictureBox Enemy4;
        private System.Windows.Forms.PictureBox Enemy2;
        private System.Windows.Forms.PictureBox Enemy5;
        private System.Windows.Forms.PictureBox Car;
    }
}