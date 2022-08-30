using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PINGPONG
{
    public partial class ChucMung : Form
    {
        public ChucMung()
        {
            InitializeComponent();
        }

        public static string congrat_state_before = "";
        public string congrat_state_after { get; set; }

        private void ChucMung_Load(object sender, EventArgs e)
        {         
            if (Pong.signal == 1)
            {
                lbCongrat.Text = "CHÚC MỪNG BẠN ĐÃ GIÀNH CHIẾN THẮNG!!";
            }
            else if (Pong.signal == 2)
            {
                lbCongrat.Text = "THUA MẤT RỒI!!\nTHỬ LẠI NGAY THÔI!!";
            }

            lbCongrat.Parent = background;
            lbCongrat.BackColor = Color.Transparent;
            btnRetry.Parent = background;
            btnRetry.BackColor = Color.Transparent;
            btnHistory.Parent = background;
            btnHistory.BackColor = Color.Transparent;
            btnGoback.Parent = background;
            btnGoback.BackColor = Color.Transparent;
            congrat_state_before = lbCongrat.Text;
            if (congrat_state_after != null)
            {
                lbCongrat.Text = congrat_state_after;
            }           
        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            ChonCheDo form = new ChonCheDo();           
            form.Show();
            this.Hide();
        }

        private void btnGoback_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            form.Show();
            this.Hide();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            LichSuDau form = new LichSuDau();
            form.Show();
            this.Hide();
        }
    }
}
