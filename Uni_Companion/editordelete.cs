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
    public partial class editordelete : Form
    {
        public string ID { set; get; }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2J7KK7;Initial Catalog=Uni Companion DB;Integrated Security=True");

        public editordelete(string id)
        {
            InitializeComponent();
            ID = id;
            radioButton1.Checked = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                if (textBox_id.Text != string.Empty)
                {
                    int flat_id = Convert.ToInt32(textBox_id.Text);
                    string query = "DELETE FROM Flat_info WHERE Flat_id = " + flat_id + "";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    if (con.State == ConnectionState.Open)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Flat offer deleted successfully");
                        editordelete ss = new editordelete(ID);
                        this.Hide();
                        ss.Show();
                    }
                    con.Close();
                    textBox_id.Text = "";
                }
                else
                {
                    MessageBox.Show("Invalide Flat ID");
                }
            }
        }

        private void editordelete_Load(object sender, EventArgs e)
        {
            string query = "SELECT Flat_id, Address, Floor, Rent, No_of_room FROM Flat_info " +
                "where Owner_id = '" + ID + "' ";
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Flat_upload fo = new Flat_upload(ID);
            this.Hide();
            fo.Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            save_bt.Hide();
            delete_bt.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            save_bt.Show();
            delete_bt.Hide();
        }

        private void save_bt_Click(object sender, EventArgs e)
        {
            if (textbox_address.Text != string.Empty && textbox_floor.Text != string.Empty && textbox_rent.Text != string.Empty && textbox_roomNo.Text != string.Empty)
            {
                string query = "UPDATE Flat_info SET Address=@address, Floor=@floor, Rent=@rent, No_of_room=@no_room " +
                    "where Flat_id='"+ Convert.ToInt32(textBox_id.Text) +"' ";

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
                            MessageBox.Show("Apartment info updated successfully.", "Product Update");
                        }
                    }

                    con.Close();
                }
                textbox_address.Text = "";
                textbox_floor.Text = "";
                textbox_rent.Text = "";
                textbox_roomNo.Text = "";
                textBox_id.Text = "";

                Flat_upload fu = new Flat_upload(ID);
                this.Hide();
                fu.Show();
            }
            else
            {
                MessageBox.Show("Update unsuccessfull.", "Product Update");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            startPage sp = new startPage();
            this.Hide();
            sp.Show();
        }
    }
}
