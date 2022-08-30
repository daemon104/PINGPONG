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
    public partial class SanhCho : Form
    {
        public int id { get; set; }
        public string nickname { get; set; }

        public static string player_name_temp = "";
        public static int player_id_temp = 0;

        public SanhCho()
        {
            InitializeComponent();
        }

        private void SanhCho_Load(object sender, EventArgs e)
        {           
            tbId.Text = id.ToString();
            tbNickname.Text = nickname;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            player_name_temp = tbNickname.Text;
            player_id_temp = Convert.ToInt32(tbId.Text);
            ChonCheDo formz = new ChonCheDo();          
            formz.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Menu form = new Menu();
            form.Show();
            this.Hide();
        }
       
    }
}
