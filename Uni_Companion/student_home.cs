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
    public partial class student_home : Form
    {
        public string ID { set; get; }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2J7KK7;Initial Catalog=Uni Companion DB;Integrated Security=True");

        public student_home(string id)
        {
            InitializeComponent();
            this.Text = "Student Dashboard";
            ID = id;
        }

        private void profile_bt_Click(object sender, EventArgs e)
        {
            profile p = new profile(ID, "student_home", null);
            this.Hide();
            p.Show();
        }


        private void student_home_Load_1(object sender, EventArgs e)
        {
            profile_bt.Text = ID;
            string query = "SELECT si.Student_id, si.Name, sc.Schedule_id, sc.Day, sc.St_time, sc.Ed_time FROM Student_info si INNER JOIN Schedule_info sc ON si.Student_id = sc.Student_id " +
                "WHERE sc.Student_id <> '"+ ID +"' " +
                "AND sc.Accept_student ='' " +
                "AND sc.Day = any(SELECT Day FROM Schedule_info WHERE Student_id = '" + ID + "') " +
                "AND sc.St_time = any(SELECT St_time FROM Schedule_info WHERE Student_id = '" + ID + "') " +
                "AND sc.Ed_time = any(SELECT Ed_time FROM Schedule_info WHERE Student_id = '" + ID + "')" +
                "order by Day asc";
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            uni_CompanionDataSet2.Tables.Add(dt);
            all_schedule.DataSource = dt;
            con.Close();
        }

        private void radioButton_matched_CheckedChanged(object sender, EventArgs e)
        {
            string query = "SELECT si.Student_id, si.Name, sc.Schedule_id, sc.Day, sc.St_time, sc.Ed_time FROM Student_info si INNER JOIN Schedule_info sc ON si.Student_id = sc.Student_id " +
                "WHERE sc.Student_id <> '" + ID + "' " +
                "AND sc.Accept_student = '' " +
                "AND sc.Day = any(SELECT Day FROM Schedule_info WHERE Student_id = '" + ID + "') " +
                "AND sc.St_time = any(SELECT St_time FROM Schedule_info WHERE Student_id = '" + ID + "') " +
                "AND sc.Ed_time = any(SELECT Ed_time FROM Schedule_info WHERE Student_id = '" + ID + "')" +
                "order by Day asc";
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            uni_CompanionDataSet2.Tables.Add(dt);
            all_schedule.DataSource = dt;
            con.Close();
        }

        private void radioButton_all_CheckedChanged(object sender, EventArgs e)
        {
            string query = "SELECT si.Student_id, si.Name, sc.Schedule_id, sc.Day, sc.Ed_time, sc.St_time FROM Student_info si INNER JOIN Schedule_info sc ON si.Student_id = sc.Student_id " +
                "WHERE sc.Student_id <> '" + ID + "' " +
                "AND sc.Accept_student ='' " +
                "order by Day asc";
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            uni_CompanionDataSet2.Tables.Add(dt);
            all_schedule.DataSource = dt;
            con.Close();
        }

        private void choose_bt_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "UPDATE Schedule_info SET Accept_student=@Accept_student " +
                    "WHERE Schedule_id=@Schedule_id";

                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2J7KK7;Initial Catalog=Uni Companion DB;Integrated Security=True"))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Accept_student", ID);
                        cmd.Parameters.AddWithValue("@Schedule_id", Convert.ToInt32(textBox_scheduleID.Text));
                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Schedule Selected successfully", "Select Schedule");
                            student_home sh = new student_home(ID);
                            this.Hide();
                            sh.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Schedule id", "Select Schedule");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ", "Modify");
            }
        }

        private void textBox_search_Click(object sender, EventArgs e)
        {
            textBox_search.Text = "";
        }

        private void labee_all_schedule_Click(object sender, EventArgs e)
        {

        }

        
        private void btnScheduleSett_Click(object sender, EventArgs e)
        {
            schedule_settings ss = new schedule_settings(ID);
            this.Hide();
            ss.Show();
        }

        private void btnRecrutment_Click(object sender, EventArgs e)
        {
            recruitment r = new recruitment(ID);
            this.Hide();
            r.Show();
        }

        private void btnFlatrent_Click(object sender, EventArgs e)
        {
            rent r = new rent(ID);
            this.Hide();
            r.Show();
        }
        


        private void btnBuySell_Click(object sender, EventArgs e)
        {
            Buy buy = new Buy(ID);
            this.Hide();
            buy.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            startPage sp = new startPage();
            this.Hide();
            sp.Show();
        }


        public bool verify(string id)
        {
            bool isFound = false;

            string query = "SELECT id FROM login WHERE id = @ID";

            using (SqlConnection con = new SqlConnection(@"Data Source=Supprio_saha;Initial Catalog=c#-project;Integrated Security=True"))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        isFound = reader.HasRows;
                    }
                }
                con.Close();
            }

            return isFound;
        }

        
        private void picSearch_Click(object sender, EventArgs e)
        {
            if (verify(textBox_search.Text) == true)
            {
                profile p = new profile(ID, "student_home", textBox_search.Text);
                this.Hide();
                p.Show();
            }
            else
            {
                MessageBox.Show("ID not found", "Search ID");
                textBox_search.Text = null;
            }
        }
    }
}
