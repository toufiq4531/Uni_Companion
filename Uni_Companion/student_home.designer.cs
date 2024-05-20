
namespace Uni_Companion
{
    partial class student_home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(student_home));
            this.all_schedule = new System.Windows.Forms.DataGridView();
            this.profile_bt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.choose_bt = new System.Windows.Forms.Button();
            this.labee_all_schedule = new System.Windows.Forms.Label();
            this.uni_CompanionDataSet2 = new Uni_Companion.Uni_CompanionDataSet2();
            this.uniCompanionDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radioButton_matched = new System.Windows.Forms.RadioButton();
            this.radioButton_all = new System.Windows.Forms.RadioButton();
            this.textBox_scheduleID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnScheduleSett = new System.Windows.Forms.Button();
            this.btnRecrutment = new System.Windows.Forms.Button();
            this.btnFlatrent = new System.Windows.Forms.Button();
            this.btnBuySell = new System.Windows.Forms.Button();
            this.picSearch = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.all_schedule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uni_CompanionDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniCompanionDataSet2BindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // all_schedule
            // 
            this.all_schedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.all_schedule.Location = new System.Drawing.Point(20, 43);
            this.all_schedule.Margin = new System.Windows.Forms.Padding(4);
            this.all_schedule.Name = "all_schedule";
            this.all_schedule.RowHeadersWidth = 51;
            this.all_schedule.Size = new System.Drawing.Size(845, 320);
            this.all_schedule.TabIndex = 1;
            // 
            // profile_bt
            // 
            this.profile_bt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
            this.profile_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profile_bt.ForeColor = System.Drawing.Color.White;
            this.profile_bt.Location = new System.Drawing.Point(45, 81);
            this.profile_bt.Margin = new System.Windows.Forms.Padding(4);
            this.profile_bt.Name = "profile_bt";
            this.profile_bt.Size = new System.Drawing.Size(193, 35);
            this.profile_bt.TabIndex = 2;
            this.profile_bt.Text = "Profile";
            this.profile_bt.UseVisualStyleBackColor = false;
            this.profile_bt.Click += new System.EventHandler(this.profile_bt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(142, 376);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(552, 20);
            this.label3.TabIndex = 40;
            this.label3.Text = "Enter Schedule ID and Click \"Select\" to fix schedule with your your friend";
            // 
            // choose_bt
            // 
            this.choose_bt.Location = new System.Drawing.Point(515, 410);
            this.choose_bt.Margin = new System.Windows.Forms.Padding(4);
            this.choose_bt.Name = "choose_bt";
            this.choose_bt.Size = new System.Drawing.Size(90, 32);
            this.choose_bt.TabIndex = 12;
            this.choose_bt.Text = "Select";
            this.choose_bt.UseVisualStyleBackColor = true;
            this.choose_bt.Click += new System.EventHandler(this.choose_bt_Click);
            // 
            // labee_all_schedule
            // 
            this.labee_all_schedule.AutoSize = true;
            this.labee_all_schedule.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labee_all_schedule.ForeColor = System.Drawing.Color.White;
            this.labee_all_schedule.Location = new System.Drawing.Point(37, 8);
            this.labee_all_schedule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labee_all_schedule.Name = "labee_all_schedule";
            this.labee_all_schedule.Size = new System.Drawing.Size(203, 23);
            this.labee_all_schedule.TabIndex = 11;
            this.labee_all_schedule.Text = "Recomended Schedules:";
            this.labee_all_schedule.Click += new System.EventHandler(this.labee_all_schedule_Click);
            // 
            // uni_CompanionDataSet2
            // 
            this.uni_CompanionDataSet2.DataSetName = "Uni_CompanionDataSet2";
            this.uni_CompanionDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uniCompanionDataSet2BindingSource
            // 
            this.uniCompanionDataSet2BindingSource.DataSource = this.uni_CompanionDataSet2;
            this.uniCompanionDataSet2BindingSource.Position = 0;
            // 
            // radioButton_matched
            // 
            this.radioButton_matched.AutoSize = true;
            this.radioButton_matched.Checked = true;
            this.radioButton_matched.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_matched.ForeColor = System.Drawing.Color.White;
            this.radioButton_matched.Location = new System.Drawing.Point(289, 7);
            this.radioButton_matched.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_matched.Name = "radioButton_matched";
            this.radioButton_matched.Size = new System.Drawing.Size(185, 27);
            this.radioButton_matched.TabIndex = 41;
            this.radioButton_matched.TabStop = true;
            this.radioButton_matched.Text = "Matched Schedules";
            this.radioButton_matched.UseVisualStyleBackColor = true;
            this.radioButton_matched.CheckedChanged += new System.EventHandler(this.radioButton_matched_CheckedChanged);
            // 
            // radioButton_all
            // 
            this.radioButton_all.AutoSize = true;
            this.radioButton_all.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_all.ForeColor = System.Drawing.Color.White;
            this.radioButton_all.Location = new System.Drawing.Point(535, 7);
            this.radioButton_all.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_all.Name = "radioButton_all";
            this.radioButton_all.Size = new System.Drawing.Size(137, 27);
            this.radioButton_all.TabIndex = 42;
            this.radioButton_all.TabStop = true;
            this.radioButton_all.Text = "All Schedules";
            this.radioButton_all.UseVisualStyleBackColor = true;
            this.radioButton_all.CheckedChanged += new System.EventHandler(this.radioButton_all_CheckedChanged);
            // 
            // textBox_scheduleID
            // 
            this.textBox_scheduleID.Location = new System.Drawing.Point(300, 410);
            this.textBox_scheduleID.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_scheduleID.Multiline = true;
            this.textBox_scheduleID.Name = "textBox_scheduleID";
            this.textBox_scheduleID.Size = new System.Drawing.Size(183, 32);
            this.textBox_scheduleID.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(153, 412);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 44;
            this.label1.Text = "Schedule ID :";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // textBox_search
            // 
            this.textBox_search.ForeColor = System.Drawing.Color.Gray;
            this.textBox_search.Location = new System.Drawing.Point(540, 28);
            this.textBox_search.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_search.Multiline = true;
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(295, 32);
            this.textBox_search.TabIndex = 49;
            this.textBox_search.Text = "Search People";
            this.textBox_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_search.Click += new System.EventHandler(this.textBox_search_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(81)))), ((int)(((byte)(83)))));
            this.panel2.Controls.Add(this.all_schedule);
            this.panel2.Controls.Add(this.textBox_scheduleID);
            this.panel2.Controls.Add(this.choose_bt);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.radioButton_all);
            this.panel2.Controls.Add(this.radioButton_matched);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labee_all_schedule);
            this.panel2.Location = new System.Drawing.Point(327, 90);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(883, 487);
            this.panel2.TabIndex = 50;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(54)))), ((int)(((byte)(85)))));
            this.panel3.Controls.Add(this.pictureBox7);
            this.panel3.Controls.Add(this.btnLogout);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.pictureBox6);
            this.panel3.Controls.Add(this.pictureBox5);
            this.panel3.Controls.Add(this.pictureBox4);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.btnDashboard);
            this.panel3.Controls.Add(this.btnScheduleSett);
            this.panel3.Controls.Add(this.btnRecrutment);
            this.panel3.Controls.Add(this.btnFlatrent);
            this.panel3.Controls.Add(this.btnBuySell);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(286, 670);
            this.panel3.TabIndex = 51;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(233, 613);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(42, 50);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 17;
            this.pictureBox7.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(210)))), ((int)(((byte)(176)))));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.Location = new System.Drawing.Point(0, 605);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(286, 65);
            this.btnLogout.TabIndex = 16;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(233, 212);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(42, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(233, 401);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(42, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 3;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(233, 337);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(42, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(233, 273);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(42, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(233, 145);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(42, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.profile_bt);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(286, 139);
            this.panel4.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(110, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(210)))), ((int)(((byte)(176)))));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDashboard.Location = new System.Drawing.Point(1, 139);
            this.btnDashboard.Margin = new System.Windows.Forms.Padding(4);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(282, 65);
            this.btnDashboard.TabIndex = 18;
            this.btnDashboard.Text = "Student Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDashboard.UseVisualStyleBackColor = true;
            // 
            // btnScheduleSett
            // 
            this.btnScheduleSett.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScheduleSett.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScheduleSett.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(210)))), ((int)(((byte)(176)))));
            this.btnScheduleSett.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnScheduleSett.Location = new System.Drawing.Point(1, 203);
            this.btnScheduleSett.Margin = new System.Windows.Forms.Padding(4);
            this.btnScheduleSett.Name = "btnScheduleSett";
            this.btnScheduleSett.Size = new System.Drawing.Size(282, 65);
            this.btnScheduleSett.TabIndex = 19;
            this.btnScheduleSett.Text = "Schedule Settings";
            this.btnScheduleSett.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnScheduleSett.UseVisualStyleBackColor = true;
            this.btnScheduleSett.Click += new System.EventHandler(this.btnScheduleSett_Click);
            // 
            // btnRecrutment
            // 
            this.btnRecrutment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecrutment.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecrutment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(210)))), ((int)(((byte)(176)))));
            this.btnRecrutment.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecrutment.Location = new System.Drawing.Point(1, 267);
            this.btnRecrutment.Margin = new System.Windows.Forms.Padding(4);
            this.btnRecrutment.Name = "btnRecrutment";
            this.btnRecrutment.Size = new System.Drawing.Size(282, 65);
            this.btnRecrutment.TabIndex = 20;
            this.btnRecrutment.Text = "Recruitment Offers";
            this.btnRecrutment.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRecrutment.UseVisualStyleBackColor = true;
            this.btnRecrutment.Click += new System.EventHandler(this.btnRecrutment_Click);
            // 
            // btnFlatrent
            // 
            this.btnFlatrent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlatrent.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlatrent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(210)))), ((int)(((byte)(176)))));
            this.btnFlatrent.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFlatrent.Location = new System.Drawing.Point(1, 331);
            this.btnFlatrent.Margin = new System.Windows.Forms.Padding(4);
            this.btnFlatrent.Name = "btnFlatrent";
            this.btnFlatrent.Size = new System.Drawing.Size(282, 65);
            this.btnFlatrent.TabIndex = 21;
            this.btnFlatrent.Text = "Flat for Rent";
            this.btnFlatrent.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnFlatrent.UseVisualStyleBackColor = true;
            this.btnFlatrent.Click += new System.EventHandler(this.btnFlatrent_Click);
            // 
            // btnBuySell
            // 
            this.btnBuySell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuySell.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuySell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(210)))), ((int)(((byte)(176)))));
            this.btnBuySell.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuySell.Location = new System.Drawing.Point(1, 395);
            this.btnBuySell.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuySell.Name = "btnBuySell";
            this.btnBuySell.Size = new System.Drawing.Size(282, 65);
            this.btnBuySell.TabIndex = 23;
            this.btnBuySell.Text = "Marketplace";
            this.btnBuySell.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuySell.UseVisualStyleBackColor = true;
            this.btnBuySell.Click += new System.EventHandler(this.btnBuySell_Click);
            // 
            // picSearch
            // 
            this.picSearch.BackColor = System.Drawing.Color.Transparent;
            this.picSearch.Image = ((System.Drawing.Image)(resources.GetObject("picSearch.Image")));
            this.picSearch.Location = new System.Drawing.Point(840, 23);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(46, 41);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSearch.TabIndex = 53;
            this.picSearch.TabStop = false;
            this.picSearch.Click += new System.EventHandler(this.picSearch_Click);
            // 
            // student_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1354, 670);
            this.Controls.Add(this.picSearch);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox_search);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "student_home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Dashboard";
            this.Load += new System.EventHandler(this.student_home_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.all_schedule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uni_CompanionDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniCompanionDataSet2BindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView all_schedule;
        private System.Windows.Forms.Button profile_bt;
        private System.Windows.Forms.Label labee_all_schedule;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button choose_bt;
        private System.Windows.Forms.BindingSource uniCompanionDataSet2BindingSource;
        private Uni_CompanionDataSet2 uni_CompanionDataSet2;
        private System.Windows.Forms.RadioButton radioButton_matched;
        private System.Windows.Forms.RadioButton radioButton_all;
        private System.Windows.Forms.TextBox textBox_scheduleID;
        private System.Windows.Forms.Label label1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnScheduleSett;
        private System.Windows.Forms.Button btnRecrutment;
        private System.Windows.Forms.Button btnFlatrent;
        private System.Windows.Forms.Button btnBuySell;
        private System.Windows.Forms.PictureBox picSearch;
    }
}