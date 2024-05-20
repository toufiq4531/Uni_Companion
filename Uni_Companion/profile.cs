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
    public partial class profile : Form
    {
        public string ID { set; get; }
        public string Type { set; get; }
        public string ID_ref { set; get; }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2J7KK7;Initial Catalog=Uni Companion DB;Integrated Security=True");

        public profile(string id, string type, string id_ref)
        {
            InitializeComponent();
            
            ID = id;
            Type = type;
            ID_ref = id_ref;
        }

        public profile(string id, string type)
        {
            InitializeComponent();
            
            ID = id;
            Type = type;
        }

        

        public void info(string id)
        {
            string query = "SELECT Student_id, Name, Department, Contact_num, Email " +
                           "FROM Student_info " +
                           "WHERE Student_id = @ID";

            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2J7KK7;Initial Catalog=Uni Companion DB;Integrated Security=True"))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@ID", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            id_profile.Text = reader["Student_id"].ToString();
                            name_profile.Text = reader["Name"].ToString();
                            dept_profile.Text = reader["Department"].ToString();
                            contruct_profile.Text = reader["Contact_num"].ToString();
                            Email_profile.Text = reader["Email"].ToString();
                        }
                    }
                }

                con.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (ID_ref==null)
            {
                info(ID);
            }
            else
            {
                info(ID_ref);
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            switch (Type)
            {
                case "student_home":
                    student_home sh = new student_home(ID);
                    this.Hide();
                    sh.Show();
                    break;
                case "recruiter":
                    recruitment r1 = new recruitment(ID);
                    this.Hide();
                    r1.Show();
                    break;
                case "owner":
                    rent r = new rent(ID);
                    this.Hide();
                    r.Show();
                    break;
                default:
                    // Handle the default case if necessary
                    break;
            }
        }
    }
}
