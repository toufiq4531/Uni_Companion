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
using System.Net;
using System.Net.Mail;
//using System.Threading.Tasks;

namespace Uni_Companion
{
    public partial class forgetPass : Form
    {
        public string ID { set; get; }
        public string Code { set; get; }
        public string Email { set; get; }
        public string Name { set; get; }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2J7KK7;Initial Catalog=Uni Companion DB;Integrated Security=True");


        public forgetPass(string id )
        {
            InitializeComponent();
            ID = id;
            groupBox2.Enabled = false;
            random_code();
        }

        public void random_code()
        {
            Random random = new Random();

            int fiveDigitNumber = random.Next(10000, 100000);

            Code = fiveDigitNumber.ToString();
        }

        public void send_mail()
        {
            try
            {
                string fromMail = "owensamuel470@gmail.com";
                string fromPassword = "rucquugsdshscmbx";

                MailMessage message = new MailMessage();
                message.From = new MailAddress(fromMail);
                message.Subject = "Test Mail";
                message.To.Add(new MailAddress(Email));
                message.Body = "<html><body>" +
                               Name + ", , Your recovery code is: " + Code +
                               "</body></html>";
                message.IsBodyHtml = true;

                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(fromMail, fromPassword),
                    EnableSsl = true,
                };

                smtpClient.Send(message);

                //MessageBox.Show("Mail Sent");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error sending email: {ex.Message}", "Email Error");
            }

        }

        private void forgetPass_Load(object sender, EventArgs e)
        {

            try
            {
                string query1 = "SELECT Email, Name FROM Student_info WHERE Student_id = @ID";
                string query2 = "SELECT Email, Name FROM recruiter_info WHERE recruiter_id = @ID";
                string query3 = "SELECT Email, Name FROM Owner_info WHERE Owner_id = @ID";

                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2J7KK7;Initial Catalog=Uni Companion DB;Integrated Security=True"))
                {
                    SqlCommand[] commands = new SqlCommand[]
                    {
                        new SqlCommand(query1, con),
                        new SqlCommand(query2, con),
                        new SqlCommand(query3, con)
                    };

                    foreach (var command in commands)
                    {
                        command.Parameters.AddWithValue("@ID", ID);
                    }

                    con.Open();

                    foreach (var command in commands)
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Name = reader["Name"].ToString();
                                Email = reader["Email"].ToString();
                                email.Text = Email;
                                break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Process: " + ex.Message, "Error");
            }

            send_mail();

        }

        private void next2_Click(object sender, EventArgs e)
        {
            if (r_code.Text == Code)
            {
                r_code.Text = "";
                groupBox2.Enabled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            random_code();
            send_mail();
        }

        private void save_pass_Click(object sender, EventArgs e)
        {
            if (n_pass.Text == c_pass.Text)
            {
                string query = "UPDATE login SET Password=@pass WHERE id=@u_id ";

                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2J7KK7;Initial Catalog=Uni Companion DB;Integrated Security=True"))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@pass", n_pass.Text);
                        cmd.Parameters.AddWithValue("@u_id", ID);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Password successfully recovered", "Password Recovery");
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Passwords don't matched", "Password Recovery");
                        }
                    }
                }
            }
            else
            {

            }
            Sign_In signin = new Sign_In();
            this.Hide();
            signin.Show();
        }
    }
}
