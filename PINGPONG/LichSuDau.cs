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
    public partial class LichSuDau : Form
    {
        public LichSuDau()
        {
            InitializeComponent();
        }

        string congrat_state = "";

        // Connection variables
        string strConnection = "Data Source=DAEMON;Initial Catalog=PING_PONG_GAME;Integrated Security=True";
        SqlConnection conn;
        SqlCommand command;
        SqlDataAdapter adapter;
        DataTable dt;
        DataSet ds;

        private void LichSuDau_Load(object sender, EventArgs e)
        {
            congrat_state = ChucMung.congrat_state_before;

            listView1.Columns.Add("Match's ID", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Player1's Name", 150, HorizontalAlignment.Center);
            listView1.Columns.Add("Player2's Name", 150, HorizontalAlignment.Center);
            listView1.Columns.Add("Player1's ID", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Player2's ID", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Result", 330, HorizontalAlignment.Center);

            conn = new SqlConnection(strConnection);
            conn.Open();
            command = new SqlCommand("SELECT * FROM MATCH_HISTORY", conn);
            adapter = new SqlDataAdapter(command);
            ds = new DataSet();
            adapter.Fill(ds, "TEST");
            dt = ds.Tables["TEST"];

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                listView1.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[1].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[2].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[3].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[4].ToString());
                listView1.Items[i].SubItems.Add(dt.Rows[i].ItemArray[5].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChucMung form = new ChucMung();
            form.Show();
            form.congrat_state_after = congrat_state;
            this.Hide();
        }

    }
}
