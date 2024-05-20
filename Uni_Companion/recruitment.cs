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
    public partial class recruitment : Form
    {
        public string ID { set; get; }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2J7KK7;Initial Catalog=Uni Companion DB;Integrated Security=True");

        public recruitment(string id)
        {
            InitializeComponent();
            ID = id;
        }

        private void recruitment_Load(object sender, EventArgs e)
        {
            profile_bt.Text = ID;

            string query = "select Offer_info.Offer_id, Offer_info.Job_title, Offer_info.preffered_department, Offer_info.Job_type, Offer_info.Salary, Offer_info.Location, Offer_info.recruiter_id, " +
                "Recruiter_info.Name, Recruiter_info.Contact_num, Recruiter_info.Email " +
                    "from Offer_info INNER JOIN Recruiter_info ON Offer_info.Recruiter_id = Recruiter_info.Recruiter_id ";
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            all_recruit.DataSource = dt;
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

        private void rent_bt_Click(object sender, EventArgs e)
        {
            rent r = new rent(ID);
            this.Hide();
            r.Show();
        }

        private void BuySell_bt_Click(object sender, EventArgs e)
        {
            Buy bs = new Buy("22-49451-3");
            this.Hide();
            bs.Show();
        }


        private void profile_bt_Click(object sender, EventArgs e)
        {
            profile p = new profile(ID, "recruiter");
            this.Hide();
            p.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text== "High to Low")
            {
                string query = "select Offer_info.Offer_id, Offer_info.Job_title, Offer_info.preffered_department, Offer_info.Job_type, Offer_info.Salary, Offer_info.Location, Offer_info.recruiter_id, Recruiter_info.Name " +
                    "from Offer_info INNER JOIN Recruiter_info ON Offer_info.Recruiter_id = Recruiter_info.Recruiter_id " +
                    "order by Offer_info.Salary desc";
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                all_recruit.DataSource = dt;
                con.Close();
            }
            else if (comboBox1.Text == "Low to High")
            {
                string query = "select Offer_info.Offer_id, Offer_info.Job_title, Offer_info.preffered_department, Offer_info.Job_type, Offer_info.Salary, Offer_info.Location, Offer_info.recruiter_id, Recruiter_info.Name " +
                    "from Offer_info INNER JOIN Recruiter_info ON Offer_info.Recruiter_id = Recruiter_info.Recruiter_id " +
                    "order by Offer_info.Salary";
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                all_recruit.DataSource = dt;
                con.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            student_home sh = new student_home(ID);
            this.Hide();
            sh.Show();
        }
    }
}
