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
    public partial class Sign_In : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2J7KK7;Initial Catalog=Uni Companion DB;Integrated Security=True");

        public string Role{ set; get; }

        public Sign_In()
        {
            InitializeComponent();
            label_forget.Hide();
        }

        private void linkLabelSignUp_MouseClick(object sender, MouseEventArgs e)
        {
            SignUp signup = new SignUp();
            this.Hide();
            signup.Show();
        }

        public bool verify()
        {
            bool isFound = false;

            string query = "SELECT id, Password, role " +
                       "FROM login " +
                       "WHERE id = @id and Password=@pass and status='E'";

            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2J7KK7;Initial Catalog=Uni Companion DB;Integrated Security=True"))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@id", textBox_id.Text);
                    command.Parameters.AddWithValue("@pass", textBox_pass.Text);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Role = reader["role"].ToString();
                        }
                        isFound = reader.HasRows;
                    }
                }
                con.Close();
            }

            return isFound;

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox_id.Text != string.Empty && textBox_pass.Text != string.Empty)
            {
                if (verify() == true && Role == "student")
                {
                    student_home s = new student_home(textBox_id.Text);
                    this.Hide();
                    s.Show();
                }
                else if (verify() == true && Role == "recruiter")
                {
                    recruiter_offer ro = new recruiter_offer(textBox_id.Text);
                    this.Hide();
                    ro.Show();
                }
                else if(verify() == true && Role == "owner"){
                    Flat_upload fu = new Flat_upload(textBox_id.Text);
                    this.Hide();
                    fu.Show();
                }

                else if (textBox_id.Text == "admin" && textBox_pass.Text == "admin")
                {

                    Admin admin = new Admin();
                    this.Hide();
                    admin.Show();
                }
                else
                {
                    MessageBox.Show("ID or Password is incorrect", "Invalid Input");
                    label_forget.Show();
                }
            }
            
            else
            {
                MessageBox.Show("Id or Password is empty","Invalid Input");
                label_forget.Show();
            }
        }

        private void textBox_id_TextChanged(object sender, EventArgs e)
        {

        }

             


        public bool verify_only_id()
        {
            bool isFound = false;

            string query = "SELECT id" +
                       " FROM login " +
                       "WHERE id = @id ";

            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2J7KK7;Initial Catalog=Uni Companion DB;Integrated Security=True"))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@id", textBox_id.Text);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        isFound = reader.HasRows;
                    }
                }
                con.Close();
            }

            return isFound;

        }

        private void label_forget_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text != string.Empty )
            {
                if (verify_only_id() == true )
                {
                    forgetPass f = new forgetPass(textBox_id.Text);
                    f.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid ID", "Invalid Input");
                    textBox_id.Text = "";
                    textBox_pass.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Id is empty", "Invalid Input");
            }
        }

        private void passHide_Click(object sender, EventArgs e)
        {
            if (textBox_pass.UseSystemPasswordChar == true) 
            {
                textBox_pass.UseSystemPasswordChar = false;
            }

            else { textBox_pass.UseSystemPasswordChar = true; }
        }

        private void back_Click(object sender, EventArgs e)
        {
            startPage sp = new startPage();
            this.Hide();
            sp.Show();
        }
    }
}
