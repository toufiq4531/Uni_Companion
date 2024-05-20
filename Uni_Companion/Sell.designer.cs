
namespace Uni_Companion
{
    partial class Sell
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sell));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_condition = new System.Windows.Forms.ComboBox();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_discription = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.add_bt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.back_bt = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.delete_bt = new System.Windows.Forms.Button();
            this.edit_info = new System.Windows.Forms.TextBox();
            this.edit_option = new System.Windows.Forms.ComboBox();
            this.edit_id = new System.Windows.Forms.TextBox();
            this.Edit_bt = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton_upload = new System.Windows.Forms.RadioButton();
            this.radioButton_custize = new System.Windows.Forms.RadioButton();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(141)))));
            this.label3.Location = new System.Drawing.Point(516, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Your Uploads";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(45)))), ((int)(((byte)(39)))));
            this.label2.Location = new System.Drawing.Point(189, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(669, 38);
            this.label2.TabIndex = 9;
            this.label2.Text = "Welcome to Uni Companion Marketplace";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(141)))));
            this.button1.Location = new System.Drawing.Point(923, 21);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 32);
            this.button1.TabIndex = 17;
            this.button1.Text = "Back to Dashboard";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(141)))));
            this.label1.Location = new System.Drawing.Point(81, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Product Type:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox_type
            // 
            this.comboBox_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Items.AddRange(new object[] {
            "Furniture",
            "Home Appliance",
            "Electronics",
            "Laptop",
            "Computer",
            "Mobile"});
            this.comboBox_type.Location = new System.Drawing.Point(228, 32);
            this.comboBox_type.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(247, 30);
            this.comboBox_type.TabIndex = 19;
            this.comboBox_type.SelectedIndexChanged += new System.EventHandler(this.comboBox_type_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(141)))));
            this.label4.Location = new System.Drawing.Point(84, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Product Title:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox_title
            // 
            this.textBox_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_title.Location = new System.Drawing.Point(228, 70);
            this.textBox_title.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(248, 28);
            this.textBox_title.TabIndex = 21;
            this.textBox_title.TextChanged += new System.EventHandler(this.textBox_title_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(141)))));
            this.label5.Location = new System.Drawing.Point(45, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 18);
            this.label5.TabIndex = 22;
            this.label5.Text = "Product Condition:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(141)))));
            this.label6.Location = new System.Drawing.Point(148, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 18);
            this.label6.TabIndex = 24;
            this.label6.Text = "Price:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // comboBox_condition
            // 
            this.comboBox_condition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_condition.FormattingEnabled = true;
            this.comboBox_condition.Items.AddRange(new object[] {
            "New",
            "Used - Like New",
            "Used - Fair Condition"});
            this.comboBox_condition.Location = new System.Drawing.Point(228, 106);
            this.comboBox_condition.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_condition.Name = "comboBox_condition";
            this.comboBox_condition.Size = new System.Drawing.Size(247, 30);
            this.comboBox_condition.TabIndex = 25;
            this.comboBox_condition.SelectedIndexChanged += new System.EventHandler(this.comboBox_condition_SelectedIndexChanged);
            // 
            // textBox_price
            // 
            this.textBox_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_price.Location = new System.Drawing.Point(228, 146);
            this.textBox_price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(203, 28);
            this.textBox_price.TabIndex = 26;
            this.textBox_price.TextChanged += new System.EventHandler(this.textBox_price_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(141)))));
            this.label7.Location = new System.Drawing.Point(40, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 18);
            this.label7.TabIndex = 27;
            this.label7.Text = "Product Discription";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // textBox_discription
            // 
            this.textBox_discription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_discription.Location = new System.Drawing.Point(228, 190);
            this.textBox_discription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_discription.Multiline = true;
            this.textBox_discription.Name = "textBox_discription";
            this.textBox_discription.Size = new System.Drawing.Size(248, 75);
            this.textBox_discription.TabIndex = 28;
            this.textBox_discription.Text = "Write between 50 Character";
            this.textBox_discription.Click += new System.EventHandler(this.textBox_discription_Click);
            this.textBox_discription.TextChanged += new System.EventHandler(this.textBox_discription_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(520, 100);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(565, 308);
            this.dataGridView1.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(141)))));
            this.label8.Location = new System.Drawing.Point(437, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 24);
            this.label8.TabIndex = 30;
            this.label8.Text = "TK";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // add_bt
            // 
            this.add_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_bt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.add_bt.Location = new System.Drawing.Point(381, 286);
            this.add_bt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.add_bt.Name = "add_bt";
            this.add_bt.Size = new System.Drawing.Size(96, 32);
            this.add_bt.TabIndex = 31;
            this.add_bt.Text = "Upload";
            this.add_bt.UseVisualStyleBackColor = true;
            this.add_bt.Click += new System.EventHandler(this.add_bt_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.add_bt);
            this.panel1.Controls.Add(this.textBox_discription);
            this.panel1.Controls.Add(this.textBox_title);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox_type);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox_price);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboBox_condition);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(15, 98);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 318);
            this.panel1.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Firebrick;
            this.label11.Location = new System.Drawing.Point(85, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(325, 22);
            this.label11.TabIndex = 30;
            this.label11.Text = "Insert product id and press \" Delete \"";
            // 
            // back_bt
            // 
            this.back_bt.BackColor = System.Drawing.Color.White;
            this.back_bt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_bt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(141)))));
            this.back_bt.Location = new System.Drawing.Point(31, 20);
            this.back_bt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.back_bt.Name = "back_bt";
            this.back_bt.Size = new System.Drawing.Size(84, 32);
            this.back_bt.TabIndex = 33;
            this.back_bt.Text = "BACK";
            this.back_bt.UseVisualStyleBackColor = false;
            this.back_bt.Click += new System.EventHandler(this.back_bt_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.radioButton2);
            this.panel3.Controls.Add(this.radioButton1);
            this.panel3.Location = new System.Drawing.Point(15, 98);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(496, 318);
            this.panel3.TabIndex = 34;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.delete_bt);
            this.groupBox1.Controls.Add(this.edit_info);
            this.groupBox1.Controls.Add(this.edit_option);
            this.groupBox1.Controls.Add(this.edit_id);
            this.groupBox1.Controls.Add(this.Edit_bt);
            this.groupBox1.Location = new System.Drawing.Point(16, 106);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(467, 203);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(141)))));
            this.label14.Location = new System.Drawing.Point(56, 95);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 18);
            this.label14.TabIndex = 47;
            this.label14.Text = "Edit Info";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(141)))));
            this.label12.Location = new System.Drawing.Point(23, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 18);
            this.label12.TabIndex = 46;
            this.label12.Text = "Edit Options";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(141)))));
            this.label9.Location = new System.Drawing.Point(37, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 18);
            this.label9.TabIndex = 44;
            this.label9.Text = "Product ID";
            // 
            // delete_bt
            // 
            this.delete_bt.Location = new System.Drawing.Point(372, 17);
            this.delete_bt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.delete_bt.Name = "delete_bt";
            this.delete_bt.Size = new System.Drawing.Size(71, 32);
            this.delete_bt.TabIndex = 45;
            this.delete_bt.Text = "Delete";
            this.delete_bt.UseVisualStyleBackColor = true;
            // 
            // edit_info
            // 
            this.edit_info.Location = new System.Drawing.Point(151, 95);
            this.edit_info.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edit_info.Multiline = true;
            this.edit_info.Name = "edit_info";
            this.edit_info.Size = new System.Drawing.Size(213, 59);
            this.edit_info.TabIndex = 43;
            // 
            // edit_option
            // 
            this.edit_option.FormattingEnabled = true;
            this.edit_option.Items.AddRange(new object[] {
            "Type",
            "Title",
            "Condition",
            "Price",
            "Discription"});
            this.edit_option.Location = new System.Drawing.Point(151, 57);
            this.edit_option.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edit_option.Name = "edit_option";
            this.edit_option.Size = new System.Drawing.Size(213, 24);
            this.edit_option.TabIndex = 41;
            // 
            // edit_id
            // 
            this.edit_id.Location = new System.Drawing.Point(151, 22);
            this.edit_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.edit_id.Name = "edit_id";
            this.edit_id.Size = new System.Drawing.Size(213, 22);
            this.edit_id.TabIndex = 42;
            // 
            // Edit_bt
            // 
            this.Edit_bt.BackColor = System.Drawing.Color.White;
            this.Edit_bt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Edit_bt.Location = new System.Drawing.Point(353, 165);
            this.Edit_bt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Edit_bt.Name = "Edit_bt";
            this.Edit_bt.Size = new System.Drawing.Size(89, 31);
            this.Edit_bt.TabIndex = 40;
            this.Edit_bt.Text = "Edit";
            this.Edit_bt.UseVisualStyleBackColor = false;
            this.Edit_bt.Click += new System.EventHandler(this.Edit_bt_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(141)))));
            this.label10.Location = new System.Drawing.Point(77, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 18);
            this.label10.TabIndex = 40;
            this.label10.Text = "Options";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(141)))));
            this.radioButton2.Location = new System.Drawing.Point(283, 71);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 22);
            this.radioButton2.TabIndex = 37;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Edit";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(141)))));
            this.radioButton1.Location = new System.Drawing.Point(173, 71);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(77, 22);
            this.radioButton1.TabIndex = 36;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Delete";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton_upload
            // 
            this.radioButton_upload.AutoSize = true;
            this.radioButton_upload.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_upload.Location = new System.Drawing.Point(244, 75);
            this.radioButton_upload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_upload.Name = "radioButton_upload";
            this.radioButton_upload.Size = new System.Drawing.Size(74, 21);
            this.radioButton_upload.TabIndex = 38;
            this.radioButton_upload.TabStop = true;
            this.radioButton_upload.Text = "Upload";
            this.radioButton_upload.UseVisualStyleBackColor = false;
            this.radioButton_upload.CheckedChanged += new System.EventHandler(this.radioButton_upload_CheckedChanged);
            // 
            // radioButton_custize
            // 
            this.radioButton_custize.AutoSize = true;
            this.radioButton_custize.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_custize.Location = new System.Drawing.Point(356, 75);
            this.radioButton_custize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_custize.Name = "radioButton_custize";
            this.radioButton_custize.Size = new System.Drawing.Size(94, 21);
            this.radioButton_custize.TabIndex = 39;
            this.radioButton_custize.TabStop = true;
            this.radioButton_custize.Text = "Customize";
            this.radioButton_custize.UseVisualStyleBackColor = false;
            this.radioButton_custize.CheckedChanged += new System.EventHandler(this.radioButton_custize_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(141)))));
            this.label16.Location = new System.Drawing.Point(11, 71);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(206, 25);
            this.label16.TabIndex = 33;
            this.label16.Text = "Choose your action:";
            // 
            // Sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1142, 679);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.radioButton_custize);
            this.Controls.Add(this.radioButton_upload);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.back_bt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Sell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uni Companion marketplace - Sell";
            this.Load += new System.EventHandler(this.Sell_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_condition;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_discription;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button add_bt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button back_bt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radioButton_upload;
        private System.Windows.Forms.RadioButton radioButton_custize;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button delete_bt;
        private System.Windows.Forms.TextBox edit_info;
        private System.Windows.Forms.ComboBox edit_option;
        private System.Windows.Forms.TextBox edit_id;
        private System.Windows.Forms.Button Edit_bt;
    }
}