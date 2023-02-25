using System.Drawing.Text;

namespace Space_Game
{
    public partial class Form1 : Form
    { 

         public int gravity = 5;
        public  int spaceSpeed =2;
        public int score = 0;

        public bool KeyPressed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.D)
            {
                KeyPressed = true;
                 gravity = -4;

            }
        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                KeyPressed = true;
                


                gravity = 4;

            }
        }

        private void Timer(object sender, EventArgs e)
        {
            SpaceShip.Left += gravity;
            Asteroid1.Top += spaceSpeed;
            Asteroid2.Top += spaceSpeed;    
            Asteroid3.Top += spaceSpeed;


            if(Asteroid1.Top  > 400)
            {
                Asteroid1.Top = -100;
                score = 1;

            }
            if (Asteroid2.Top > 400)
            {
                Asteroid2.Top = -100;
                score =1;

            }
            if (Asteroid3.Top > 400)
            {
                Asteroid3.Top = -100;
                score = 1;

            }

            if (SpaceShip.Bounds.IntersectsWith(Asteroid1.Bounds) ||
             SpaceShip.Bounds.IntersectsWith(Asteroid2.Bounds) ||
             SpaceShip.Bounds.IntersectsWith(Asteroid3.Bounds))
            {

                gameOver();

            }
           

            void gameOver()
            {
                timer1.Stop();
                GameOverLabel.Text = "GAME OVER!!";

                ScoreLabel.Text = "Your total score is :" + score;

            }

        }
    }
}