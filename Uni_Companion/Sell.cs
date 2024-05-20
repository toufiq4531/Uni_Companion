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
    public partial class Sell : Form
    {
        public string ID { get; set; }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2J7KK7;Initial Catalog=Uni Companion DB;Integrated Security=True");

        public Sell(string id)
        {
            InitializeComponent();
            ID = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            student_home sh = new student_home(ID);
            this.Hide();
            sh.Show();
        }

        private void add_bt_Click(object sender, EventArgs e)
        {
            if (comboBox_condition.Text != "" && comboBox_type.Text != "" && textBox_discription.Text != "" && textBox_price.Text != "" && textBox_title.Text != "")
            {

                string query = "INSERT INTO Product_info (Type, Title, Condition, Price, discription, Seller_id) VALUES (@type, @title, @condition, @price, @discription, @id)";

                using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2J7KK7;Initial Catalog=Uni Companion DB;Integrated Security=True"))
                {
                    con.Open();

                    using (SqlCommand cmd1 = new SqlCommand(query, con))
                    {
                        cmd1.Parameters.AddWithValue("@type", comboBox_type.Text);
                        cmd1.Parameters.AddWithValue("@title", textBox_title.Text);
                        cmd1.Parameters.AddWithValue("@condition", comboBox_condition.Text);
                        cmd1.Parameters.AddWithValue("@price", Convert.ToInt32(textBox_price.Text));
                        cmd1.Parameters.AddWithValue("@discription", textBox_discription.Text);
                        cmd1.Parameters.AddWithValue("@id", ID);


                        int result1 = cmd1.ExecuteNonQuery();

                        if (result1 > 0)
                        {
                            MessageBox.Show("Upload product successful", "Product Upload");
                        }
                    }

                    con.Close();
                }

                comboBox_type.Text = "";
                textBox_title.Text = "";
                comboBox_condition.Text = "";
                textBox_price.Text = "";
                textBox_discription.Text = "";
                Sell se = new Sell(ID);
                this.Hide();
                se.Show();
            }
            else
            {
                MessageBox.Show("Upload failed. Incorrect data input.", "Upload");
            }
        }

        private void textBox_discription_Click(object sender, EventArgs e)
        {
            textBox_discription.Text = "";
        }

        private void Sell_Load(object sender, EventArgs e)
        {
            radioButton_upload.Checked = true;


            string query = "select Product_id,Type,Title,Condition,Price,Discription from Product_info " +
                "WHERE seller_id = '" + ID + "' ";

            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void delete_bt_Click(object sender, EventArgs e)
        {
            try
            {
                if (edit_id.Text != string.Empty)
                {
                    string query = "DELETE FROM Product_info WHERE Product_id = " + edit_id.Text + "";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    if (con.State == ConnectionState.Open)
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Product deleted successfully");
                        Sell sh = new Sell(ID);
                        this.Hide();
                        sh.Show();
                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Id Invalid", "Error");
                }
            }
            catch
            {
                MessageBox.Show("Couldn't Delete", "Error");
            }
        }

        private void back_bt_Click(object sender, EventArgs e)
        {
            Buy b = new Buy(ID);
            this.Hide();
            b.Show();
        }

        public void update_info(string que)
        {
            string query = que;

            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2J7KK7;Initial Catalog=Uni Companion DB;Integrated Security=True"))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@data", edit_info.Text);
                    cmd.Parameters.AddWithValue("@id", edit_id.Text);
                    cmd.Parameters.AddWithValue("@r_id", ID);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Data modified successfully", "Modify");
                        Sell s = new Sell(ID);
                        this.Hide();
                        s.Show();
                    }
                    else
                    {
                        MessageBox.Show("Error has occurred", "Error");
                    }
                }
            }
        }
        public void update_price(string que)
        {
            string query = que;

            using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2J7KK7;Initial Catalog=Uni Companion DB;Integrated Security=True"))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@data", Convert.ToInt32(edit_info.Text));
                    cmd.Parameters.AddWithValue("@id", edit_id.Text);
                    cmd.Parameters.AddWithValue("@r_id", ID);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Data modified successfully", "Modify");
                        Sell s = new Sell(ID);
                        this.Hide();
                        s.Show();
                    }
                    else
                    {
                        MessageBox.Show("Error has occurred", "Error");
                    }
                }
            }
        }

        private void Edit_bt_Click_1(object sender, EventArgs e)
        {
            if (edit_id.Text != "" && edit_option.Text != "" && edit_info.Text != "")
            {
                if (edit_option.Text == "Type")
                {
                    string query = "UPDATE product_info SET Type=@data WHERE product_id=@id and seller_id=@r_id";
                    update_info(query);
                }
                else if (edit_option.Text == "Title")
                {
                    string query = "UPDATE product_info SET Title=@data WHERE product_id=@id and seller_id=@r_id";
                    update_info(query);
                }
                else if (edit_option.Text == "Condition")
                {
                    string query = "UPDATE product_info SET Condition=@data WHERE product_id=@id and seller_id=@r_id";
                    update_info(query);
                }
                else if (edit_option.Text == "Price")
                {
                    string query = "UPDATE product_info SET Price=@data WHERE product_id=@id and seller_id=@r_id";
                    update_price(query);
                }
                else if (edit_option.Text == "Discription")
                {
                    string query = "UPDATE product_info SET Discription=@data WHERE product_id=@id and seller_id=@r_id";
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            edit_option.Enabled = false;
            edit_info.Enabled = false;
            Edit_bt.Hide();
            delete_bt.Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            edit_option.Enabled = true;
            edit_info.Enabled = true;
            Edit_bt.Show();
            delete_bt.Hide();
        }

        private void radioButton_upload_CheckedChanged(object sender, EventArgs e)
        {
            panel3.Enabled = false;
            panel3.Hide();
            panel1.Enabled = true;
            panel1.Show();
            groupBox1.Enabled = false;
        }

        private void radioButton_custize_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            panel1.Hide();
            panel3.Enabled = true;
            panel3.Show();
            groupBox1.Enabled = false;
        }




        private void textBox_discription_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_title_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_condition_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        
    }
}
