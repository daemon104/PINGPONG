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
    public partial class ChoiVoiMay : Form
    {
        public ChoiVoiMay()
        {
            InitializeComponent();
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            Pong form = new Pong();
            form.mode = 0;
            form.ball_speed = 0;
            form.cpu_speed = 4;
            form.winPoint = 10;
            form.ShowDialog();           
            this.Hide();
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            Pong form = new Pong();
            form.mode = 1;
            form.ball_speed = 1;
            form.cpu_speed = 5;
            form.winPoint = 7;
            form.ShowDialog();
            this.Hide();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            Pong form = new Pong();
            form.mode = 2;
            form.ball_speed = 2;
            form.cpu_speed = 8;
            form.winPoint = 5;
            form.ShowDialog();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ChonCheDo formChonCheDo = new ChonCheDo();
            formChonCheDo.Show();
            this.Hide();
        }
    }
}
