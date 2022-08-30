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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        // Connection variables
        string strConnection = "Data Source=DAEMON;Initial Catalog=PING_PONG_GAME;Integrated Security=True";
        SqlConnection conn;
        SqlCommand command;

        // Data variables
        string username;
        string password;
        string nickname;
        int id;

        private void btnBack_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            form.Show();
            this.Hide();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            username = tbUsername.Text;
            password = tbPassword.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (username.Length > 30 || password.Length > 30)
            {
                MessageBox.Show("Thông tin điền vào quá độ dài quy định!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                conn = new SqlConnection(strConnection);
                command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SIGN_IN";
                command.Parameters.AddWithValue("@USERNAME", username);
                command.Parameters.AddWithValue("@PASSWORD", password);
                command.Connection = conn;
                conn.Open();

                object codegeass = command.ExecuteScalar();
                int x = Convert.ToInt32(codegeass);

                if (x == 1)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();

                    conn = new SqlConnection(strConnection);
                    command = new SqlCommand();
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "DATA_POURING";
                    command.Parameters.AddWithValue("@USERNAME", username);
                    command.Parameters.AddWithValue("@PASSWORD", password);
                    command.Connection = conn;
                    conn.Open();

                    SqlDataReader reader = command.ExecuteReader();


                    while (reader.Read())
                    {
                        id = Convert.ToInt32(reader["ID"]);
                        nickname = Convert.ToString(reader["NICKNAME"]);
                    }

                    SanhCho form1 = new SanhCho();
                    form1.id = id;
                    form1.nickname = nickname;
                    form1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu sai. Vui lòng nhập lại!", "Cảnh báo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                }               
            }            
        }
    }
}
