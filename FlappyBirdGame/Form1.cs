namespace FlappyBirdGame
{
    public partial class Form1 : Form
    {
        int boruHizi = 8;
        int gravity = 15;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            pcbFlappyBird.Top += gravity;
            pcpBoruAlt.Left -= boruHizi;
            pcbBoruUst.Left -= boruHizi;
            pcbBoruAlt2.Left -= boruHizi;
            pcbBoruUst2.Left -= boruHizi;
            lblScore.Text = "Score" + score;

            if (pcpBoruAlt.Left < -150)
            {
                pcpBoruAlt.Left = 800;
                score++;
            }
            if (pcbBoruAlt2.Left < -150)
            {
                pcbBoruAlt2.Left = 800;
                score++;
            }
            if (pcbBoruUst.Left < -180)
            {
                pcbBoruUst.Left = 950;
                score++;
            }

            if (pcbBoruUst2.Left < -180)
            {
                pcbBoruUst2.Left = 950;
                score++;
            }
            if (pcbFlappyBird.Bounds.IntersectsWith(pcpBoruAlt.Bounds) || pcbFlappyBird.Bounds.IntersectsWith(pcbBoruUst.Bounds) || pcbFlappyBird.Bounds.IntersectsWith(pcbZemin.Bounds) || pcbFlappyBird.Bounds.IntersectsWith(pcbBoruAlt2.Bounds) || pcbFlappyBird.Bounds.IntersectsWith(pcbBoruUst2.Bounds))
            {
                endGame();
            }
            if (score > 5)
            {
                boruHizi = 15;

            }
            if (pcbFlappyBird.Top < -25)
            {
                endGame();
            }

        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }
        private void endGame()
        {
            gameTimer.Stop();
            lblScore.Text = "Game Over!!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

}