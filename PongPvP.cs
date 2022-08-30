using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PINGPONG
{
    public partial class PongPvP : Form
    {
        // Linked data
        public int mode { get; set; }
        public int ball_speed { get; set; }
        public int cpu_speed { get; set; }
        public int winPoint { get; set; }

        // Location Variables 
        int cpuDirection = 4;
        int ballXCoordinate = 6;
        int ballYCoordinate = 6;

        // Score Variables
        int playerScore = 0;
        int cpuScore = 0;


        // Size Variables
        int bottomBoundary;
        int centerPoint;
        int xMidpoint;
        int yMidpoint;

        // Detection Variables
        bool playerDetectedUp;
        bool playerDetectedDown;

        // Special Keys
        int spaceBarClicked = 0;

        // Other variables
        int countdown = 2;
        string name_temp;
        int id_temp;
        public static int signal = 0;

        // Connection variables
        string strConnection = "Data Source=DAEMON;Initial Catalog=PING_PONG_GAME;Integrated Security=True";
        SqlConnection conn;
        SqlCommand command;

        public PongPvP()
        {
            InitializeComponent();
            bottomBoundary = ClientSize.Height - player2.Height;
            xMidpoint = ClientSize.Width / 2;
            yMidpoint = ClientSize.Height / 2;
            mode = 1;
            winPoint = 5;
            countdownTimer.Start();
        }

        private void PongPvP_Load(object sender, EventArgs e)
        {
            name_temp = SanhCho.player_name_temp;
            id_temp = SanhCho.player_id_temp;
            player1_name.Text = name_temp;
            //cpuDirection = cpu_speed;
            if (mode == 0)
            {
                player2_name.Text = "Tiger";
            }
            else if (mode == 1)
            {
                player2_name.Text = "Dragon";
            }
            else
            {
                player2_name.Text = "Demon";
            }

            player1_score.Parent = play_ground;
            player1_score.BackColor = Color.Transparent;
            player2_score.Parent = play_ground;
            player2_score.BackColor = Color.Transparent;
            player1_name.Parent = play_ground;
            player1_name.BackColor = Color.Transparent;
            player2_name.Parent = play_ground;
            player2_name.BackColor = Color.Transparent;
            lbCountdown.Parent = play_ground;
            lbCountdown.BackColor = Color.Transparent;
        }

        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            lbCountdown.Text = countdown--.ToString();

            if (countdown < 0)
            {
                lbCountdown.Text = "LET'S GO!!";
            }

            if (countdown < -1)
            {
                countdownTimer.Stop();
                pongTimer.Start();
            }
        }

        private void pongTimer_Tick(object sender, EventArgs e)
        {
            Random newBallSpot = new Random();
            Random cpu_id_ran = new Random();
            int newSpot = newBallSpot.Next(100, ClientSize.Height - 100);
            int cpuid = cpu_id_ran.Next(1, 10000);
            lbCountdown.Hide();

            // Adjust where the ball is
            ball.Top -= ballYCoordinate;
            ball.Left -= ballXCoordinate;

            // Make the CPU move
            player2.Top += cpuDirection;

            // Check if CPU has reached the top or the bottom
            if (player2.Top < 0 || player2.Top > bottomBoundary) { cpuDirection = -cpuDirection; }

            // Check if the ball has exited the left side of the screen
            if (ball.Left < 0)
            {
                ball.Left = xMidpoint;
                ball.Top = newSpot;
                ballXCoordinate = -ballXCoordinate;

                if (playerScore < 5)
                {
                    ballXCoordinate -= 1;//ball_speed;
                }

                playerScore++;
                player1_score.Text = playerScore.ToString();

            }

            // Check if the ball has exited the right side of the screen
            if (ball.Left + ball.Width > ClientSize.Width)
            {
                ball.Left = xMidpoint;
                ball.Top = newSpot;
                ballXCoordinate = -ballXCoordinate;

                if (playerScore < 5)
                {
                    ballXCoordinate += 1;//ball_speed;
                }

                cpuScore++;
                player2_score.Text = cpuScore.ToString();
            }

            // Ensure the ball is within the boundaries of the screen
            if (ball.Top < 0 || ball.Top + ball.Height > ClientSize.Height) { ballYCoordinate = -ballYCoordinate; }

            // Check if the ball hits the player or CPU paddle
            if (ball.Bounds.IntersectsWith(player1.Bounds) || ball.Bounds.IntersectsWith(player2.Bounds))
            {
                // Send ball opposite direction
                ballXCoordinate = -ballXCoordinate;
            }

            // Move player up
            if (playerDetectedUp == true && player1.Top > 0) { player1.Top -= 10; }

            // Move player down
            if (playerDetectedDown == true && player1.Top < bottomBoundary) { player1.Top += 10; }

            // Check for winner
            if (playerScore >= winPoint || cpuScore >= winPoint)
            {
                pongTimer.Stop();
                /*
                string winner = "";
                string full_player2_name = player2_name.Text + " (CPU)";
                if (playerScore > cpuScore)
                {
                    winner = "Score: " + playerScore.ToString() + "-" + cpuScore.ToString()
                        + " [Winner:" + player1_name.Text + "]";
                    signal = 1;
                }
                else if (playerScore < cpuScore)
                {
                    winner = "Score: " + playerScore.ToString() + "-" + cpuScore.ToString()
                        + " [Winner: " + player2_name.Text + "]";
                    signal = 2;
                }

                conn = new SqlConnection(strConnection);
                command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "STORED_HISTORY";
                command.Parameters.AddWithValue("@PLAYER1_NAME", name_temp);
                command.Parameters.AddWithValue("@PLAYER2_NAME", full_player2_name);
                command.Parameters.AddWithValue("@PLAYER1_ID", id_temp);
                command.Parameters.AddWithValue("@PLAYER2_ID", cpuid);
                command.Parameters.AddWithValue("@RESULT", winner);
                command.Connection = conn;
                conn.Open();

                object codegeass = command.ExecuteScalar();
                int x = Convert.ToInt32(codegeass);

                if (x == 1)
                {
                    MessageBox.Show("Cập nhật lịch sử đấu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lỗi!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                conn.Close();

                ChucMung form = new ChucMung();
                form.Show();
                this.Hide();
                */
            }
        }

        private void PongPvP_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) { playerDetectedUp = false; }
            if (e.KeyCode == Keys.Down) { playerDetectedDown = false; }
        }

        private void PongPvP_KeyDown(object sender, KeyEventArgs e)
        {
            // If player presses the up arrow, move paddle upwards
            if (e.KeyCode == Keys.Up) { playerDetectedUp = true; }

            // If player presses the down arrow, move paddle downwards
            if (e.KeyCode == Keys.Down) { playerDetectedDown = true; }

            // If player presses space bar, pause the game
            if (e.KeyCode == Keys.Space)
            {
                if (spaceBarClicked % 2 == 0)
                {
                    pongTimer.Stop();
                    lbCountdown.Show();
                    lbCountdown.Text = "PAUSE";
                }
                else
                {
                    pongTimer.Start();
                }
            }
            spaceBarClicked++;
        }
    }
}
