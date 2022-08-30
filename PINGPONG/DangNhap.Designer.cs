namespace PINGPONG
{
    partial class DangNhap
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
            this.btnSignin = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSignin
            // 
            this.btnSignin.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSignin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSignin.Location = new System.Drawing.Point(42, 341);
            this.btnSignin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSignin.Name = "btnSignin";
            this.btnSignin.Size = new System.Drawing.Size(125, 48);
            this.btnSignin.TabIndex = 2;
            this.btnSignin.Text = "ĐĂNG NHẬP";
            this.btnSignin.UseVisualStyleBackColor = false;
            this.btnSignin.Click += new System.EventHandler(this.btnSignin_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(42, 251);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(256, 27);
            this.tbPassword.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 32);
            this.label3.TabIndex = 11;
            this.label3.Text = "Mật Khẩu";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(42, 132);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(256, 27);
            this.tbUsername.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(79, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 46);
            this.label1.TabIndex = 8;
            this.label1.Text = "Đăng Nhập";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(331, 411);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Location = new System.Drawing.Point(173, 341);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(125, 48);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "TRỞ VỀ";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(196, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "Tối đa 30 kí tự";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(196, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Tối đa 30 kí tự";
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 412);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSignin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐĂNG NHẬP";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnSignin;
        private TextBox tbPassword;
        private Label label3;
        private TextBox tbUsername;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnBack;
        private Label label7;
        private Label label4;
    }
}