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
    public partial class ChoiVoiBan : Form
    {
        public ChoiVoiBan()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            SettingCVB formSettingCVB = new SettingCVB();
            formSettingCVB.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ChonCheDo form = new ChonCheDo();
            form.Show();
            this.Hide();
        }
    }
}
