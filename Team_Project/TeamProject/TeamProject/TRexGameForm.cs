using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamProject
{
    public partial class tRexGameForm : Form
    {

        bool isJumping = false;
        int jumpSpeed = 12;
        int jumpLimit = 12;
        int score = 0;
        int obstacleSpeed = 10;
        Random random = new Random();
        int position;
        bool isGameOver = false;

        public tRexGameForm()
        {
            InitializeComponent();
            startGame();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            tRexPictureBox.Top += jumpSpeed;
            scoreLabel.Text = "Score: " + score;
            if (isJumping == true && jumpLimit < 0)
            {
                isJumping = false;
            }

            if (isJumping == true)
            {
                jumpSpeed = -12;
                jumpLimit -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }

            if (tRexPictureBox.Top > 235 && isJumping == false)
            {
                jumpLimit = 12;
                tRexPictureBox.Top = 236;
                jumpSpeed = 0;
            }

            foreach(Control c in this.Controls)
            {
                if (c is PictureBox && (string)c.Tag == "obstacle")
                {
                    c.Left -= obstacleSpeed;

                    if (c.Left < -100)
                    {
                        c.Left = this.ClientSize.Width + random.Next(200, 500) + (c.Width * 15);
                        score++;
                    }

                    if (tRexPictureBox.Bounds.IntersectsWith(c.Bounds))
                    {
                        scoreTimer.Stop();
                        tRexPictureBox.Image = Properties.Resources.dead;
                        scoreLabel.Text += "";
                        gameOverLabel.Text = $"Press S to save you score \n" +
                            $"Press V to view previous scores \n" +
                            $"Press R to restart game  \n" +
                            $"Press X to close the game";
                        startLabel.Text = "Game Over";
                        isGameOver = true;
                    }
                }
            }
            if (score > 10)
            {
                obstacleSpeed = 15;
            }
            if (score > 30)
            {
                obstacleSpeed = 20;
            }
        }

        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space && isJumping == false)
            {
                isJumping = true;
            }
        }

        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (isJumping == true)
            {
                isJumping = false;
            }

            if(e.KeyCode == Keys.S && isGameOver == true)
            {
                ScoreSaverForm sSF = new ScoreSaverForm();
                sSF.Show();
            }

            if(e.KeyCode == Keys.V && isGameOver == true)
            {
                ScoreViewerForm sVF = new ScoreViewerForm();
                sVF.Show();
            }

            if (e.KeyCode == Keys.X && isGameOver == true)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.R && isGameOver == true)
            {
                resetGame();
            }

            if (e.KeyCode == Keys.Space && isGameOver == true && score == 0)
            {
                resetGame();
            }
        }

        private void startGame()
        {
            score = 0;
            obstacleSpeed = 0;
            startLabel.Text = "Press Space to start";
            scoreLabel.Text = "Score: " + score;
            gameOverLabel.Text = " ";
            tRexPictureBox.Image = Properties.Resources.running;
            isGameOver = true;
        }
        private void resetGame()
        {
            jumpLimit = 12;
            jumpSpeed = 0;
            isJumping = false;
            score = 0;
            obstacleSpeed = 10;
            startLabel.Text = " ";
            scoreLabel.Text = "Score: " + score;
            gameOverLabel.Text = " ";
            tRexPictureBox.Image = Properties.Resources.running;
            isGameOver = false;
            tRexPictureBox.Top = 236;

            foreach (Control c in this.Controls)
            {
                if(c is PictureBox && (string)c.Tag == "obstacle")
                {
                    position = this.ClientSize.Width + random.Next(500, 800) + (c.Width * 10);
                    c.Left = position;
                }
            }
            scoreTimer.Start();
        }
    }
}
