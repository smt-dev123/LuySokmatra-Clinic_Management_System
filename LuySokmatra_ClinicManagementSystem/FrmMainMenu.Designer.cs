namespace LuySokmatra_ClinicManagementSystem
{
    partial class FrmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMenu));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtList = new System.Windows.Forms.Label();
            this.txt_dateTime = new System.Windows.Forms.Label();
            this.btnHam = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnSetting = new FontAwesome.Sharp.IconButton();
            this.btnReport = new FontAwesome.Sharp.IconButton();
            this.btnMedicineMangement = new FontAwesome.Sharp.IconButton();
            this.btnMedicineType = new FontAwesome.Sharp.IconButton();
            this.btnPatientMangement = new FontAwesome.Sharp.IconButton();
            this.btnDoctorMangement = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.sidebarTransition = new System.Windows.Forms.Timer(this.components);
            this.dateTime = new System.Windows.Forms.Timer(this.components);
            this.frmHome1 = new LuySokmatra_ClinicManagementSystem.FrmHome();
            this.frmDoctorManagement1 = new LuySokmatra_ClinicManagementSystem.FrmDoctorManagement();
            this.frmMedicineMangement1 = new LuySokmatra_ClinicManagementSystem.FrmMedicineMangement();
            this.frmMedicineType1 = new LuySokmatra_ClinicManagementSystem.FrmMedicineType();
            this.frmPatientMangement1 = new LuySokmatra_ClinicManagementSystem.FrmPatientMangement();
            this.frmReport1 = new LuySokmatra_ClinicManagementSystem.FrmReport();
            this.frmSetting1 = new LuySokmatra_ClinicManagementSystem.FrmSetting();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            this.sidebar.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(80, 4);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(53, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(2)))), ((int)(((byte)(116)))));
            this.panel2.Controls.Add(this.txtList);
            this.panel2.Controls.Add(this.txt_dateTime);
            this.panel2.Controls.Add(this.btnHam);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1465, 57);
            this.panel2.TabIndex = 4;
            // 
            // txtList
            // 
            this.txtList.AutoSize = true;
            this.txtList.Font = new System.Drawing.Font("Khmer OS Siemreap", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtList.ForeColor = System.Drawing.Color.White;
            this.txtList.Location = new System.Drawing.Point(229, 10);
            this.txtList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtList.Name = "txtList";
            this.txtList.Size = new System.Drawing.Size(87, 38);
            this.txtList.TabIndex = 13;
            this.txtList.Text = "ទំព័រដើម";
            // 
            // txt_dateTime
            // 
            this.txt_dateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_dateTime.AutoSize = true;
            this.txt_dateTime.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dateTime.ForeColor = System.Drawing.Color.White;
            this.txt_dateTime.Location = new System.Drawing.Point(1080, 18);
            this.txt_dateTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_dateTime.Name = "txt_dateTime";
            this.txt_dateTime.Size = new System.Drawing.Size(132, 23);
            this.txt_dateTime.TabIndex = 7;
            this.txt_dateTime.Text = "Date and Time";
            // 
            // btnHam
            // 
            this.btnHam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHam.Image = ((System.Drawing.Image)(resources.GetObject("btnHam.Image")));
            this.btnHam.Location = new System.Drawing.Point(12, 13);
            this.btnHam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(31, 28);
            this.btnHam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHam.TabIndex = 6;
            this.btnHam.TabStop = false;
            this.btnHam.Click += new System.EventHandler(this.btnHam_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(5)))), ((int)(((byte)(173)))));
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 57);
            this.sidebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(237, 701);
            this.sidebar.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(5)))), ((int)(((byte)(173)))));
            this.panel4.Controls.Add(this.btnExit);
            this.panel4.Controls.Add(this.btnSetting);
            this.panel4.Controls.Add(this.btnReport);
            this.panel4.Controls.Add(this.btnMedicineMangement);
            this.panel4.Controls.Add(this.btnMedicineType);
            this.panel4.Controls.Add(this.btnPatientMangement);
            this.panel4.Controls.Add(this.btnDoctorMangement);
            this.panel4.Controls.Add(this.btnHome);
            this.panel4.Location = new System.Drawing.Point(0, 5);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(237, 831);
            this.panel4.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(5)))), ((int)(((byte)(173)))));
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Khmer OS Siemreap", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            this.btnExit.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 35;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 343);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(237, 49);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "ចាកចេញ";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(5)))), ((int)(((byte)(173)))));
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetting.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Khmer OS Siemreap", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSetting.IconChar = FontAwesome.Sharp.IconChar.Gear;
            this.btnSetting.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnSetting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSetting.IconSize = 35;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(0, 294);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnSetting.Size = new System.Drawing.Size(237, 49);
            this.btnSetting.TabIndex = 8;
            this.btnSetting.Text = "កំណត់";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(5)))), ((int)(((byte)(173)))));
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReport.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Khmer OS Siemreap", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnReport.IconChar = FontAwesome.Sharp.IconChar.FileEdit;
            this.btnReport.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReport.IconSize = 35;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(0, 245);
            this.btnReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnReport.Size = new System.Drawing.Size(237, 49);
            this.btnReport.TabIndex = 7;
            this.btnReport.Text = "របាយការណ៍";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnMedicineMangement
            // 
            this.btnMedicineMangement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(5)))), ((int)(((byte)(173)))));
            this.btnMedicineMangement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedicineMangement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMedicineMangement.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnMedicineMangement.FlatAppearance.BorderSize = 0;
            this.btnMedicineMangement.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.btnMedicineMangement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicineMangement.Font = new System.Drawing.Font("Khmer OS Siemreap", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicineMangement.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMedicineMangement.IconChar = FontAwesome.Sharp.IconChar.Capsules;
            this.btnMedicineMangement.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnMedicineMangement.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMedicineMangement.IconSize = 35;
            this.btnMedicineMangement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedicineMangement.Location = new System.Drawing.Point(0, 196);
            this.btnMedicineMangement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMedicineMangement.Name = "btnMedicineMangement";
            this.btnMedicineMangement.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnMedicineMangement.Size = new System.Drawing.Size(237, 49);
            this.btnMedicineMangement.TabIndex = 6;
            this.btnMedicineMangement.Text = "គ្រប់គ្រងថ្នាំពេទ្យ";
            this.btnMedicineMangement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedicineMangement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMedicineMangement.UseVisualStyleBackColor = false;
            this.btnMedicineMangement.Click += new System.EventHandler(this.btnMedicineMangement_Click);
            // 
            // btnMedicineType
            // 
            this.btnMedicineType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(5)))), ((int)(((byte)(173)))));
            this.btnMedicineType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedicineType.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMedicineType.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnMedicineType.FlatAppearance.BorderSize = 0;
            this.btnMedicineType.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.btnMedicineType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicineType.Font = new System.Drawing.Font("Khmer OS Siemreap", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicineType.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMedicineType.IconChar = FontAwesome.Sharp.IconChar.Pills;
            this.btnMedicineType.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnMedicineType.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMedicineType.IconSize = 35;
            this.btnMedicineType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedicineType.Location = new System.Drawing.Point(0, 147);
            this.btnMedicineType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMedicineType.Name = "btnMedicineType";
            this.btnMedicineType.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnMedicineType.Size = new System.Drawing.Size(237, 49);
            this.btnMedicineType.TabIndex = 5;
            this.btnMedicineType.Text = "គ្រប់គ្រងប្រភេទថ្នាំ";
            this.btnMedicineType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedicineType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMedicineType.UseVisualStyleBackColor = false;
            this.btnMedicineType.Click += new System.EventHandler(this.btnMedicineType_Click);
            // 
            // btnPatientMangement
            // 
            this.btnPatientMangement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(5)))), ((int)(((byte)(173)))));
            this.btnPatientMangement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPatientMangement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPatientMangement.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnPatientMangement.FlatAppearance.BorderSize = 0;
            this.btnPatientMangement.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.btnPatientMangement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientMangement.Font = new System.Drawing.Font("Khmer OS Siemreap", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientMangement.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPatientMangement.IconChar = FontAwesome.Sharp.IconChar.HospitalUser;
            this.btnPatientMangement.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnPatientMangement.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPatientMangement.IconSize = 35;
            this.btnPatientMangement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPatientMangement.Location = new System.Drawing.Point(0, 98);
            this.btnPatientMangement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPatientMangement.Name = "btnPatientMangement";
            this.btnPatientMangement.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnPatientMangement.Size = new System.Drawing.Size(237, 49);
            this.btnPatientMangement.TabIndex = 4;
            this.btnPatientMangement.Text = "គ្រប់គ្រងអ្នកជំងឺ";
            this.btnPatientMangement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPatientMangement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPatientMangement.UseVisualStyleBackColor = false;
            this.btnPatientMangement.Click += new System.EventHandler(this.btnPatientMangement_Click);
            // 
            // btnDoctorMangement
            // 
            this.btnDoctorMangement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(5)))), ((int)(((byte)(173)))));
            this.btnDoctorMangement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoctorMangement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoctorMangement.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnDoctorMangement.FlatAppearance.BorderSize = 0;
            this.btnDoctorMangement.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.btnDoctorMangement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctorMangement.Font = new System.Drawing.Font("Khmer OS Siemreap", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctorMangement.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDoctorMangement.IconChar = FontAwesome.Sharp.IconChar.UserMd;
            this.btnDoctorMangement.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnDoctorMangement.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDoctorMangement.IconSize = 35;
            this.btnDoctorMangement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoctorMangement.Location = new System.Drawing.Point(0, 49);
            this.btnDoctorMangement.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDoctorMangement.Name = "btnDoctorMangement";
            this.btnDoctorMangement.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnDoctorMangement.Size = new System.Drawing.Size(237, 49);
            this.btnDoctorMangement.TabIndex = 3;
            this.btnDoctorMangement.Text = "គ្រប់គ្រងគ្រូពេទ្យ";
            this.btnDoctorMangement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoctorMangement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDoctorMangement.UseVisualStyleBackColor = false;
            this.btnDoctorMangement.Click += new System.EventHandler(this.btnDoctorMangement_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(5)))), ((int)(((byte)(173)))));
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.CheckedBackColor = System.Drawing.Color.Blue;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Khmer OS Siemreap", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnHome.IconColor = System.Drawing.Color.WhiteSmoke;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 35;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(237, 49);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "ទំព័រដើម";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // sidebarTransition
            // 
            this.sidebarTransition.Interval = 1;
            this.sidebarTransition.Tick += new System.EventHandler(this.sidebarTransition_Tick);
            // 
            // dateTime
            // 
            this.dateTime.Enabled = true;
            this.dateTime.Tick += new System.EventHandler(this.dateTime_Tick);
            // 
            // frmHome1
            // 
            this.frmHome1.BackColor = System.Drawing.Color.White;
            this.frmHome1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmHome1.Location = new System.Drawing.Point(237, 57);
            this.frmHome1.Margin = new System.Windows.Forms.Padding(1);
            this.frmHome1.Name = "frmHome1";
            this.frmHome1.Size = new System.Drawing.Size(1228, 701);
            this.frmHome1.TabIndex = 12;
            // 
            // frmDoctorManagement1
            // 
            this.frmDoctorManagement1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmDoctorManagement1.Location = new System.Drawing.Point(237, 57);
            this.frmDoctorManagement1.Margin = new System.Windows.Forms.Padding(1);
            this.frmDoctorManagement1.Name = "frmDoctorManagement1";
            this.frmDoctorManagement1.Size = new System.Drawing.Size(1228, 701);
            this.frmDoctorManagement1.TabIndex = 11;
            // 
            // frmMedicineMangement1
            // 
            this.frmMedicineMangement1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmMedicineMangement1.Location = new System.Drawing.Point(237, 57);
            this.frmMedicineMangement1.Margin = new System.Windows.Forms.Padding(1);
            this.frmMedicineMangement1.Name = "frmMedicineMangement1";
            this.frmMedicineMangement1.Size = new System.Drawing.Size(1228, 701);
            this.frmMedicineMangement1.TabIndex = 10;
            // 
            // frmMedicineType1
            // 
            this.frmMedicineType1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmMedicineType1.Location = new System.Drawing.Point(237, 57);
            this.frmMedicineType1.Margin = new System.Windows.Forms.Padding(1);
            this.frmMedicineType1.Name = "frmMedicineType1";
            this.frmMedicineType1.Size = new System.Drawing.Size(1228, 701);
            this.frmMedicineType1.TabIndex = 9;
            // 
            // frmPatientMangement1
            // 
            this.frmPatientMangement1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.frmPatientMangement1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmPatientMangement1.Location = new System.Drawing.Point(237, 57);
            this.frmPatientMangement1.Margin = new System.Windows.Forms.Padding(1);
            this.frmPatientMangement1.Name = "frmPatientMangement1";
            this.frmPatientMangement1.Size = new System.Drawing.Size(1228, 701);
            this.frmPatientMangement1.TabIndex = 8;
            // 
            // frmReport1
            // 
            this.frmReport1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmReport1.Location = new System.Drawing.Point(237, 57);
            this.frmReport1.Margin = new System.Windows.Forms.Padding(1);
            this.frmReport1.Name = "frmReport1";
            this.frmReport1.Size = new System.Drawing.Size(1228, 701);
            this.frmReport1.TabIndex = 7;
            // 
            // frmSetting1
            // 
            this.frmSetting1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frmSetting1.Location = new System.Drawing.Point(237, 57);
            this.frmSetting1.Margin = new System.Windows.Forms.Padding(1);
            this.frmSetting1.Name = "frmSetting1";
            this.frmSetting1.Size = new System.Drawing.Size(1228, 701);
            this.frmSetting1.TabIndex = 6;
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1465, 758);
            this.Controls.Add(this.frmHome1);
            this.Controls.Add(this.frmDoctorManagement1);
            this.Controls.Add(this.frmMedicineMangement1);
            this.Controls.Add(this.frmMedicineType1);
            this.Controls.Add(this.frmPatientMangement1);
            this.Controls.Add(this.frmReport1);
            this.Controls.Add(this.frmSetting1);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1480, 797);
            this.Name = "FrmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel sidebar;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnSetting;
        private FontAwesome.Sharp.IconButton btnReport;
        private FontAwesome.Sharp.IconButton btnMedicineMangement;
        private FontAwesome.Sharp.IconButton btnMedicineType;
        private FontAwesome.Sharp.IconButton btnPatientMangement;
        private FontAwesome.Sharp.IconButton btnDoctorMangement;
        private FontAwesome.Sharp.IconButton btnHome;
        private System.Windows.Forms.PictureBox btnHam;
        private System.Windows.Forms.Label txt_dateTime;
        private System.Windows.Forms.Timer sidebarTransition;
        private FrmSetting frmSetting1;
        private FrmReport frmReport1;
        private FrmMedicineType frmMedicineType1;
        private FrmMedicineMangement frmMedicineMangement1;
        private FrmDoctorManagement frmDoctorManagement1;
        private FrmHome frmHome1;
        private LuySokmatra_ClinicManagementSystem.FrmPatientMangement frmPatientMangement1;
        private System.Windows.Forms.Label txtList;
        private System.Windows.Forms.Timer dateTime;
    }
}