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
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        // Connection variables
        string strConnection = "Data Source=DAEMON;Initial Catalog=PING_PONG_GAME;Integrated Security=True";
        SqlConnection conn;
        SqlCommand command;

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string nickname = tbNickname.Text;
            string retype = tbRetype.Text;

            if (username == "" || password == "" || nickname == "" || retype == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (password != retype)
            {
                MessageBox.Show("Mật khẩu nhập lại không khớp!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (username.Length > 30 || password.Length > 30 || nickname.Length > 30 || retype.Length > 30)
            {
                MessageBox.Show("Thông tin điền vào quá độ dài quy định!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                conn = new SqlConnection(strConnection);
                command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SIGN_UP";
                command.Parameters.AddWithValue("@USERNAME", username);
                command.Parameters.AddWithValue("@PASSWORD", password);
                command.Parameters.AddWithValue("@NICKNAME", nickname);
                command.Connection = conn;
                conn.Open();

                object result = command.ExecuteScalar();
                int x = Convert.ToInt32(result);

                if (x == 2)
                {
                    MessageBox.Show("Đăng kí thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();

                    DangNhap form = new DangNhap();
                    form.Show();
                    this.Hide();
                }
                else if (x == 1)
                {
                    MessageBox.Show("Nickname đã tồn tại. Vui lòng nhập lại!", "Cảnh báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                }
                else if (x == 0)
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại. Vui lòng nhập lại!", "Cảnh báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                }
            }                  
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            form.Show();
            this.Hide();
        }

    }
}
