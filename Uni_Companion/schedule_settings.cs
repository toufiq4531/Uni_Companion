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
    public partial class schedule_settings : Form
    {
        public string student_id;
        public string ID { set; get; }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2J7KK7;Initial Catalog=Uni Companion DB;Integrated Security=True");
        public SqlDataReader reader;
        public SqlCommand command = new SqlCommand();

        public schedule_settings(string id)
        {
            InitializeComponent();
            this.Text = "Schedule settings";
            groupBoxModify.Hide();
            groupBoxAdd.Show();
            groupBoxAdd.Enabled = false;
            added_schedule.Show();
            ID = id;
        }



        private void modify_bt_Click(object sender, EventArgs e)
        {
            if (radioButton_accme.Checked)
            {
                groupBoxModify.Hide();
                groupBoxAdd.Show();
                groupBoxAdd.Enabled = false;
            }
            else
            {
                groupBoxModify.Show();
                groupBoxAdd.Hide();
                groupBoxModify.Enabled = true;
                groupBoxAdd.Enabled = false;
            }
        }

        private void back_bt_Click(object sender, EventArgs e)
        {
            student_home sh = new student_home(ID);
            this.Hide();
            sh.Show();
        }


        private void add_bt_Click(object sender, EventArgs e)
        {
            groupBoxAdd.Enabled = true;
            groupBoxModify.Enabled = false;
            groupBoxModify.Hide();
            groupBoxAdd.Show();
        }


        private void add_s_bt_Click(object sender, EventArgs e)
        {
            if (comboBox_st_add.Text == string.Empty && comboBox_ed_add.Text == string.Empty && comboBox_day.Text== string.Empty)
            {
                MessageBox.Show("Select your starting/ending time/Week Day", "ERROR");
            }
            else
            {
                con.Open();
                string query = "insert into Schedule_info values('" + comboBox_day.Text + "','" + comboBox_st_add.Text + "','" + comboBox_ed_add.Text + "','" + ID + "','" + null + "')";
                SqlCommand cmd = new SqlCommand(query, con);


                if (con.State == ConnectionState.Open)
                {
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Insertion Successfull");
                        comboBox_st_add.Text="";
                        comboBox_ed_add.Text="";
                        comboBox_day.Text = "";
                        groupBoxAdd.Enabled = false;
                    }

                }
                con.Close();
                schedule_settings ss = new schedule_settings(ID);
                this.Hide();
                ss.Show();
            }
        }

        

        private void schedule_settings_Load(object sender, EventArgs e)
        {
            string query = "select Student_info.Student_id, Student_info.Name, Schedule_info.Schedule_id, Schedule_info.Day, Schedule_info.St_time, Schedule_info.Ed_time " +
                    "from Student_info INNER JOIN Schedule_info ON Student_info.Student_id = Schedule_info.Student_id" +
                    " where Schedule_info.Student_id ='" + ID + "' " +
                    "order by Schedule_info.Day asc";
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            uni_CompanionDataSet1.Tables.Add(dt);
            added_schedule.DataSource = dt;
            con.Close();

        }

        private void radioButton_addme_CheckedChanged(object sender, EventArgs e)
        {
            added_schedule.Show();
            label13.Text = "Users who accepted your Request";

            string query = "select Student_info.Student_id, Student_info.Name, Student_info.Department, " +
                    "Schedule_info.Schedule_id, Schedule_info.Day, Schedule_info.St_time, Schedule_info.Ed_time " +
                    "from Student_info INNER JOIN Schedule_info ON Student_info.Student_id = Schedule_info.Accept_Student" +
                    " where Schedule_info.Student_id ='" + ID + "' and Schedule_info.Accept_student !='" + ID + "'" +
                    "order by Schedule_info.Day asc";
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            uni_CompanionDataSet1.Tables.Add(dt);
            added_schedule.DataSource = dt;
            con.Close();
        }

        private void radioButton_accme_CheckedChanged(object sender, EventArgs e)
        {
            label13.Text = "User requests accepted by Yourself";
            groupBoxModify.Hide();
            groupBoxAdd.Show();
            groupBoxAdd.Enabled = false;
            if (radioButton_accme.Checked)
            {
                modify_bt.Enabled = false;
                add_bt.Enabled = false;
                Delete_bt.Enabled = false;
            }
            else
            {
                modify_bt.Enabled = true;
                add_bt.Enabled = true;
                Delete_bt.Enabled = true;
            }

            string query = "select Student_info.Student_id, Student_info.Name, Student_info.Department, " +
                    "Schedule_info.Schedule_id, Schedule_info.Day, Schedule_info.St_time, Schedule_info.Ed_time " +
                    "from Student_info INNER JOIN Schedule_info ON Student_info.Student_id = Schedule_info.Student_id" +
                    " where Schedule_info.Accept_student is not NULL and Schedule_info.Accept_student ='" + ID + "'" +
                    "order by Schedule_info.Day asc";
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            uni_CompanionDataSet1.Tables.Add(dt);
            added_schedule.DataSource = dt;
            con.Close();
        }

        private void groupBox_details_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox_modify_Enter(object sender, EventArgs e)
        {

        }

        private void modify_s_bt_Click(object sender, EventArgs e)
        {
            
            if(schedule_id_mod.Text==string.Empty|| comboBox_st_mod.Text == string.Empty || comboBox_ed_mod.Text == string.Empty)
            {
                MessageBox.Show("Enter schedule id, Day and starting/ending time","Error");
            }
            else
            {
                try
                {
                    string query = "UPDATE Schedule_info SET Day=@Day, St_time=@StartTime, Ed_time=@EndTime WHERE Schedule_id=@ScheduleId AND Student_id=@studentid";

                    using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2J7KK7;Initial Catalog=Uni Companion DB;Integrated Security=True"))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@Day", comboBox_day_mod.Text);
                            cmd.Parameters.AddWithValue("@StartTime", comboBox_st_mod.Text);
                            cmd.Parameters.AddWithValue("@EndTime", comboBox_ed_mod.Text);
                            cmd.Parameters.AddWithValue("@ScheduleId", schedule_id_mod.Text);
                            cmd.Parameters.AddWithValue("@studentid", ID);

                            int result = cmd.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("Data modified successfully", "Modify");
                                schedule_settings ss = new schedule_settings(ID);
                                this.Hide();
                                ss.Show();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Schedule id", "Modify");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " , "Modify");
                }

            }
        }

        private void radioButton_addAll_CheckedChanged(object sender, EventArgs e)
        {
            label13.Text = "All added Schedules";
            string query = "select Student_info.Student_id, Student_info.Name, Schedule_info.Schedule_id, Schedule_info.Day, Schedule_info.St_time, Schedule_info.Ed_time " +
                    "from Student_info INNER JOIN Schedule_info ON Student_info.Student_id = Schedule_info.Student_id" +
                    " where Schedule_info.Student_id ='" + ID + "'" +
                    "order by Schedule_info.Day asc";
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            uni_CompanionDataSet1.Tables.Add(dt);
            added_schedule.DataSource = dt;
            con.Close();
        }

        private void Delete_bt_Click(object sender, EventArgs e)
        {
            try
            {
                if (radio_remove_S.Checked == true)
                {
                    int schedule_id = Convert.ToInt32(textBox_cancelid.Text);
                    string query = "DELETE FROM Schedule_info WHERE Schedule_id = " + schedule_id + "";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    if (con.State == ConnectionState.Open)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Schedule deleted successfully");
                        schedule_settings ss = new schedule_settings(ID);
                        this.Hide();
                        ss.Show();
                    }
                    con.Close();
                }
                else if (radio_remove_p.Checked == true)
                {
                    string query = "UPDATE Schedule_info SET Accept_student=@Accept_student " +
                    "WHERE Schedule_id=@Schedule_id";

                    using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2J7KK7;Initial Catalog=Uni Companion DB;Integrated Security=True"))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@Accept_student", "");
                            cmd.Parameters.AddWithValue("@Schedule_id", Convert.ToInt32(textBox_cancelid.Text));
                            int result = cmd.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("Removed acceped user from your schedule successfully", "Remove Schedule");
                                schedule_settings ss = new schedule_settings(ID);
                                this.Hide();
                                ss.Show();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Schedule id", "Remove Schedule");
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Invalid Schedule ID");
            }
        }

        private void panelAddSchedule_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
