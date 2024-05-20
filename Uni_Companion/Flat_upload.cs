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
    public partial class Flat_upload : Form
    {
        public string ID { set; get; }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2J7KK7;Initial Catalog=Uni Companion DB;Integrated Security=True");

        public Flat_upload(string id)
        {
            InitializeComponent();
            ID = id;
        }

        private void Flat_upload_Load(object sender, EventArgs e)
        {
            string query = "SELECT Flat_id, Address, Floor, No_of_room, Rent FROM Flat_info " +
                "where Owner_id = '" + ID + "' ";
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            editordelete editordelete = new editordelete(ID);
            this.Hide();
            editordelete.Show();
            this.Hide();
        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            if (textbox_address.Text != "" && textbox_floor.Text != "" && textbox_rent.Text != "" && textbox_roomNo.Text != "")
            {
                string query = "INSERT INTO Flat_info (Address, Floor, Rent, No_of_room, Owner_id) " +
                    "VALUES (@address, @floor, @rent, @no_room, @id)";

                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2J7KK7;Initial Catalog=Uni Companion DB;Integrated Security=True"))
                {
                    con.Open();

                    using (SqlCommand cmd1 = new SqlCommand(query, con))
                    {
                        cmd1.Parameters.AddWithValue("@address", textbox_address.Text);
                        cmd1.Parameters.AddWithValue("@floor", textbox_floor.Text);
                        cmd1.Parameters.AddWithValue("@rent", textbox_rent.Text);
                        cmd1.Parameters.AddWithValue("@no_room", textbox_roomNo.Text);
                        cmd1.Parameters.AddWithValue("@id", ID);

                        int result1 = cmd1.ExecuteNonQuery();

                        if (result1 > 0)
                        {
                            MessageBox.Show("Upload Apartment successful.", "Product Upload");
                        }
                    }

                    con.Close();
                }
                textbox_address.Text = "";
                textbox_floor.Text = "";
                textbox_rent.Text = "";
                textbox_roomNo.Text = "";

                Flat_upload fu = new Flat_upload(ID);
                this.Hide();
                fu.Show();
            }
            else
            {
                MessageBox.Show("Upload unsuccessfull.", "Product Upload");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            editordelete ed = new editordelete(ID);
            this.Hide();
            ed.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            startPage sp = new startPage();
            this.Hide();
            sp.Show();
        }
    }
}
