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
    public partial class SignUp : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2J7KK7;Initial Catalog=Uni Companion DB;Integrated Security=True");

        public SignUp()
        {
            InitializeComponent();
        }

        private void radBtnStudent_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtnStudent.Checked)
            {
                RePanel.Visible = false;
                StdPanel.Visible = true;

                textBox3.Text = "";
                textBox_com.Text = "";
                textBox_Cpass.Text = "";
                textBox_pass.Text = "";
                txtBoxContact.Text = "";
                txtBoxMail.Text = "";
                txtBoxName.Text = "";
                comboBox1.Text = "";
            }
        }

        private void radBtnRecruiter_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtnRecruiter.Checked )
            {
                RePanel.Visible = true;
                StdPanel.Visible = false;

                textBox3.Text = "";
                textBox_com.Text = "";
                textBox_Cpass.Text = "";
                textBox_pass.Text = "";
                txtBoxContact.Text = "";
                txtBoxMail.Text = "";
                txtBoxName.Text = "";
                comboBox1.Text = "";
            }
        }

        private void radBtnFlatOwner_CheckedChanged(object sender, EventArgs e)
        {
            if (radBtnFlatOwner.Checked )
            {
                RePanel.Visible = false;
                StdPanel.Visible = false;

                textBox3.Text = "";
                textBox_com.Text = "";
                textBox_Cpass.Text = "";
                textBox_pass.Text = "";
                txtBoxContact.Text = "";
                txtBoxMail.Text = "";
                txtBoxName.Text = "";
                comboBox1.Text = "";
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            startPage sp = new startPage();
            this.Hide();
            sp.Show();
        }



        public bool verify(string id)
        {
            bool isFound = false;

            string query = "SELECT Student_id FROM Student_info WHERE Student_id = @ID";

            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2J7KK7;Initial Catalog=Uni Companion DB;Integrated Security=True"))
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
            if (isFound == true)
            {
                MessageBox.Show("Same ID decteded","Error");
            }

            return isFound;
        }



        public string returnId(string query,string type)
        {
            string id="";
            string query_id = query;

            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2J7KK7;Initial Catalog=Uni Companion DB;Integrated Security=True"))
            {
                con.Open();
                using (SqlCommand cmd3 = new SqlCommand(query_id, con))
                {
                    cmd3.Parameters.AddWithValue("@email", txtBoxMail.Text);
                    using (SqlDataReader reader = cmd3.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (reader[type].GetType() == typeof(int))
                            {
                                return reader[type].ToString();
                            }
                            else
                            {
                                throw new Exception("Unexpected data type for Recruiter_id");
                            }
                        }
                    }
                }
                con.Close();
                return id;
            }
        }


        private void reg_bt_Click(object sender, EventArgs e)
        {
            if (radBtnStudent.Checked == true)
            {
                if (textBox3.Text != "" && txtBoxName.Text != "" && comboBox1.Text != "" && txtBoxMail.Text != "" && txtBoxContact.Text != "" &&
                        textBox_pass.Text != "" && textBox_Cpass.Text != "" && textBox_pass.Text == textBox_Cpass.Text && verify(textBox3.Text)==false)
                {

                    string query = "INSERT INTO Student_info (Student_id, Name, Department, Email, Contact_num) VALUES (@id, @name, @department, @email, @num)";
                    string query_log = "INSERT INTO login (id, password, status, role) VALUES (@idl, @pass, @status, @role)";

                    using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2J7KK7;Initial Catalog=Uni Companion DB;Integrated Security=True"))
                    {
                        con.Open();

                        using (SqlCommand cmd1 = new SqlCommand(query, con))
                        using (SqlCommand cmd2 = new SqlCommand(query_log, con))
                        {
                            cmd1.Parameters.AddWithValue("@id", textBox3.Text);
                            cmd1.Parameters.AddWithValue("@name", txtBoxName.Text);
                            cmd1.Parameters.AddWithValue("@department", comboBox1.Text);
                            cmd1.Parameters.AddWithValue("@email", txtBoxMail.Text);
                            cmd1.Parameters.AddWithValue("@num", txtBoxContact.Text);

                            cmd2.Parameters.AddWithValue("@idl", textBox3.Text);
                            cmd2.Parameters.AddWithValue("@pass", textBox_pass.Text);
                            cmd2.Parameters.AddWithValue("@status", "E");
                            cmd2.Parameters.AddWithValue("@role", "student");

                            int result1 = cmd1.ExecuteNonQuery();
                            int result2 = cmd2.ExecuteNonQuery();

                            if (result1 > 0 && result2 > 0)
                            {

                                MessageBox.Show("Sign Up successful", "Sign Up");
                                Sign_In s = new Sign_In();
                                this.Hide();
                                s.Show();
                            }
                        }

                        con.Close();
                    }

                    textBox3.Text = "";
                    textBox_com.Text = "";
                    textBox_Cpass.Text = "";
                    textBox_pass.Text = "";
                    txtBoxContact.Text = ""; 
                    txtBoxMail.Text = "";
                    txtBoxName.Text = "";
                    comboBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("Sign Up failed. Incorrect data input.", "Sign Up");
                }
            }
            else if (radBtnRecruiter.Checked == true)
            {
                string id;
                if (txtBoxName.Text != "" && textBox_com.Text != "" && txtBoxMail.Text != "" && txtBoxContact.Text != "" &&
                        textBox_pass.Text != "" && textBox_Cpass.Text != "" && textBox_pass.Text == textBox_Cpass.Text)
                {
                    string query = "INSERT INTO Recruiter_info (Name, Company, Email, Contact_num) VALUES (@name, @company, @email, @num)";
                    string query_log = "INSERT INTO login (id, password, status, role) VALUES (@idl, @pass, @status, @role)";
                    string query_id = "SELECT Recruiter_id FROM recruiter_info WHERE Email = @email";

                    using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2J7KK7;Initial Catalog=Uni Companion DB;Integrated Security=True"))
                    {
                        con.Open();
                        using (SqlCommand cmd1 = new SqlCommand(query, con))                    
                        {
                            cmd1.Parameters.AddWithValue("@name", txtBoxName.Text);
                            cmd1.Parameters.AddWithValue("@company", textBox_com.Text);
                            cmd1.Parameters.AddWithValue("@email", txtBoxMail.Text);
                            cmd1.Parameters.AddWithValue("@num", txtBoxContact.Text);

                                int result1 = cmd1.ExecuteNonQuery();
                            
                        }

                        id = returnId(query_id,"Recruiter_id");

                        using (SqlCommand cmd2 = new SqlCommand(query_log, con))
                        {
                            cmd2.Parameters.AddWithValue("@idl", id);
                            cmd2.Parameters.AddWithValue("@pass", textBox_pass.Text);
                            cmd2.Parameters.AddWithValue("@status", "E");
                            cmd2.Parameters.AddWithValue("@role", "recruiter");

                            int result2 = cmd2.ExecuteNonQuery();
                            if ( result2 > 0)
                            {
                                MessageBox.Show("Sign Up successful", "Sign Up");
                                Sign_In s = new Sign_In();
                                this.Hide();
                                s.Show();
                            }

                        }

                        con.Close();
                        textBox3.Text = "";
                        textBox_com.Text = "";
                        textBox_Cpass.Text = "";
                        textBox_pass.Text = "";
                        txtBoxContact.Text = "";
                        txtBoxMail.Text = "";
                        txtBoxName.Text = "";
                        comboBox1.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Sign Up failed. Incorrect data input.", "Sign Up");
                }
            }
            else if (radBtnFlatOwner.Checked == true)
            {
                string id;
                if (txtBoxName.Text != "" && txtBoxMail.Text != "" && txtBoxContact.Text != "" &&
                    textBox_pass.Text != "" && textBox_Cpass.Text != "" && textBox_pass.Text == textBox_Cpass.Text)
                {
                    string query = "INSERT INTO Owner_info (Name, Email, Contact_num) VALUES (@name, @email, @num)";
                    string query_log = "INSERT INTO login (id, password, status, role) VALUES (@idl, @pass, @status, @role)";
                    string query_id = "SELECT Owner_id FROM Owner_info WHERE Email = @email";

                    using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2J7KK7;Initial Catalog=Uni Companion DB;Integrated Security=True"))
                    {
                        con.Open();
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@name", txtBoxName.Text);
                            cmd.Parameters.AddWithValue("@email", txtBoxMail.Text);
                            cmd.Parameters.AddWithValue("@num", txtBoxContact.Text);

                            int result = cmd.ExecuteNonQuery();
                            
                        }

                        id = returnId(query_id, "Owner_id");

                        using (SqlCommand cmd2 = new SqlCommand(query_log, con))
                        {
                            cmd2.Parameters.AddWithValue("@idl", id);
                            cmd2.Parameters.AddWithValue("@pass", textBox_pass.Text);
                            cmd2.Parameters.AddWithValue("@status", "E");
                            cmd2.Parameters.AddWithValue("@role", "owner");

                            int result2 = cmd2.ExecuteNonQuery();
                            if (result2 > 0)
                            {
                                MessageBox.Show("Sign Up successful", "Sign Up");
                                Sign_In s = new Sign_In();
                                this.Hide();
                                s.Show();
                            }

                        }
                    }
                    con.Close();
                    textBox3.Text = "";
                    textBox_com.Text = "";
                    textBox_Cpass.Text = "";
                    textBox_pass.Text = "";
                    txtBoxContact.Text = "";
                    txtBoxMail.Text = "";
                    txtBoxName.Text = "";
                    comboBox1.Text = "";
                }
                else
                {
                    MessageBox.Show("Sign Up failed. Incorrect data input.", "Sign Up");
                }
            }
        }
    }
}
