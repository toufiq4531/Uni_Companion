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

namespace Uni_Companion
{
    public partial class recruiter_offer : Form
    {
        public string ID { set; get; }
        public string Name { set; get; }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2J7KK7;Initial Catalog=Uni Companion DB;Integrated Security=True");


        public recruiter_offer(string id)
        {
            InitializeComponent();
            ID = id;
            radioButton_upload.Checked = true;
            radioButton1.Checked = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string query = "SELECT Offer_id, Job_title, Preffered_department, Job_type, Salary, Location, Skill_sets FROM Offer_info " +
                "where Recruiter_id = '"+ID+"' " ;
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        
        public void collect_mail()
        {
            string query1 = "SELECT Email FROM Student_info";
            string query2= "SELECT Name FROM Recruiter_info where Recruiter_id='"+ int.Parse(ID) +"'";

            List<string> emailAddresses = new List<string>();

            using (SqlConnection connection = new SqlConnection(@"Data Source = DESKTOP - B2J7KK7; Integrated Security = True"))
            {
                connection.Open();

                using (SqlCommand command1 = new SqlCommand(query1, connection))
                using (SqlCommand command2 = new SqlCommand(query2, connection))
                {
                    using (SqlDataReader reader1 = command1.ExecuteReader())
                    {
                        while (reader1.Read())
                        {
                            string email = reader1.GetString(0);

                            emailAddresses.Add(email);
                        }
                    }
                    using (SqlDataReader reader2 = command2.ExecuteReader())
                    {
                        while (reader2.Read())
                        {
                            Name = reader2["Name"].ToString();
                        }
                    }
                }
            }
            for (int i = 0; i < emailAddresses.Count; i++)
            {
                sent_mail( emailAddresses[i] );
            }
        }
        
        public void sent_mail(string mail)
        {
            try
            {
                string fromMail = "owensamuel470@gmail.com";
                string fromPassword = "rucquugsdshscmbx";

                MailMessage message = new MailMessage();
                message.From = new MailAddress(fromMail);
                message.Subject = "Test Mail";
                message.To.Add(new MailAddress(mail));
                message.Body = "<html><body>" +
                               "A new recruitment offer has been uploaded by " +Name+"( ID:"+ID+" ). "+
                               "If you are looking for a challenging role, consider applying for the following position. "+
                               "Please, check Recruitment Offers section in Uni Companion."+
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


        private void Post_bt_Click(object sender, EventArgs e)
        {
            if (Jtitle.Text != "" && Department.Text != "" && JType.Text != "" && Salary.Text != "" && Location.Text != "" && SkillSets.Text != "")
            {

                string query = "INSERT INTO Offer_info (Job_title, Preffered_department, Job_type, Salary, Location, Skill_sets, Recruiter_id) " +
                    "VALUES (@title, @dept, @type, @salary, @location, @skill, @id)";

                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2J7KK7;Initial Catalog=Uni Companion DB;Integrated Security=True"))
                {
                    con.Open();

                    using (SqlCommand cmd1 = new SqlCommand(query, con))
                    {
                        cmd1.Parameters.AddWithValue("@title", Jtitle.Text);
                        cmd1.Parameters.AddWithValue("@dept", Department.Text);
                        cmd1.Parameters.AddWithValue("@type", JType.Text);
                        cmd1.Parameters.AddWithValue("@salary", float.Parse(Salary.Text));
                        cmd1.Parameters.AddWithValue("@location", Location.Text);
                        cmd1.Parameters.AddWithValue("@skill", SkillSets.Text);
                        cmd1.Parameters.AddWithValue("@id", ID);

                        int result1 = cmd1.ExecuteNonQuery();

                        if (result1 > 0)
                        {
                            MessageBox.Show("Upload offer successful", "Product Upload");
                        }
                    }

                    con.Close();
                }
                Jtitle.Text = "";
                Department.Text = "";
                JType.Text = "";
                Salary.Text = "";
                Location.Text = "";
                SkillSets.Text = "";

                recruiter_offer ro = new recruiter_offer(ID);
                this.Hide();
                ro.Show();

                collect_mail();
            }
            else
            {
                MessageBox.Show("Upload failed. Incorrect data input.", "Upload");
            }

        }

        public void update_info(string que)
        {
            string query = que;

            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2J7KK7;Initial Catalog=Uni Companion DB;Integrated Security=True"))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@data", edit_value.Text);
                    cmd.Parameters.AddWithValue("@id", edit_id.Text);
                    cmd.Parameters.AddWithValue("@r_id", ID);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Data modified successfully", "Modify");
                        recruiter_offer ro = new recruiter_offer(ID);
                        this.Hide();
                        ro.Show();
                    }
                    else
                    {
                        MessageBox.Show("Error has occurred", "Error");
                    }
                }
            }
        }
        public void update_salary(string que)
        {
            string query = que;

            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2J7KK7;Initial Catalog=Uni Companion DB;Integrated Security=True"))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@data", float.Parse( edit_value.Text ));
                    cmd.Parameters.AddWithValue("@id", edit_id.Text);
                    cmd.Parameters.AddWithValue("@r_id", ID);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Data modified successfully", "Modify");
                        recruiter_offer ro = new recruiter_offer(ID);
                        this.Hide();
                        ro.Show();
                    }
                    else
                    {
                        MessageBox.Show("Error has occurred", "Error");
                    }
                }
            }
        }

        private void Edit_bt_Click(object sender, EventArgs e)
        {
            if(edit_id.Text != "" && edit_option.Text != "" && edit_value.Text != "")
            {
                if (edit_option.Text == "Salary")
                {
                    string query = "UPDATE Offer_info SET salary=@data WHERE Offer_id=@id and recruiter_id=@r_id";
                    update_salary(query);
                }
                else if(edit_option.Text == "Job_title")
                {
                    string query = "UPDATE Offer_info SET Job_title=@data WHERE Offer_id=@id and recruiter_id=@r_id";
                    update_info(query);
                }
                else if (edit_option.Text == "Preffered_department")
                {
                    string query = "UPDATE Offer_info SET Preffered_department=@data WHERE Offer_id=@id and recruiter_id=@r_id";
                    update_info(query);
                }
                else if (edit_option.Text == "Job_type")
                {
                    string query = "UPDATE Offer_info SET Job_type=@data WHERE Offer_id=@id and recruiter_id=@r_id";
                    update_info(query);
                }
                else if (edit_option.Text == "Location")
                {
                    string query = "UPDATE Offer_info SET Location=@data WHERE Offer_id=@id and recruiter_id=@r_id";
                    update_info(query);
                }
                else if (edit_option.Text == "Skill_sets")
                {
                    string query = "UPDATE Offer_info SET Skill_sets=@data WHERE Offer_id=@id and recruiter_id=@r_id";
                    update_info(query);
                }
                else
                {
                    MessageBox.Show("Invalid", "Error");
                }
            }
            else
            {
                MessageBox.Show("Id Invalid", "Error");
            }
        }

        private void Delete_bt_Click(object sender, EventArgs e)
        {
            if (edit_id.Text != string.Empty)
            {
                string query = "DELETE FROM Offer_info WHERE Offer_id = " + edit_id.Text + "";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                if (con.State == ConnectionState.Open)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Offer deleted successfully","Offer List");
                    recruiter_offer ro = new recruiter_offer(ID);
                    this.Hide();
                    ro.Show();
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Id Invalid", "Error");
            }
        }

        private void radioButton_upload_CheckedChanged(object sender, EventArgs e)
        {
            panel3.Hide();
            panel1.Show();
        }

        private void radioButton_custize_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Hide();
            panel3.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            edit_option.Enabled = false;
            edit_value.Enabled = false;
            Edit_bt.Hide();
            Delete_bt.Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            edit_option.Enabled = true;
            edit_value.Enabled = true;
            Edit_bt.Show();
            Delete_bt.Hide();
        }

        private void back_bt_Click(object sender, EventArgs e)
        {
            startPage sp = new startPage();
            this.Hide();
            sp.Show();
        }
    }
}
