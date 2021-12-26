using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Гонки
{
    public partial class Form2 : Form
    {
        int timeSpeed;
        int gameSpeed;
        int carTurnSpeed;
        bool isGameOver;

        PictureBox[] roadlines;
        PictureBox[] enemys;
        PictureBox[] coins;
        Random random;
        int collectedcoins;



        public Form2()
        {
            InitializeComponent();
            init_game();
        }

        void init_game()
        {
            timeSpeed  = 100;
            gameSpeed = 2;
            carTurnSpeed = 35;
            isGameOver = false;

            roadlines = new PictureBox[] { pbBoundLeft, pbBountRight, pbRoadLine1, pbRoadLine2, pbRoadLine3 };
            enemys = new PictureBox[] { Enemy1, Enemy2, Enemy3, Enemy4, Enemy5 };
            coins = new PictureBox[] { Coin1, Coin2, Coin4, Coin5, Coin6};
            random = new Random();
            collectedcoins = 0;

            gen_start_pos();

            Car.Image = Properties.Resources.Car;
            lblGameOver.Visible = false;

            GameTimer.Interval = 1000 / timeSpeed;
            GameTimer.Start();
        }

        void gen_start_pos()
        {
            int startY = -Enemy1.Height;
            int x;
            for (int i = 0; i < enemys.Length; i++)
            {
                x = random.Next(pbBoundLeft.Right, pbBountRight.Left);
                enemys[i].Location = new Point(x, startY);
                startY -= this.Height / enemys.Length;
            }
        }

        void move_enemys()
        {
            int x;
            for (int i = 0; i < enemys.Length; i++)
            {
                if (enemys[i].Top > this.Height)
                {
                    x = random.Next(pbBoundLeft.Right, pbBountRight.Left);
                    enemys[i].Location = new Point(x, -enemys[i].Height);
                }
                else
                {
                    enemys[i].Top += gameSpeed;
                }
                    
                
            }
        }

        void move_lines()
        {
            for (int i = 0; i < roadlines.Length; i ++)
            {
                if (roadlines[i].Top > -roadlines[i].Height)
                {
                    roadlines [i].Top =  - roadlines[i].Height;
                }
                else
                {
                    roadlines[i].Top += gameSpeed;
                }
            }
        }

        void move_coins()
        {
            int x;
            for (int i = 0; i < coins.Length; i++)
            {
                if (coins[i].Top > this.Height)
                {
                    x = random.Next(pbBoundLeft.Right, pbBountRight.Left);
                    coins[i].Location = new Point(x, -coins[i].Height);
                }
                else
                {
                    coins[i].Top += gameSpeed;
                }
            }
        }
        void is_get_coins()
        {
            int x; 
            for (int i = 0; i < coins.Length; i++) 
            {
                if (Car.Bounds.IntersectsWith(coins[i].Bounds))
                {

                    collectedcoins++;
                    x = random.Next(pbBoundLeft.Right, pbBountRight.Left - coins[i].Width);
                    coins[i].Location = new Point(x, -coins[i].Width);
                }
            }
            lblCoins.Text = "Coins = " + collectedcoins; 
        }

        void gameover_actions()
        {
            GameTimer.Stop();
            lblGameOver.Visible = true;
            Car.Image = Properties.Resources.Boom;

            DialogResult result = MessageBox.Show(
                    "Хочешь сыграть ещё раз?",
                    "Ты проиграл :(",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                init_game();
            }
            else
            {
                Close();
            }
        }

        bool Check_intersections()
        {
            for (int i = 0; i < enemys.Length; i++)
            {
                if (Car.Bounds.IntersectsWith(enemys[i].Bounds))
                {
                    return true;
                }
            }
            return false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            move_enemys();
            move_coins();
            move_enemys();
            is_get_coins();
            isGameOver = Check_intersections();
            if (isGameOver)
            {
                gameover_actions();
            }
        }

        private void Enemy3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (!isGameOver)
            {
                switch (e.KeyCode)
                {
                    case Keys.Left:
                        if (Car.Left > pbBoundLeft.Right)
                        {
                            Car.Left -= carTurnSpeed;
                        }
                        break;
                    case Keys.Right:
                        if (Car.Right < pbBountRight.Left)
                        {
                            Car.Left += carTurnSpeed;
                        }
                        break;

                    case Keys.Up:
                        if ( gameSpeed < 21)
                        {
                            gameSpeed++;
                        }
                        break;
                    case Keys.Down:
                        if (gameSpeed > 4)
                        {
                            gameSpeed--;
                        }
                        break;
                }
            }
        }
    }
}
