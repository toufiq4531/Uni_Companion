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
    public partial class Buy : Form
    {
        public string ID { get; set; }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B2J7KK7;Initial Catalog=Uni Companion DB;Integrated Security=True");

        public Buy(string id)
        {
            InitializeComponent();
            ID = id;
        }

        

        private void linkLabel1_MouseClick(object sender, MouseEventArgs e)
        {
            Sell sell = new Sell(ID);
            this.Hide();
            sell.Show();
        }

        private void Buy_Load(object sender, EventArgs e)
        {
            string query = "select product_info.Product_id, product_info.Type, product_info.Title, Product_info.Price, Student_info.Name, Student_info.Contact_num " +
                    " from Product_info INNER JOIN Student_info ON Student_info.Student_id = Product_info.Seller_id " +
                    "where Product_info.Seller_id <> '"+ ID +"' ";
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            student_home sh = new student_home(ID);
            this.Hide();
            sh.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void HightoLow_CheckedChanged(object sender, EventArgs e)
        {
            string query = "select product_info.Product_id, product_info.Type, product_info.Title, Product_info.Price, Student_info.Name, Student_info.Contact_num " +
                    " from Product_info INNER JOIN Student_info ON Student_info.Student_id = Product_info.Seller_id " +
                    "where Product_info.Seller_id <> '" + ID + "' " +
                    " ORDER BY Product_info.Price desc";
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

            textBox_min.Text = null;
            textBox_max.Text = null;
            comboBox_type.Text = null;
        }

        private void LowtoHigh_CheckedChanged(object sender, EventArgs e)
        {
            string query = "select product_info.Product_id, product_info.Type, product_info.Title, Product_info.Price, Student_info.Name, Student_info.Contact_num " +
                    " from Product_info INNER JOIN Student_info ON Student_info.Student_id = Product_info.Seller_id " +
                    "where Product_info.Seller_id <> '" + ID + "' " +
                    " ORDER BY Product_info.Price ";
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

            textBox_min.Text = null;
            textBox_max.Text = null;
            comboBox_type.Text = null;
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            string query = "select product_info.Product_id, product_info.Type, product_info.Title, Product_info.Price, Student_info.Name, Student_info.Contact_num " +
                    " from Product_info INNER JOIN Student_info ON Student_info.Student_id = Product_info.Seller_id " +
                    "where Product_info.Seller_id <> '" + ID + "' " +
                    " and Product_info.Type = '" + comboBox_type.Text + "' " +
                    " and Price between '" + Convert.ToInt32(textBox_min.Text) + "' and '" + Convert.ToInt32(textBox_max.Text) + "' ";
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void filterPrice_Click(object sender, EventArgs e)
        {
            string query = "select product_info.Product_id, product_info.Type, product_info.Title, Product_info.Price, Student_info.Name, Student_info.Contact_num " +
                    " from Product_info INNER JOIN Student_info ON Student_info.Student_id = Product_info.Seller_id " +
                    "where Product_info.Seller_id <> '" + ID + "' " +
                    " and Price between '" + Convert.ToInt32(textBox_min.Text) + "' and '" + Convert.ToInt32(textBox_max.Text) + "' ";
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void filterType_Click(object sender, EventArgs e)
        {
            string query = "select product_info.Product_id, product_info.Type, product_info.Title, Product_info.Price, Student_info.Name, Student_info.Contact_num " +
                    " from Product_info INNER JOIN Student_info ON Student_info.Student_id = Product_info.Seller_id " +
                    "where Product_info.Seller_id <> '" + ID + "' " +
                    " and Product_info.Type = '" + comboBox_type.Text + "' ";
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
