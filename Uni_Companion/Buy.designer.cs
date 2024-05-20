
namespace Uni_Companion
{
    partial class Buy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buy));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HightoLow = new System.Windows.Forms.RadioButton();
            this.LowtoHigh = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_max = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_min = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.filterPrice = new System.Windows.Forms.PictureBox();
            this.filterType = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterType)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(141)))));
            this.label2.Location = new System.Drawing.Point(147, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(669, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome to Uni Companion Marketplace";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(141)))));
            this.label1.Location = new System.Drawing.Point(17, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "To sell products,";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.White;
            this.linkLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.Red;
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(142, 356);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(81, 17);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "click here";
            this.linkLabel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.linkLabel1_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(135)))), ((int)(((byte)(243)))));
            this.label3.Location = new System.Drawing.Point(226, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Items Up for Sell";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(135)))), ((int)(((byte)(243)))));
            this.label4.Location = new System.Drawing.Point(25, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sort By Price:";
            // 
            // HightoLow
            // 
            this.HightoLow.AutoSize = true;
            this.HightoLow.BackColor = System.Drawing.Color.White;
            this.HightoLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HightoLow.Location = new System.Drawing.Point(29, 109);
            this.HightoLow.Name = "HightoLow";
            this.HightoLow.Size = new System.Drawing.Size(120, 24);
            this.HightoLow.TabIndex = 9;
            this.HightoLow.TabStop = true;
            this.HightoLow.Text = "High to Low";
            this.HightoLow.UseVisualStyleBackColor = false;
            this.HightoLow.CheckedChanged += new System.EventHandler(this.HightoLow_CheckedChanged);
            // 
            // LowtoHigh
            // 
            this.LowtoHigh.AutoSize = true;
            this.LowtoHigh.BackColor = System.Drawing.Color.White;
            this.LowtoHigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LowtoHigh.Location = new System.Drawing.Point(29, 136);
            this.LowtoHigh.Name = "LowtoHigh";
            this.LowtoHigh.Size = new System.Drawing.Size(120, 24);
            this.LowtoHigh.TabIndex = 10;
            this.LowtoHigh.TabStop = true;
            this.LowtoHigh.Text = "Low to High";
            this.LowtoHigh.UseVisualStyleBackColor = false;
            this.LowtoHigh.CheckedChanged += new System.EventHandler(this.LowtoHigh_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(135)))), ((int)(((byte)(243)))));
            this.label5.Location = new System.Drawing.Point(25, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Filter by Price:";
            // 
            // textBox_max
            // 
            this.textBox_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_max.Location = new System.Drawing.Point(113, 192);
            this.textBox_max.Name = "textBox_max";
            this.textBox_max.Size = new System.Drawing.Size(62, 29);
            this.textBox_max.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(135)))), ((int)(((byte)(243)))));
            this.label6.Location = new System.Drawing.Point(92, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "to";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(141)))));
            this.button1.Location = new System.Drawing.Point(704, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 32);
            this.button1.TabIndex = 16;
            this.button1.Text = "Back to Dashboard";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_min
            // 
            this.textBox_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_min.Location = new System.Drawing.Point(28, 192);
            this.textBox_min.Name = "textBox_min";
            this.textBox_min.Size = new System.Drawing.Size(62, 29);
            this.textBox_min.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(141)))));
            this.label7.Location = new System.Drawing.Point(12, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(262, 22);
            this.label7.TabIndex = 18;
            this.label7.Text = "Don\'t want to buy anything?";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(231, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(618, 261);
            this.dataGridView1.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(135)))), ((int)(((byte)(243)))));
            this.label8.Location = new System.Drawing.Point(28, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 24);
            this.label8.TabIndex = 21;
            this.label8.Text = "Filter by Type:";
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
            this.comboBox_type.Location = new System.Drawing.Point(30, 254);
            this.comboBox_type.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(145, 30);
            this.comboBox_type.TabIndex = 22;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(58, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 38);
            this.button2.TabIndex = 24;
            this.button2.Text = "Filter Using price range and type";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // filterPrice
            // 
            this.filterPrice.BackColor = System.Drawing.Color.Transparent;
            this.filterPrice.Image = ((System.Drawing.Image)(resources.GetObject("filterPrice.Image")));
            this.filterPrice.Location = new System.Drawing.Point(177, 191);
            this.filterPrice.Name = "filterPrice";
            this.filterPrice.Size = new System.Drawing.Size(30, 30);
            this.filterPrice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.filterPrice.TabIndex = 25;
            this.filterPrice.TabStop = false;
            this.filterPrice.Click += new System.EventHandler(this.filterPrice_Click);
            // 
            // filterType
            // 
            this.filterType.BackColor = System.Drawing.Color.Transparent;
            this.filterType.Image = ((System.Drawing.Image)(resources.GetObject("filterType.Image")));
            this.filterType.Location = new System.Drawing.Point(178, 253);
            this.filterType.Name = "filterType";
            this.filterType.Size = new System.Drawing.Size(30, 30);
            this.filterType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.filterType.TabIndex = 26;
            this.filterType.TabStop = false;
            this.filterType.Click += new System.EventHandler(this.filterType_Click);
            // 
            // Buy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(863, 605);
            this.Controls.Add(this.filterType);
            this.Controls.Add(this.filterPrice);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox_type);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_min);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_max);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LowtoHigh);
            this.Controls.Add(this.HightoLow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(141)))));
            this.Name = "Buy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uni Companion Marketplace - Buy";
            this.Load += new System.EventHandler(this.Buy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filterType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton HightoLow;
        private System.Windows.Forms.RadioButton LowtoHigh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_max;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_min;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox filterPrice;
        private System.Windows.Forms.PictureBox filterType;
    }
}