namespace PINGPONG
{
    partial class ChucMung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChucMung));
            this.background = new System.Windows.Forms.PictureBox();
            this.lbCongrat = new System.Windows.Forms.Label();
            this.btnRetry = new System.Windows.Forms.Button();
            this.btnGoback = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.background)).BeginInit();
            this.SuspendLayout();
            // 
            // background
            // 
            this.background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.background.Image = ((System.Drawing.Image)(resources.GetObject("background.Image")));
            this.background.Location = new System.Drawing.Point(0, 0);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(731, 395);
            this.background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.background.TabIndex = 0;
            this.background.TabStop = false;
            // 
            // lbCongrat
            // 
            this.lbCongrat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCongrat.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCongrat.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.lbCongrat.Location = new System.Drawing.Point(86, 65);
            this.lbCongrat.Name = "lbCongrat";
            this.lbCongrat.Size = new System.Drawing.Size(554, 169);
            this.lbCongrat.TabIndex = 1;
            this.lbCongrat.Text = "THUA MẤT RỒI!!\r\nTHỬ LẠI NGAY THÔI!!";
            this.lbCongrat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRetry
            // 
            this.btnRetry.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRetry.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnRetry.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnRetry.Location = new System.Drawing.Point(86, 276);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(156, 46);
            this.btnRetry.TabIndex = 2;
            this.btnRetry.Text = "Chơi lại";
            this.btnRetry.UseVisualStyleBackColor = true;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // btnGoback
            // 
            this.btnGoback.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnGoback.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnGoback.Location = new System.Drawing.Point(484, 276);
            this.btnGoback.Name = "btnGoback";
            this.btnGoback.Size = new System.Drawing.Size(156, 46);
            this.btnGoback.TabIndex = 3;
            this.btnGoback.Text = "Về Menu";
            this.btnGoback.UseVisualStyleBackColor = true;
            this.btnGoback.Click += new System.EventHandler(this.btnGoback_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnHistory.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnHistory.Location = new System.Drawing.Point(248, 276);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(230, 46);
            this.btnHistory.TabIndex = 4;
            this.btnHistory.Text = "Lịch sử đấu";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // ChucMung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 395);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnGoback);
            this.Controls.Add(this.btnRetry);
            this.Controls.Add(this.lbCongrat);
            this.Controls.Add(this.background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChucMung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChucMung";
            this.Load += new System.EventHandler(this.ChucMung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.background)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox background;
        private Label lbCongrat;
        private Button btnRetry;
        private Button btnGoback;
        private Button btnHistory;
    }
}