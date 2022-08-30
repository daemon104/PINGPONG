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
    public partial class ChonCheDo : Form
    {

        public ChonCheDo()
        {
            InitializeComponent();
        }

        private void btnPvE_Click(object sender, EventArgs e)
        {
            ChoiVoiMay form = new ChoiVoiMay();
            form.Show();
            this.Hide();
        }

        private void btnPvP_Click(object sender, EventArgs e)
        {
            ChoiVoiBan form = new ChoiVoiBan();
            form.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SanhCho form = new SanhCho();
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
