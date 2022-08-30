namespace PINGPONG
{
    partial class PongPvP
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
            this.play_ground = new System.Windows.Forms.PictureBox();
            this.player2 = new System.Windows.Forms.PictureBox();
            this.player1 = new System.Windows.Forms.PictureBox();
            this.player2_name = new System.Windows.Forms.Label();
            this.player2_score = new System.Windows.Forms.Label();
            this.player1_score = new System.Windows.Forms.Label();
            this.player1_name = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.lbCountdown = new System.Windows.Forms.Label();
            this.pongTimer = new System.Windows.Forms.Timer(this.components);
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.play_ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // play_ground
            // 
            this.play_ground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.play_ground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.play_ground.Image = global::PINGPONG.Properties.Resources.playground2;
            this.play_ground.Location = new System.Drawing.Point(0, 0);
            this.play_ground.Name = "play_ground";
            this.play_ground.Size = new System.Drawing.Size(1249, 657);
            this.play_ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.play_ground.TabIndex = 6;
            this.play_ground.TabStop = false;
            // 
            // player2
            // 
            this.player2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.player2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player2.Location = new System.Drawing.Point(12, 194);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(13, 269);
            this.player2.TabIndex = 7;
            this.player2.TabStop = false;
            // 
            // player1
            // 
            this.player1.BackColor = System.Drawing.Color.RoyalBlue;
            this.player1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player1.Location = new System.Drawing.Point(1224, 194);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(13, 269);
            this.player1.TabIndex = 8;
            this.player1.TabStop = false;
            // 
            // player2_name
            // 
            this.player2_name.AutoSize = true;
            this.player2_name.Font = new System.Drawing.Font("OCR A Extended", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.player2_name.ForeColor = System.Drawing.Color.Fuchsia;
            this.player2_name.Location = new System.Drawing.Point(392, 3);
            this.player2_name.Name = "player2_name";
            this.player2_name.Size = new System.Drawing.Size(138, 41);
            this.player2_name.TabIndex = 9;
            this.player2_name.Text = "Kaiju";
            // 
            // player2_score
            // 
            this.player2_score.AutoSize = true;
            this.player2_score.BackColor = System.Drawing.Color.Transparent;
            this.player2_score.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player2_score.Font = new System.Drawing.Font("Segoe UI", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.player2_score.ForeColor = System.Drawing.Color.Fuchsia;
            this.player2_score.Location = new System.Drawing.Point(563, 3);
            this.player2_score.Name = "player2_score";
            this.player2_score.Size = new System.Drawing.Size(45, 52);
            this.player2_score.TabIndex = 10;
            this.player2_score.Text = "0";
            // 
            // player1_score
            // 
            this.player1_score.AutoSize = true;
            this.player1_score.BackColor = System.Drawing.Color.Transparent;
            this.player1_score.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player1_score.Font = new System.Drawing.Font("Segoe UI", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.player1_score.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.player1_score.Location = new System.Drawing.Point(638, 3);
            this.player1_score.Name = "player1_score";
            this.player1_score.Size = new System.Drawing.Size(45, 52);
            this.player1_score.TabIndex = 11;
            this.player1_score.Text = "0";
            this.player1_score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // player1_name
            // 
            this.player1_name.AutoSize = true;
            this.player1_name.Font = new System.Drawing.Font("OCR A Extended", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.player1_name.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.player1_name.Location = new System.Drawing.Point(713, 3);
            this.player1_name.Name = "player1_name";
            this.player1_name.Size = new System.Drawing.Size(162, 41);
            this.player1_name.TabIndex = 12;
            this.player1_name.Text = "Daemon";
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Gray;
            this.ball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ball.Image = global::PINGPONG.Properties.Resources.glowing_neon_baseball_ball_icon_isolated_on_brick_wall_background_vector;
            this.ball.Location = new System.Drawing.Point(612, 83);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(22, 22);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball.TabIndex = 13;
            this.ball.TabStop = false;
            // 
            // lbCountdown
            // 
            this.lbCountdown.BackColor = System.Drawing.Color.Transparent;
            this.lbCountdown.Font = new System.Drawing.Font("OCR A Extended", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCountdown.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbCountdown.Location = new System.Drawing.Point(258, 255);
            this.lbCountdown.Name = "lbCountdown";
            this.lbCountdown.Size = new System.Drawing.Size(733, 146);
            this.lbCountdown.TabIndex = 14;
            this.lbCountdown.Text = "3";
            this.lbCountdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pongTimer
            // 
            this.pongTimer.Interval = 10;
            this.pongTimer.Tick += new System.EventHandler(this.pongTimer_Tick);
            // 
            // countdownTimer
            // 
            this.countdownTimer.Interval = 1500;
            this.countdownTimer.Tick += new System.EventHandler(this.countdownTimer_Tick);
            // 
            // PongPvP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 657);
            this.Controls.Add(this.lbCountdown);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.player1_name);
            this.Controls.Add(this.player1_score);
            this.Controls.Add(this.player2_score);
            this.Controls.Add(this.player2_name);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.play_ground);
            this.Name = "PongPvP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PvP";
            this.Load += new System.EventHandler(this.PongPvP_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PongPvP_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PongPvP_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.play_ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox play_ground;
        private PictureBox player2;
        private PictureBox player1;
        private Label player2_name;
        private Label player2_score;
        private Label player1_score;
        public Label player1_name;
        private PictureBox ball;
        private Label lbCountdown;
        public System.Windows.Forms.Timer pongTimer;
        private System.Windows.Forms.Timer countdownTimer;
    }
}