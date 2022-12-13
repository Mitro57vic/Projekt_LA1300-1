using System.Numerics;

namespace Pong_game
{
    public partial class Pong : Form
    {
        public Pong()
        {
            InitializeComponent();
        }
        
        //Variablen deklarieren
        bool goUp;
        bool goDown;
        int Speed = 5;
        int ballX = 7;
        int ballY = 7; 
        int Playerscore = 0;
        int ComScore = 0;
        int MidX = 408;
        int MidY = 245;

        public void BallMovement() //Bewegung vom Ball
        {
            Ball.Top -= ballY;
            Ball.Left -= ballX;

            ComBar.Top -= Speed;
            ComBar.Top = Ball.Top - 50;

            if (Ball.Left < 0)
            {
                Ball.Left = MidX - Ball.Width / 2;
                Ball.Top = MidY - Ball.Height / 2;
                ComScore++;
            }

            if (Ball.Left + Ball.Width > ClientSize.Width)
            {
                Ball.Top = MidY;
                Ball.Left = MidX;
                Playerscore++;
            }

            if (Ball.Top < 0 || Ball.Top + Ball.Height > ClientSize.Height)
            {
                ballY = -ballY;
            }

            if (Ball.Bounds.IntersectsWith(PlayerBar.Bounds) || Ball.Bounds.IntersectsWith(ComBar.Bounds))
            {
                ballX = -ballX;
            }
        }

        private void keyisdown(object sender, KeyEventArgs e) //Tastendruck erkennen
        {
            if(e.KeyCode == Keys.Up)
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)//Tasten loslassen erkennen
        {
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }
        public void BarControlls() //Bars bewegen
        {
            if (goUp == true && PlayerBar.Top > 0)
            {
                PlayerBar.Top -= 8;
            }

            if (goDown == true && PlayerBar.Top + PlayerBar.Height < ClientSize.Height)
            {
                PlayerBar.Top += 8;
            }
        }

        private void timerTick(object sender, EventArgs e) //Main
        {
            PlayerScoreLabel.Text = "" + Playerscore;
            ComScoreLabel.Text = "" + ComScore;

                BallMovement();
                BarControlls();

            if (Playerscore >= 10)
            {
                gameTimer.Stop();
                MessageBox.Show("Congratulations, you have won this game!");
            }

            if (ComScore >= 10)
            {
                gameTimer.Stop();
                MessageBox.Show("You lost this game :(");
            }
        }
    }
}
