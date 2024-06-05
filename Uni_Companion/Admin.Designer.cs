
namespace Uni_Companion
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Save_bt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton_edit = new System.Windows.Forms.RadioButton();
            this.radioButton_delete = new System.Windows.Forms.RadioButton();
            this.radioButton_owner = new System.Windows.Forms.RadioButton();
            this.radioButton_recruiter = new System.Windows.Forms.RadioButton();
            this.radioButton_student = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.back_bt = new System.Windows.Forms.Button();
            this.picSearch = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Which Info you Want to see:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(337, 107);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(603, 351);
            this.dataGridView1.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picSearch);
            this.panel1.Controls.Add(this.Save_bt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox_search);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.radioButton_edit);
            this.panel1.Controls.Add(this.radioButton_delete);
            this.panel1.Location = new System.Drawing.Point(13, 265);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 182);
            this.panel1.TabIndex = 15;
            // 
            // Save_bt
            // 
            this.Save_bt.Location = new System.Drawing.Point(212, 143);
            this.Save_bt.Margin = new System.Windows.Forms.Padding(4);
            this.Save_bt.Name = "Save_bt";
            this.Save_bt.Size = new System.Drawing.Size(80, 28);
            this.Save_bt.TabIndex = 17;
            this.Save_bt.Text = "Save";
            this.Save_bt.UseVisualStyleBackColor = true;
            this.Save_bt.Click += new System.EventHandler(this.Save_bt_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "State:";
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(99, 66);
            this.textBox_search.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(160, 22);
            this.textBox_search.TabIndex = 15;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Valid",
            "Disabled"});
            this.comboBox1.Location = new System.Drawing.Point(99, 105);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "ID:";
            // 
            // radioButton_edit
            // 
            this.radioButton_edit.AutoSize = true;
            this.radioButton_edit.Location = new System.Drawing.Point(161, 18);
            this.radioButton_edit.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_edit.Name = "radioButton_edit";
            this.radioButton_edit.Size = new System.Drawing.Size(88, 21);
            this.radioButton_edit.TabIndex = 11;
            this.radioButton_edit.TabStop = true;
            this.radioButton_edit.Text = "Edit state";
            this.radioButton_edit.UseVisualStyleBackColor = true;
            this.radioButton_edit.CheckedChanged += new System.EventHandler(this.radioButton_edit_CheckedChanged_1);
            // 
            // radioButton_delete
            // 
            this.radioButton_delete.AutoSize = true;
            this.radioButton_delete.Location = new System.Drawing.Point(59, 18);
            this.radioButton_delete.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_delete.Name = "radioButton_delete";
            this.radioButton_delete.Size = new System.Drawing.Size(70, 21);
            this.radioButton_delete.TabIndex = 10;
            this.radioButton_delete.TabStop = true;
            this.radioButton_delete.Text = "Delete";
            this.radioButton_delete.UseVisualStyleBackColor = true;
            this.radioButton_delete.CheckedChanged += new System.EventHandler(this.radioButton_delete_CheckedChanged);
            // 
            // radioButton_owner
            // 
            this.radioButton_owner.AutoSize = true;
            this.radioButton_owner.Location = new System.Drawing.Point(117, 227);
            this.radioButton_owner.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_owner.Name = "radioButton_owner";
            this.radioButton_owner.Size = new System.Drawing.Size(70, 21);
            this.radioButton_owner.TabIndex = 14;
            this.radioButton_owner.Text = "Owner";
            this.radioButton_owner.UseVisualStyleBackColor = true;
            this.radioButton_owner.CheckedChanged += new System.EventHandler(this.radioButton_owner_CheckedChanged_1);
            // 
            // radioButton_recruiter
            // 
            this.radioButton_recruiter.AutoSize = true;
            this.radioButton_recruiter.Location = new System.Drawing.Point(117, 199);
            this.radioButton_recruiter.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_recruiter.Name = "radioButton_recruiter";
            this.radioButton_recruiter.Size = new System.Drawing.Size(87, 21);
            this.radioButton_recruiter.TabIndex = 13;
            this.radioButton_recruiter.Text = "Recruiter";
            this.radioButton_recruiter.UseVisualStyleBackColor = true;
            this.radioButton_recruiter.CheckedChanged += new System.EventHandler(this.radioButton_recruiter_CheckedChanged_1);
            // 
            // radioButton_student
            // 
            this.radioButton_student.AutoSize = true;
            this.radioButton_student.Location = new System.Drawing.Point(117, 170);
            this.radioButton_student.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_student.Name = "radioButton_student";
            this.radioButton_student.Size = new System.Drawing.Size(78, 21);
            this.radioButton_student.TabIndex = 12;
            this.radioButton_student.Text = "Student";
            this.radioButton_student.UseVisualStyleBackColor = true;
            this.radioButton_student.CheckedChanged += new System.EventHandler(this.radioButton_student_CheckedChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Which Info you Want to see:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(644, 54);
            this.label1.TabIndex = 10;
            this.label1.Text = "Uni Companion Admin Panel";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(785, -17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(479, 464);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1054, 403);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(195, 184);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // back_bt
            // 
            this.back_bt.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_bt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(67)))), ((int)(((byte)(141)))));
            this.back_bt.Location = new System.Drawing.Point(1095, 13);
            this.back_bt.Margin = new System.Windows.Forms.Padding(4);
            this.back_bt.Name = "back_bt";
            this.back_bt.Size = new System.Drawing.Size(121, 41);
            this.back_bt.TabIndex = 21;
            this.back_bt.Text = "Sign Out";
            this.back_bt.UseVisualStyleBackColor = true;
            this.back_bt.Click += new System.EventHandler(this.back_bt_Click);
            // 
            // picSearch
            // 
            this.picSearch.BackColor = System.Drawing.Color.Transparent;
            this.picSearch.Image = ((System.Drawing.Image)(resources.GetObject("picSearch.Image")));
            this.picSearch.Location = new System.Drawing.Point(268, 57);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(33, 38);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSearch.TabIndex = 54;
            this.picSearch.TabStop = false;
            this.picSearch.Click += new System.EventHandler(this.picSearch_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1241, 578);
            this.Controls.Add(this.back_bt);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioButton_owner);
            this.Controls.Add(this.radioButton_recruiter);
            this.Controls.Add(this.radioButton_student);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Save_bt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton_edit;
        private System.Windows.Forms.RadioButton radioButton_delete;
        private System.Windows.Forms.RadioButton radioButton_owner;
        private System.Windows.Forms.RadioButton radioButton_recruiter;
        private System.Windows.Forms.RadioButton radioButton_student;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button back_bt;
        private System.Windows.Forms.PictureBox picSearch;
    }
}