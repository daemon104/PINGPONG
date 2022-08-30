namespace PINGPONG
{
    partial class Pong
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
            this.cpu = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.player_score = new System.Windows.Forms.Label();
            this.cpu_score = new System.Windows.Forms.Label();
            this.pongTimer = new System.Windows.Forms.Timer(this.components);
            this.lbCountdown = new System.Windows.Forms.Label();
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            this.player_name = new System.Windows.Forms.Label();
            this.cpu_name = new System.Windows.Forms.Label();
            this.play_ground = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play_ground)).BeginInit();
            this.SuspendLayout();
            // 
            // cpu
            // 
            this.cpu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.cpu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpu.Location = new System.Drawing.Point(12, 180);
            this.cpu.Name = "cpu";
            this.cpu.Size = new System.Drawing.Size(13, 260);
            this.cpu.TabIndex = 0;
            this.cpu.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.RoyalBlue;
            this.player.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player.Location = new System.Drawing.Point(1224, 180);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(13, 260);
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Gray;
            this.ball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ball.Image = global::PINGPONG.Properties.Resources.glowing_neon_baseball_ball_icon_isolated_on_brick_wall_background_vector;
            this.ball.Location = new System.Drawing.Point(1050, 140);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(22, 22);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            // 
            // player_score
            // 
            this.player_score.AutoSize = true;
            this.player_score.BackColor = System.Drawing.Color.Transparent;
            this.player_score.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player_score.Font = new System.Drawing.Font("Segoe UI", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.player_score.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.player_score.Location = new System.Drawing.Point(646, 0);
            this.player_score.Name = "player_score";
            this.player_score.Size = new System.Drawing.Size(45, 52);
            this.player_score.TabIndex = 3;
            this.player_score.Text = "0";
            this.player_score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpu_score
            // 
            this.cpu_score.AutoSize = true;
            this.cpu_score.BackColor = System.Drawing.Color.Transparent;
            this.cpu_score.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cpu_score.Font = new System.Drawing.Font("Segoe UI", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.cpu_score.ForeColor = System.Drawing.Color.Fuchsia;
            this.cpu_score.Location = new System.Drawing.Point(561, 0);
            this.cpu_score.Name = "cpu_score";
            this.cpu_score.Size = new System.Drawing.Size(45, 52);
            this.cpu_score.TabIndex = 4;
            this.cpu_score.Text = "0";
            // 
            // pongTimer
            // 
            this.pongTimer.Interval = 10;
            this.pongTimer.Tick += new System.EventHandler(this.pongTimer_Tick);
            // 
            // lbCountdown
            // 
            this.lbCountdown.BackColor = System.Drawing.Color.Transparent;
            this.lbCountdown.Font = new System.Drawing.Font("OCR A Extended", 65F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCountdown.ForeColor = System.Drawing.Color.Fuchsia;
            this.lbCountdown.Location = new System.Drawing.Point(259, 258);
            this.lbCountdown.Name = "lbCountdown";
            this.lbCountdown.Size = new System.Drawing.Size(733, 146);
            this.lbCountdown.TabIndex = 6;
            this.lbCountdown.Text = "3";
            this.lbCountdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countdownTimer
            // 
            this.countdownTimer.Interval = 1500;
            this.countdownTimer.Tick += new System.EventHandler(this.countdownTimer_Tick);
            // 
            // player_name
            // 
            this.player_name.AutoSize = true;
            this.player_name.Font = new System.Drawing.Font("OCR A Extended", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.player_name.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.player_name.Location = new System.Drawing.Point(717, 0);
            this.player_name.Name = "player_name";
            this.player_name.Size = new System.Drawing.Size(162, 41);
            this.player_name.TabIndex = 7;
            this.player_name.Text = "Daemon";
            // 
            // cpu_name
            // 
            this.cpu_name.AutoSize = true;
            this.cpu_name.Font = new System.Drawing.Font("OCR A Extended", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpu_name.ForeColor = System.Drawing.Color.Fuchsia;
            this.cpu_name.Location = new System.Drawing.Point(398, 0);
            this.cpu_name.Name = "cpu_name";
            this.cpu_name.Size = new System.Drawing.Size(138, 41);
            this.cpu_name.TabIndex = 8;
            this.cpu_name.Text = "Kaiju";
            // 
            // play_ground
            // 
            this.play_ground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.play_ground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.play_ground.Image = global::PINGPONG.Properties.Resources.playground;
            this.play_ground.Location = new System.Drawing.Point(0, 0);
            this.play_ground.Name = "play_ground";
            this.play_ground.Size = new System.Drawing.Size(1249, 657);
            this.play_ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.play_ground.TabIndex = 5;
            this.play_ground.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1500;
            // 
            // Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1249, 657);
            this.Controls.Add(this.cpu_name);
            this.Controls.Add(this.player_name);
            this.Controls.Add(this.lbCountdown);
            this.Controls.Add(this.cpu_score);
            this.Controls.Add(this.player_score);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.player);
            this.Controls.Add(this.cpu);
            this.Controls.Add(this.play_ground);
            this.Name = "Pong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PvE";
            this.Load += new System.EventHandler(this.Pong_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pong_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Pong_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.cpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.play_ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox cpu;
        private PictureBox player;
        private PictureBox ball;
        private Label player_score;
        private Label cpu_score;
        public System.Windows.Forms.Timer pongTimer;
        private Label lbCountdown;
        private System.Windows.Forms.Timer countdownTimer;
        private Label cpu_name;
        private PictureBox play_ground;
        public Label player_name;
        private System.Windows.Forms.Timer timer1;
    }
}