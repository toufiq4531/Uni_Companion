
namespace Uni_Companion
{
    partial class schedule_settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(schedule_settings));
            this.added_schedule = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.add_bt = new System.Windows.Forms.Button();
            this.modify_bt = new System.Windows.Forms.Button();
            this.Delete_bt = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radio_remove_p = new System.Windows.Forms.RadioButton();
            this.radio_remove_S = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_cancelid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panelAddSchedule = new System.Windows.Forms.Panel();
            this.comboBox_day = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.add_s_bt = new System.Windows.Forms.Button();
            this.comboBox_ed_add = new System.Windows.Forms.ComboBox();
            this.comboBox_st_add = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.back_bt = new System.Windows.Forms.Button();
            this.radioButton_addme = new System.Windows.Forms.RadioButton();
            this.radioButton_accme = new System.Windows.Forms.RadioButton();
            this.scheduleinfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.uni_CompanionDataSet1 = new Uni_Companion.Uni_CompanionDataSet1();
            this.uni_CompanionDataSet = new Uni_Companion.Uni_CompanionDataSet();
            this.scheduleinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.schedule_infoTableAdapter = new Uni_Companion.Uni_CompanionDataSetTableAdapters.Schedule_infoTableAdapter();
            this.schedule_infoTableAdapter1 = new Uni_Companion.Uni_CompanionDataSet1TableAdapters.Schedule_infoTableAdapter();
            this.label13 = new System.Windows.Forms.Label();
            this.radioButton_addAll = new System.Windows.Forms.RadioButton();
            this.panelModify = new System.Windows.Forms.Panel();
            this.comboBox_day_mod = new System.Windows.Forms.ComboBox();
            this.schedule_id_mod = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.modify_s_bt = new System.Windows.Forms.Button();
            this.comboBox_ed_mod = new System.Windows.Forms.ComboBox();
            this.comboBox_st_mod = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.groupBoxModify = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.schedulesettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.added_schedule)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelAddSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleinfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uni_CompanionDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uni_CompanionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleinfoBindingSource)).BeginInit();
            this.panelModify.SuspendLayout();
            this.groupBoxAdd.SuspendLayout();
            this.groupBoxModify.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulesettingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // added_schedule
            // 
            this.added_schedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.added_schedule.Location = new System.Drawing.Point(60, 176);
            this.added_schedule.Margin = new System.Windows.Forms.Padding(4);
            this.added_schedule.Name = "added_schedule";
            this.added_schedule.RowHeadersWidth = 51;
            this.added_schedule.Size = new System.Drawing.Size(872, 256);
            this.added_schedule.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, -2);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 28);
            this.label1.TabIndex = 24;
            this.label1.Text = "Schedule Modify:";
            // 
            // add_bt
            // 
            this.add_bt.Location = new System.Drawing.Point(47, 36);
            this.add_bt.Margin = new System.Windows.Forms.Padding(4);
            this.add_bt.Name = "add_bt";
            this.add_bt.Size = new System.Drawing.Size(129, 28);
            this.add_bt.TabIndex = 25;
            this.add_bt.Text = "Add schedule";
            this.add_bt.UseVisualStyleBackColor = true;
            this.add_bt.Click += new System.EventHandler(this.add_bt_Click);
            // 
            // modify_bt
            // 
            this.modify_bt.Location = new System.Drawing.Point(195, 36);
            this.modify_bt.Margin = new System.Windows.Forms.Padding(4);
            this.modify_bt.Name = "modify_bt";
            this.modify_bt.Size = new System.Drawing.Size(129, 28);
            this.modify_bt.TabIndex = 26;
            this.modify_bt.Text = "Modify schedule";
            this.modify_bt.UseVisualStyleBackColor = true;
            this.modify_bt.Click += new System.EventHandler(this.modify_bt_Click);
            // 
            // Delete_bt
            // 
            this.Delete_bt.Location = new System.Drawing.Point(236, 184);
            this.Delete_bt.Margin = new System.Windows.Forms.Padding(4);
            this.Delete_bt.Name = "Delete_bt";
            this.Delete_bt.Size = new System.Drawing.Size(87, 28);
            this.Delete_bt.TabIndex = 27;
            this.Delete_bt.Text = "Remove";
            this.Delete_bt.UseVisualStyleBackColor = true;
            this.Delete_bt.Click += new System.EventHandler(this.Delete_bt_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.radio_remove_p);
            this.panel2.Controls.Add(this.radio_remove_S);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.textBox_cancelid);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.add_bt);
            this.panel2.Controls.Add(this.Delete_bt);
            this.panel2.Controls.Add(this.modify_bt);
            this.panel2.Location = new System.Drawing.Point(45, 456);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 235);
            this.panel2.TabIndex = 29;
            // 
            // radio_remove_p
            // 
            this.radio_remove_p.AutoSize = true;
            this.radio_remove_p.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_remove_p.Location = new System.Drawing.Point(198, 145);
            this.radio_remove_p.Margin = new System.Windows.Forms.Padding(4);
            this.radio_remove_p.Name = "radio_remove_p";
            this.radio_remove_p.Size = new System.Drawing.Size(207, 24);
            this.radio_remove_p.TabIndex = 39;
            this.radio_remove_p.TabStop = true;
            this.radio_remove_p.Text = "Remove Accepted Person";
            this.radio_remove_p.UseVisualStyleBackColor = true;
            // 
            // radio_remove_S
            // 
            this.radio_remove_S.AutoSize = true;
            this.radio_remove_S.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_remove_S.Location = new System.Drawing.Point(31, 145);
            this.radio_remove_S.Margin = new System.Windows.Forms.Padding(4);
            this.radio_remove_S.Name = "radio_remove_S";
            this.radio_remove_S.Size = new System.Drawing.Size(152, 24);
            this.radio_remove_S.TabIndex = 38;
            this.radio_remove_S.TabStop = true;
            this.radio_remove_S.Text = "Remove schedule";
            this.radio_remove_S.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(23, 108);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(411, 23);
            this.label14.TabIndex = 38;
            this.label14.Text = "Enter the \"Schedule ID\" and press \"Cancel Schedule\"";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(46, 185);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 23);
            this.label10.TabIndex = 36;
            this.label10.Text = "ID:";
            // 
            // textBox_cancelid
            // 
            this.textBox_cancelid.Location = new System.Drawing.Point(83, 187);
            this.textBox_cancelid.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_cancelid.Name = "textBox_cancelid";
            this.textBox_cancelid.Size = new System.Drawing.Size(128, 22);
            this.textBox_cancelid.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 78);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(233, 23);
            this.label6.TabIndex = 36;
            this.label6.Text = "Insert Schedule ID to Delete :";
            // 
            // panelAddSchedule
            // 
            this.panelAddSchedule.BackColor = System.Drawing.Color.Transparent;
            this.panelAddSchedule.Controls.Add(this.comboBox_day);
            this.panelAddSchedule.Controls.Add(this.label12);
            this.panelAddSchedule.Controls.Add(this.add_s_bt);
            this.panelAddSchedule.Controls.Add(this.comboBox_ed_add);
            this.panelAddSchedule.Controls.Add(this.comboBox_st_add);
            this.panelAddSchedule.Controls.Add(this.label4);
            this.panelAddSchedule.Controls.Add(this.label3);
            this.panelAddSchedule.Controls.Add(this.label2);
            this.panelAddSchedule.Location = new System.Drawing.Point(13, 22);
            this.panelAddSchedule.Margin = new System.Windows.Forms.Padding(4);
            this.panelAddSchedule.Name = "panelAddSchedule";
            this.panelAddSchedule.Size = new System.Drawing.Size(523, 207);
            this.panelAddSchedule.TabIndex = 29;
            this.panelAddSchedule.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAddSchedule_Paint);
            // 
            // comboBox_day
            // 
            this.comboBox_day.FormattingEnabled = true;
            this.comboBox_day.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday"});
            this.comboBox_day.Location = new System.Drawing.Point(201, 42);
            this.comboBox_day.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_day.Name = "comboBox_day";
            this.comboBox_day.Size = new System.Drawing.Size(154, 24);
            this.comboBox_day.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, -7);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(169, 32);
            this.label12.TabIndex = 17;
            this.label12.Text = "Add schedule";
            // 
            // add_s_bt
            // 
            this.add_s_bt.Location = new System.Drawing.Point(326, 152);
            this.add_s_bt.Margin = new System.Windows.Forms.Padding(4);
            this.add_s_bt.Name = "add_s_bt";
            this.add_s_bt.Size = new System.Drawing.Size(81, 28);
            this.add_s_bt.TabIndex = 29;
            this.add_s_bt.Text = "Add";
            this.add_s_bt.UseVisualStyleBackColor = true;
            this.add_s_bt.Click += new System.EventHandler(this.add_s_bt_Click);
            // 
            // comboBox_ed_add
            // 
            this.comboBox_ed_add.FormattingEnabled = true;
            this.comboBox_ed_add.Items.AddRange(new object[] {
            "8 AM",
            "8:30 AM",
            "9 AM",
            "9:30 AM",
            "10 AM",
            "10:30 AM",
            "11 AM",
            "11:30 AM",
            "12 PM",
            "12:30 PM",
            "1 PM",
            "1:30 PM",
            "2 PM",
            "2:30 PM",
            "3 PM",
            "3:30 PM",
            "4 PM",
            "4:30 PM",
            "5 PM",
            "5:30 PM",
            "6 PM",
            "6:30 PM",
            "7 PM"});
            this.comboBox_ed_add.Location = new System.Drawing.Point(201, 111);
            this.comboBox_ed_add.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_ed_add.Name = "comboBox_ed_add";
            this.comboBox_ed_add.Size = new System.Drawing.Size(154, 24);
            this.comboBox_ed_add.TabIndex = 35;
            // 
            // comboBox_st_add
            // 
            this.comboBox_st_add.FormattingEnabled = true;
            this.comboBox_st_add.Items.AddRange(new object[] {
            "8 AM",
            "8:30 AM",
            "9 AM",
            "9:30 AM",
            "10 AM",
            "10:30 AM",
            "11 AM",
            "11:30 AM",
            "12 PM",
            "12:30 PM",
            "1 PM",
            "1:30 PM",
            "2 PM",
            "2:30 PM",
            "3 PM",
            "3:30 PM",
            "4 PM",
            "4:30 PM",
            "5 PM",
            "5:30 PM",
            "6 PM",
            "6:30 PM",
            "7 PM"});
            this.comboBox_st_add.Location = new System.Drawing.Point(201, 77);
            this.comboBox_st_add.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_st_add.Name = "comboBox_st_add";
            this.comboBox_st_add.Size = new System.Drawing.Size(154, 24);
            this.comboBox_st_add.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 111);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 23);
            this.label4.TabIndex = 32;
            this.label4.Text = "End time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 31;
            this.label3.Text = "Start time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 30;
            this.label2.Text = "Insert Day:";
            // 
            // back_bt
            // 
            this.back_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_bt.Location = new System.Drawing.Point(16, 15);
            this.back_bt.Margin = new System.Windows.Forms.Padding(4);
            this.back_bt.Name = "back_bt";
            this.back_bt.Size = new System.Drawing.Size(76, 36);
            this.back_bt.TabIndex = 32;
            this.back_bt.Text = "Back";
            this.back_bt.UseVisualStyleBackColor = true;
            this.back_bt.Click += new System.EventHandler(this.back_bt_Click);
            // 
            // radioButton_addme
            // 
            this.radioButton_addme.AutoSize = true;
            this.radioButton_addme.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_addme.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_addme.ForeColor = System.Drawing.Color.Black;
            this.radioButton_addme.Location = new System.Drawing.Point(190, 59);
            this.radioButton_addme.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_addme.Name = "radioButton_addme";
            this.radioButton_addme.Size = new System.Drawing.Size(273, 27);
            this.radioButton_addme.TabIndex = 33;
            this.radioButton_addme.Text = "Schedules accepted by friends";
            this.radioButton_addme.UseVisualStyleBackColor = false;
            this.radioButton_addme.CheckedChanged += new System.EventHandler(this.radioButton_addme_CheckedChanged);
            // 
            // radioButton_accme
            // 
            this.radioButton_accme.AutoSize = true;
            this.radioButton_accme.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_accme.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_accme.ForeColor = System.Drawing.Color.Black;
            this.radioButton_accme.Location = new System.Drawing.Point(501, 59);
            this.radioButton_accme.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_accme.Name = "radioButton_accme";
            this.radioButton_accme.Size = new System.Drawing.Size(242, 27);
            this.radioButton_accme.TabIndex = 34;
            this.radioButton_accme.Text = "Schedules accepted by me";
            this.radioButton_accme.UseVisualStyleBackColor = false;
            this.radioButton_accme.CheckedChanged += new System.EventHandler(this.radioButton_accme_CheckedChanged);
            // 
            // scheduleinfoBindingSource1
            // 
            this.scheduleinfoBindingSource1.DataMember = "Schedule_info";
            this.scheduleinfoBindingSource1.DataSource = this.uni_CompanionDataSet1;
            // 
            // uni_CompanionDataSet1
            // 
            this.uni_CompanionDataSet1.DataSetName = "Uni_CompanionDataSet1";
            this.uni_CompanionDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uni_CompanionDataSet
            // 
            this.uni_CompanionDataSet.DataSetName = "Uni_CompanionDataSet";
            this.uni_CompanionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // scheduleinfoBindingSource
            // 
            this.scheduleinfoBindingSource.DataMember = "Schedule_info";
            this.scheduleinfoBindingSource.DataSource = this.uni_CompanionDataSet;
            // 
            // schedule_infoTableAdapter
            // 
            this.schedule_infoTableAdapter.ClearBeforeFill = true;
            // 
            // schedule_infoTableAdapter1
            // 
            this.schedule_infoTableAdapter1.ClearBeforeFill = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(54, 134);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(251, 32);
            this.label13.TabIndex = 36;
            this.label13.Text = "All added Schedules:";
            // 
            // radioButton_addAll
            // 
            this.radioButton_addAll.AutoSize = true;
            this.radioButton_addAll.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_addAll.Checked = true;
            this.radioButton_addAll.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_addAll.ForeColor = System.Drawing.Color.Black;
            this.radioButton_addAll.Location = new System.Drawing.Point(386, 94);
            this.radioButton_addAll.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_addAll.Name = "radioButton_addAll";
            this.radioButton_addAll.Size = new System.Drawing.Size(183, 27);
            this.radioButton_addAll.TabIndex = 37;
            this.radioButton_addAll.TabStop = true;
            this.radioButton_addAll.Text = "All schedule added";
            this.radioButton_addAll.UseVisualStyleBackColor = false;
            this.radioButton_addAll.CheckedChanged += new System.EventHandler(this.radioButton_addAll_CheckedChanged);
            // 
            // panelModify
            // 
            this.panelModify.BackColor = System.Drawing.Color.Transparent;
            this.panelModify.Controls.Add(this.comboBox_day_mod);
            this.panelModify.Controls.Add(this.schedule_id_mod);
            this.panelModify.Controls.Add(this.label11);
            this.panelModify.Controls.Add(this.modify_s_bt);
            this.panelModify.Controls.Add(this.comboBox_ed_mod);
            this.panelModify.Controls.Add(this.comboBox_st_mod);
            this.panelModify.Controls.Add(this.label9);
            this.panelModify.Controls.Add(this.label8);
            this.panelModify.Controls.Add(this.label7);
            this.panelModify.Controls.Add(this.label5);
            this.panelModify.Location = new System.Drawing.Point(0, 0);
            this.panelModify.Margin = new System.Windows.Forms.Padding(0);
            this.panelModify.Name = "panelModify";
            this.panelModify.Size = new System.Drawing.Size(523, 222);
            this.panelModify.TabIndex = 15;
            // 
            // comboBox_day_mod
            // 
            this.comboBox_day_mod.FormattingEnabled = true;
            this.comboBox_day_mod.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday"});
            this.comboBox_day_mod.Location = new System.Drawing.Point(171, 146);
            this.comboBox_day_mod.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_day_mod.Name = "comboBox_day_mod";
            this.comboBox_day_mod.Size = new System.Drawing.Size(129, 24);
            this.comboBox_day_mod.TabIndex = 40;
            // 
            // schedule_id_mod
            // 
            this.schedule_id_mod.Location = new System.Drawing.Point(415, 147);
            this.schedule_id_mod.Margin = new System.Windows.Forms.Padding(4);
            this.schedule_id_mod.Name = "schedule_id_mod";
            this.schedule_id_mod.Size = new System.Drawing.Size(104, 22);
            this.schedule_id_mod.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(0, 9);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 32);
            this.label11.TabIndex = 16;
            this.label11.Text = "Modify Details";
            // 
            // modify_s_bt
            // 
            this.modify_s_bt.Location = new System.Drawing.Point(419, 184);
            this.modify_s_bt.Margin = new System.Windows.Forms.Padding(4);
            this.modify_s_bt.Name = "modify_s_bt";
            this.modify_s_bt.Size = new System.Drawing.Size(81, 28);
            this.modify_s_bt.TabIndex = 39;
            this.modify_s_bt.Text = "Modify";
            this.modify_s_bt.UseVisualStyleBackColor = true;
            this.modify_s_bt.Click += new System.EventHandler(this.modify_s_bt_Click);
            // 
            // comboBox_ed_mod
            // 
            this.comboBox_ed_mod.FormattingEnabled = true;
            this.comboBox_ed_mod.Items.AddRange(new object[] {
            "8 AM",
            "8:30 AM",
            "9 AM",
            "9:30 AM",
            "10 AM",
            "10:30 AM",
            "11 AM",
            "11:30 AM",
            "12 PM",
            "12:30 PM",
            "1 PM",
            "1:30 PM",
            "2 PM",
            "2:30 PM",
            "3 PM",
            "3:30 PM",
            "4 PM",
            "4:30 PM",
            "5 PM",
            "5:30 PM",
            "6 PM",
            "6:30 PM",
            "7 PM"});
            this.comboBox_ed_mod.Location = new System.Drawing.Point(171, 99);
            this.comboBox_ed_mod.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_ed_mod.Name = "comboBox_ed_mod";
            this.comboBox_ed_mod.Size = new System.Drawing.Size(129, 24);
            this.comboBox_ed_mod.TabIndex = 36;
            // 
            // comboBox_st_mod
            // 
            this.comboBox_st_mod.FormattingEnabled = true;
            this.comboBox_st_mod.Items.AddRange(new object[] {
            "8 AM",
            "8:30 AM",
            "9 AM",
            "9:30 AM",
            "10 AM",
            "10:30 AM",
            "11 AM",
            "11:30 AM",
            "12 PM",
            "12:30 PM",
            "1 PM",
            "1:30 PM",
            "2 PM",
            "2:30 PM",
            "3 PM",
            "3:30 PM",
            "4 PM",
            "4:30 PM",
            "5 PM",
            "5:30 PM",
            "6 PM",
            "6:30 PM",
            "7 PM"});
            this.comboBox_st_mod.Location = new System.Drawing.Point(171, 58);
            this.comboBox_st_mod.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_st_mod.Name = "comboBox_st_mod";
            this.comboBox_st_mod.Size = new System.Drawing.Size(129, 24);
            this.comboBox_st_mod.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 100);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 23);
            this.label9.TabIndex = 31;
            this.label9.Text = "Meeting end time:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 57);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 23);
            this.label8.TabIndex = 30;
            this.label8.Text = "Meeting start time:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 145);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 23);
            this.label7.TabIndex = 29;
            this.label7.Text = "Meeting Day:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(301, 146);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 23);
            this.label5.TabIndex = 27;
            this.label5.Text = "Schedule ID:";
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxAdd.Controls.Add(this.panelAddSchedule);
            this.groupBoxAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxAdd.Location = new System.Drawing.Point(509, 449);
            this.groupBoxAdd.Margin = new System.Windows.Forms.Padding(0);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Padding = new System.Windows.Forms.Padding(0);
            this.groupBoxAdd.Size = new System.Drawing.Size(439, 242);
            this.groupBoxAdd.TabIndex = 38;
            this.groupBoxAdd.TabStop = false;
            // 
            // groupBoxModify
            // 
            this.groupBoxModify.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxModify.Controls.Add(this.panelModify);
            this.groupBoxModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBoxModify.Location = new System.Drawing.Point(532, 457);
            this.groupBoxModify.Margin = new System.Windows.Forms.Padding(0);
            this.groupBoxModify.Name = "groupBoxModify";
            this.groupBoxModify.Padding = new System.Windows.Forms.Padding(0);
            this.groupBoxModify.Size = new System.Drawing.Size(541, 222);
            this.groupBoxModify.TabIndex = 39;
            this.groupBoxModify.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(828, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // schedulesettingsBindingSource
            // 
            this.schedulesettingsBindingSource.DataSource = typeof(Uni_Companion.schedule_settings);
            // 
            // schedule_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1066, 707);
            this.Controls.Add(this.added_schedule);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.radioButton_addAll);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.radioButton_accme);
            this.Controls.Add(this.radioButton_addme);
            this.Controls.Add(this.back_bt);
            this.Controls.Add(this.groupBoxModify);
            this.Controls.Add(this.groupBoxAdd);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "schedule_settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Schedule Settings";
            this.Load += new System.EventHandler(this.schedule_settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.added_schedule)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelAddSchedule.ResumeLayout(false);
            this.panelAddSchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleinfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uni_CompanionDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uni_CompanionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scheduleinfoBindingSource)).EndInit();
            this.panelModify.ResumeLayout(false);
            this.panelModify.PerformLayout();
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxModify.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulesettingsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView added_schedule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add_bt;
        private System.Windows.Forms.Button modify_bt;
        private System.Windows.Forms.Button Delete_bt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox_cancelid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelAddSchedule;
        private System.Windows.Forms.Button add_s_bt;
        private System.Windows.Forms.ComboBox comboBox_ed_add;
        private System.Windows.Forms.ComboBox comboBox_st_add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button back_bt;
        private System.Windows.Forms.RadioButton radioButton_addme;
        private System.Windows.Forms.RadioButton radioButton_accme;
        private System.Windows.Forms.BindingSource schedulesettingsBindingSource;
        private Uni_CompanionDataSet uni_CompanionDataSet;
        private System.Windows.Forms.BindingSource scheduleinfoBindingSource;
        private Uni_CompanionDataSetTableAdapters.Schedule_infoTableAdapter schedule_infoTableAdapter;
        private Uni_CompanionDataSet1 uni_CompanionDataSet1;
        private System.Windows.Forms.BindingSource scheduleinfoBindingSource1;
        private Uni_CompanionDataSet1TableAdapters.Schedule_infoTableAdapter schedule_infoTableAdapter1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton radioButton_addAll;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton radio_remove_p;
        private System.Windows.Forms.RadioButton radio_remove_S;
        private System.Windows.Forms.ComboBox comboBox_day;
        private System.Windows.Forms.Panel panelModify;
        private System.Windows.Forms.ComboBox comboBox_day_mod;
        private System.Windows.Forms.TextBox schedule_id_mod;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button modify_s_bt;
        private System.Windows.Forms.ComboBox comboBox_ed_mod;
        private System.Windows.Forms.ComboBox comboBox_st_mod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.GroupBox groupBoxModify;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}