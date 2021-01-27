using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class FlappyBirdGame : Form
    {
        int pipeSpeed = 8;
        int gravity = 5;
        int score = 0;
        public FlappyBirdGame()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void gameTimeEvent(object sender, EventArgs e)
        {
            FlappyBird.Top += gravity;
            pipeBotton.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;
            scoreText.Text = "Score: " + score.ToString();
            if (pipeBotton.Left < -150)
            {
                pipeBotton.Left = 800;
                score++;
            }
            if (pipeTop.Left<-180)
            {
                pipeTop.Left = 950;
                score++;
            }
            if (FlappyBird.Top < -25 || FlappyBird.Bounds.IntersectsWith(pipeBotton.Bounds)||FlappyBird.Bounds.IntersectsWith(pipeTop.Bounds)||FlappyBird.Bounds.IntersectsWith(ground.Bounds))
                endGame();
            if (score>5) 
                pipeSpeed = 10;  
            if (score > 10)
                pipeSpeed = 20;
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gravity = -5;
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                gravity = 5;
        }
        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += "  Game over!!!!";
        }
    }
   
}
