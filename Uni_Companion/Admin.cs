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
    public partial class Admin : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2J7KK7;Initial Catalog=Uni Companion DB;Integrated Security=True");


        public Admin()
        {
            InitializeComponent();
            radioButton_student.Checked = true;
            radioButton_delete.Checked = true;
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void radioButton_student_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton_recruiter_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton_owner_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton_edit_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Save_bt_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton_student_CheckedChanged_1(object sender, EventArgs e)
        {
            string query = "select Student_id, Name, Email, Contact_num " +
                           "from Student_info";
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void radioButton_recruiter_CheckedChanged_1(object sender, EventArgs e)
        {
            string query = "select Recruiter_id, Name, Email, Contact_num " +
                           "from Recruiter_info";
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void radioButton_owner_CheckedChanged_1(object sender, EventArgs e)
        {
            string query = "select Owner_id, Name, Email, Contact_num " +
                           "from Owner_info";
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void radioButton_delete_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
            label5.Enabled = false;
            Save_bt.Text = "Delete";
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (radioButton_student.Checked == true && textBox_search.Text != string.Empty)
            {
                try
                {
                    string query = "SELECT Student_id, Name, Email, Contact_num " +
                            "FROM Student_info " +
                            "WHERE Student_id = '" + textBox_search.Text + "' ";
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("Invalid ID", "Error");
                }

            }
            else if (radioButton_recruiter.Checked == true && textBox_search.Text != string.Empty)
            {
                try
                {
                    string query = "SELECT Recruiter_id, Name, Email, Contact_num " +
                            "FROM Recruiter_info  " +
                            "WHERE Recruiter_id = '" + int.Parse(textBox_search.Text) + "' ";
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("Invalid ID", "Error");
                }

            }

            else if (radioButton_owner.Checked == true && textBox_search.Text != string.Empty)
            {
                try
                {
                    string query = "SELECT Owner_id, Name, Email, Contact_num " +
                            "FROM Owner_info  " +
                            "WHERE Owner_id = '" + int.Parse(textBox_search.Text) + "' ";
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("Invalid ID", "Error");
                }

            }
        }

        private void radioButton_edit_CheckedChanged_1(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
            label5.Enabled = true;
            Save_bt.Text = "Edit";
        }

        private void Save_bt_Click_1(object sender, EventArgs e)
        {
            if (radioButton_delete.Checked == true && textBox_search.Text != string.Empty)
            {
                string query = "DELETE FROM login WHERE id = '" + textBox_search.Text + "'";
                string query_s = "DELETE FROM student_info WHERE Student_id = '" + textBox_search.Text + "'";
                string query_r = "DELETE FROM Recruiter_info WHERE Recruiter_id = '" + int.Parse(textBox_search.Text) + "'";
                string query_o = "DELETE FROM owner_info WHERE Owner_id = '" + int.Parse(textBox_search.Text) + "'";
                string query_p = "DELETE FROM Product_info WHERE Student_id  = '" + textBox_search.Text + "'";
                string query_f = "DELETE FROM Flat_info WHERE Owner_id  = '" + int.Parse(textBox_search.Text) + "'";
                string query_of = "DELETE FROM Offer_info WHERE Recruiter_id = '" + int.Parse(textBox_search.Text) + "'";

                if (radioButton_student.Checked == true)
                {
                    try
                    {
                        using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2J7KK7;Initial Catalog=Uni Companion DB;Integrated Security=True"))
                        {
                            con.Open();
                            try
                            {
                                using (SqlCommand cmd = new SqlCommand(query, con))
                                {
                                    cmd.ExecuteNonQuery();
                                }
                                using (SqlCommand cmd1 = new SqlCommand(query_s, con))
                                {
                                    cmd1.ExecuteNonQuery();
                                }
                                using (SqlCommand cmd2 = new SqlCommand(query_p, con))
                                {
                                    cmd2.ExecuteNonQuery();
                                }
                                MessageBox.Show("All info deleted successfully");
                                Admin ad = new Admin();
                                this.Hide();
                                ad.Show();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error executing commands: {ex.Message}");
                            }
                            finally
                            {
                                con.Close();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Database connection error: {ex.Message}");
                    }
                }
                else if (radioButton_recruiter.Checked == true)
                {
                    try
                    {
                        using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2J7KK7;Initial Catalog=Uni Companion DB;Integrated Security=True"))
                        {
                            con.Open();
                            try
                            {
                                using (SqlCommand cmd = new SqlCommand(query, con))
                                {
                                    cmd.ExecuteNonQuery();
                                }
                                using (SqlCommand cmd1 = new SqlCommand(query_r, con))
                                {
                                    cmd1.ExecuteNonQuery();
                                }
                                using (SqlCommand cmd2 = new SqlCommand(query_of, con))
                                {
                                    cmd2.ExecuteNonQuery();
                                }
                                MessageBox.Show("All info deleted successfully");
                                Admin ad = new Admin();
                                this.Hide();
                                ad.Show();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error executing commands: {ex.Message}");
                            }
                            finally
                            {
                                con.Close();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Database connection error: {ex.Message}");
                    }
                }
                else if (radioButton_owner.Checked == true)
                {
                    try
                    {
                        using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2J7KK7;Initial Catalog=Uni Companion DB;Integrated Security=True"))
                        {
                            con.Open();
                            try
                            {
                                using (SqlCommand cmd = new SqlCommand(query, con))
                                {
                                    cmd.ExecuteNonQuery();
                                }
                                using (SqlCommand cmd1 = new SqlCommand(query_o, con))
                                {
                                    cmd1.ExecuteNonQuery();
                                }
                                using (SqlCommand cmd2 = new SqlCommand(query_f, con))
                                {
                                    cmd2.ExecuteNonQuery();
                                }
                                MessageBox.Show("All info deleted successfully");
                                Admin ad = new Admin();
                                this.Hide();
                                ad.Show();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"Error executing commands: {ex.Message}");
                            }
                            finally
                            {
                                con.Close();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Database connection error: {ex.Message}");
                    }
                }


            }
            else if (radioButton_edit.Checked == true && textBox_search.Text != string.Empty && comboBox1.Text != string.Empty)
            {
                try
                {
                    string query = "UPDATE login SET Status=@status " +
                        "WHERE id=@id";

                    using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2J7KK7;Initial Catalog=Uni Companion DB;Integrated Security=True"))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@id", textBox_search.Text);
                            cmd.Parameters.AddWithValue("@status", comboBox1.Text);
                            int result = cmd.ExecuteNonQuery();
                            if (result > 0)
                            {
                                MessageBox.Show("ID status changed", "Save info");
                                Admin ad = new Admin();
                                this.Hide();
                                ad.Show();
                            }
                            else
                            {
                                MessageBox.Show("Invalid id", "Error");
                            }
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Invalid ", "Error");
                }
            }
        }

        private void back_bt_Click(object sender, EventArgs e)
        {
            startPage sp = new startPage();
            this.Hide();
            sp.Show();
        }
    }
}
