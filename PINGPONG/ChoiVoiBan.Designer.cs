namespace PINGPONG
{
    partial class ChoiVoiBan
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnJoin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Location = new System.Drawing.Point(88, 364);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(154, 73);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Trở Về";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCreate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCreate.Location = new System.Drawing.Point(88, 135);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(154, 73);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Tạo Phòng";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(331, 448);
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(52, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 46);
            this.label1.TabIndex = 23;
            this.label1.Text = "Chơi Với Bạn";
            // 
            // btnJoin
            // 
            this.btnJoin.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnJoin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnJoin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnJoin.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnJoin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnJoin.Location = new System.Drawing.Point(88, 249);
            this.btnJoin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(154, 73);
            this.btnJoin.TabIndex = 24;
            this.btnJoin.Text = "Vào Phòng";
            this.btnJoin.UseVisualStyleBackColor = false;
            // 
            // ChoiVoiBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 450);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ChoiVoiBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CHƠI VỚI BẠN";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBack;
        private Button btnCreate;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnJoin;
    }
}