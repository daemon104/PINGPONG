namespace PINGPONG
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnIntro_Click(object sender, EventArgs e)
        {
            GioiThieu form = new GioiThieu();
            form.Show();
            this.Hide();
        }

        private void btnSignin_Click(object sender, EventArgs e)
        {
            DangNhap form = new DangNhap();
            form.Show();
            this.Hide();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            DangKy form = new DangKy();
            form.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}