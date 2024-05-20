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

namespace Uni_Companion
{
    public partial class rent : Form
    {
        public string ID { set; get; }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2J7KK7;Initial Catalog=Uni Companion DB;Integrated Security=True");


        public rent(string id)
        {
            InitializeComponent();
            ID = id;
        }

        private void rent_Load(object sender, EventArgs e)
        {
            profile_bt.Text = ID;

            string query = "SELECT Flat_info.Flat_id, Flat_info.Address, Flat_info.Floor, Flat_info.Rent, Flat_info.No_of_room, Flat_info.Owner_id," +
                " Owner_info.Name, Owner_info.Contact_num, Owner_info.Email   " +
               "FROM Flat_info " +
               "INNER JOIN Owner_info ON Flat_info.Owner_id = Owner_info.Owner_id";
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            all_Flats.DataSource = dt;
            con.Close();
        }

        private void home_bt_Click(object sender, EventArgs e)
        {
            student_home sh = new student_home(ID);
            this.Hide();
            sh.Show();
        }

        private void schedule_setting_Click(object sender, EventArgs e)
        {
            schedule_settings ss = new schedule_settings(ID);
            this.Hide();
            ss.Show();
        }

        private void recruit_bt_Click(object sender, EventArgs e)
        {
            recruitment r = new recruitment(ID);
            this.Hide();
            r.Show();
        }

        private void BuySell_bt_Click(object sender, EventArgs e)
        {
            Sell bs = new Sell(ID);
            this.Hide();
            bs.Show();
        }

        private void profile_bt_Click(object sender, EventArgs e)
        {
            profile p = new profile(ID, "owner");
            this.Hide();
            p.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "High to Low")
            {
                string query = "SELECT Flat_info.Flat_id, Flat_info.Address, Flat_info.Floor, Flat_info.Rent, Flat_info.No_of_room, Flat_info.Owner_id," +
                               " Owner_info.Name, Owner_info.Contact_num, Owner_info.Email   " +
                               "FROM Flat_info " +
                               "INNER JOIN Owner_info ON Flat_info.Owner_id = Owner_info.Owner_id " +
                               "order by Flat_info.Rent desc";
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                all_Flats.DataSource = dt;
                con.Close();
            }
            else if (comboBox1.Text == "Low to High")
            {
                string query = "SELECT Flat_info.Flat_id, Flat_info.Address, Flat_info.Floor, Flat_info.Rent, Flat_info.No_of_room, Flat_info.Owner_id," +
                               " Owner_info.Name, Owner_info.Contact_num, Owner_info.Email   " +
                               "FROM Flat_info " +
                               "INNER JOIN Owner_info ON Flat_info.Owner_id = Owner_info.Owner_id " +
                               "order by Flat_info.Rent";
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                all_Flats.DataSource = dt;
                con.Close();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            student_home sh = new student_home(ID);
            this.Hide();
            sh.Show();
        }
    }
}
