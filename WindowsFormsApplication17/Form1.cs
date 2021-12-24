using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication17
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 10;
        int gravity = 10;
      int score = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                gravity = -10;
            } 
        }
        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                gravity = 10;
            }       }
        private void endGame()
        {           
            gameTimer.Stop();
            scoreText.Text += " Game over!!!";
        }
        private void Form1_Load(object sender, EventArgs e)
        {        }
        private void gameTimerEvent(object sender, EventArgs e)
        {
            bird.Top += gravity;
            Bpipe.Left -= pipeSpeed;
            Tpipe.Left -= pipeSpeed;
            scoreText.Text = score.ToString();

              if (Bpipe.Left < -150)
              {
                  Bpipe.Left = 800;
                  score++;
              }
              if (Tpipe.Left < -180)
              {
                  Tpipe.Left = 950;
                  score++;
              }
              if (bird.Bounds.IntersectsWith(Bpipe.Bounds) ||
                bird.Bounds.IntersectsWith(Tpipe.Bounds) ||
                  bird.Bounds.IntersectsWith(ground.Bounds) ||
                  bird.Top < -25 )
              {
                  endGame();
              }

              if (score > 5)
              {
                  pipeSpeed = 20;
              }
             
        }
    }
}
