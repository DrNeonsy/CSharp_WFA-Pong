namespace CSharp_WFA_Pong
{
    public partial class Game : Form
    {
        // Variables Player One
        bool playerOneMovesDown = false; // Checking Whether You Move Down
        bool playerOneMovesUp = false; // Checking Whether You Move Up

        // Variables Player Two
        bool playerTwoMovesDown = false; // Checking Whether You Move Down
        bool playerTwoMovesUp = false; // Checking Whether You Move Up

        // Variables Pong Game
        int leftSideScore = 0;
        int rightSideScore = 0;

        readonly int playerSpeed = 10; // How Fast The Player Can Move (In Pixel)

        int pongX = 10; // Pong Horizontal Speed (Initially)
        int pongY = 10; // Pong Vertical Speed (Initially)

        readonly int xCenter; // Horizontal Center Of The Game
        readonly Random random = new(); // This Object Allows For Random Number Generation

        int pause = 0;
        bool gameFinished = false;

        public Game()
        {
            // playerOne.Top += playerSpeed; => Player Moves Down
            // playerOne.Top -= playerSpeed; => Player Moves Up

            // playerOne.Top + playerOne.Height => The Top Of The PlayerOne "Image" + Height Will Result In The Bottom Location
            InitializeComponent();
            xCenter = ClientSize.Width / 2;
        }

        private void Loop(object sender, EventArgs e) // Executes Every x Ticks (Constantly)
        {
            // Left Player (P1)
            // 1. Move
            if (playerOneMovesUp && playerOne.Top > 0) { playerOne.Top -= playerSpeed; }
            else if (playerOneMovesDown && playerOne.Top + playerOne.Height < ClientSize.Height) { playerOne.Top += playerSpeed; }
            // Right Player (P2)
            // 1. Move
            if (playerTwoMovesUp && playerTwo.Top > 0) { playerTwo.Top -= playerSpeed; }
            else if (playerTwoMovesDown && playerTwo.Top + playerTwo.Height < ClientSize.Height) { playerTwo.Top += playerSpeed; }
            // Pong Ball
            // 1. Move
            pongBall.Top -= pongY;
            pongBall.Left -= pongX;
            // 2. Collision
            if (pongBall.Top < 0 || pongBall.Top + pongBall.Height > ClientSize.Height) { pongY *= -1; }
            if (pongBall.Bounds.IntersectsWith(playerOne.Bounds)) { pongX *= -1; }
            if (pongBall.Bounds.IntersectsWith(playerTwo.Bounds)) { pongX *= -1; }
            // 3. Pong Ball Leaves Left Side Of The Screen => Right Side Scores
            if (pongBall.Left < 0)
            {
                pongBall.Left = xCenter; // Respwans In The Horizontal Center
                pongBall.Top = random.Next(100, ClientSize.Height - 100); // Respawns At The Random Generated Y "Height"
                pongX *= -1; // Change Respawn Direction
                rightSideScore++; // Add 1 To The Current Score
                scoreRightSide.Text = rightSideScore.ToString(); // Update Current Score Label
            }
            if (pongBall.Left + pongBall.Width > ClientSize.Width)
            {
                pongBall.Left = xCenter; // Respwans In The Horizontal Center
                pongBall.Top = random.Next(0, ClientSize.Height - 234); // Respawns At The Random Generated Y "Height"
                pongX *= -1; // Change Respawn Direction
                leftSideScore++; // Add 1 To The Current Score
                scoreLeftSide.Text = leftSideScore.ToString(); // Update Current Score Label
            }
            // Game Full Stop
            if (leftSideScore == 99 || rightSideScore == 99) { gameLoop.Stop(); gameFinished = true; }
        }

        private void Game_KeyDown(object sender, KeyEventArgs e) // When A Key Has Been Pressed
        {
            // P1
            if (e.KeyCode == Keys.W) { playerOneMovesUp = true; }
            if (e.KeyCode == Keys.S) { playerOneMovesDown = true; }
            // P2
            if (e.KeyCode == Keys.Up) { playerTwoMovesUp = true; }
            if (e.KeyCode == Keys.Down) { playerTwoMovesDown = true; }
            // Pause Key
            if (e.KeyCode == Keys.Space && !gameFinished)
            {
                pause++;
                if (pause % 2 != 0)
                {
                    gameLoop.Stop();
                }
                else
                {
                    gameLoop.Start();
                    pause = 0;
                }
            }
            // Exit Key
            if (e.KeyCode == Keys.Escape) { Application.Exit(); }
        }

        private void Game_KeyUp(object sender, KeyEventArgs e) // When A Key Has Been Released
        {
            // P1
            if (e.KeyCode == Keys.W) { playerOneMovesUp = false; }
            if (e.KeyCode == Keys.S) { playerOneMovesDown = false; }
            // P2
            if (e.KeyCode == Keys.Up) { playerTwoMovesUp = false; }
            if (e.KeyCode == Keys.Down) { playerTwoMovesDown = false; }
        }
    }
}