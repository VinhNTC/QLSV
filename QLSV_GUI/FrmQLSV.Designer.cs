
namespace QLSV_GUI
{
    partial class FrmQLSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQLSV));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gBChucNang = new System.Windows.Forms.GroupBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.gBThongTin = new System.Windows.Forms.GroupBox();
            this.cBDT = new System.Windows.Forms.ComboBox();
            this.lblCCCD = new System.Windows.Forms.Label();
            this.lblTenSV = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.cBGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.cBMaLop = new System.Windows.Forms.ComboBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblDienThoai = new System.Windows.Forms.Label();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblLop = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cBTimTheo = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_Excel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dGVQLSV = new System.Windows.Forms.DataGridView();
            this.errMaSV = new System.Windows.Forms.ErrorProvider(this.components);
            this.errTenSV = new System.Windows.Forms.ErrorProvider(this.components);
            this.errGioiTinh = new System.Windows.Forms.ErrorProvider(this.components);
            this.errNgaySinh = new System.Windows.Forms.ErrorProvider(this.components);
            this.errDiaChi = new System.Windows.Forms.ErrorProvider(this.components);
            this.errDanToc = new System.Windows.Forms.ErrorProvider(this.components);
            this.errSDT = new System.Windows.Forms.ErrorProvider(this.components);
            this.errEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errMaLop = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.gBChucNang.SuspendLayout();
            this.gBThongTin.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVQLSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMaSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTenSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errGioiTinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNgaySinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDiaChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDanToc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSDT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMaLop)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1515, 46);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(64, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1451, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÝ SINH VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::QLSV_GUI.Properties.Resources.no_32px;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 46);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // gBChucNang
            // 
            this.gBChucNang.Controls.Add(this.btnReturn);
            this.gBChucNang.Controls.Add(this.btnLuu);
            this.gBChucNang.Controls.Add(this.btnThem);
            this.gBChucNang.Controls.Add(this.btnXoa);
            this.gBChucNang.Controls.Add(this.btnReset);
            this.gBChucNang.Controls.Add(this.btnSua);
            this.gBChucNang.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBChucNang.ForeColor = System.Drawing.Color.Blue;
            this.gBChucNang.Location = new System.Drawing.Point(28, 278);
            this.gBChucNang.Name = "gBChucNang";
            this.gBChucNang.Size = new System.Drawing.Size(1083, 124);
            this.gBChucNang.TabIndex = 13;
            this.gBChucNang.TabStop = false;
            this.gBChucNang.Text = "Chức Năng Chính";
            // 
            // btnReturn
            // 
            this.btnReturn.AutoSize = true;
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.ForeColor = System.Drawing.Color.Black;
            this.btnReturn.Image = global::QLSV_GUI.Properties.Resources.icons8_return_32;
            this.btnReturn.Location = new System.Drawing.Point(991, 37);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(72, 60);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.Return_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnLuu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnLuu.Image = global::QLSV_GUI.Properties.Resources.floppy_icon;
            this.btnLuu.Location = new System.Drawing.Point(14, 37);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(144, 60);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(171)))), ((int)(((byte)(1)))));
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(171)))), ((int)(((byte)(1)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnThem.Image = global::QLSV_GUI.Properties.Resources.add_32px;
            this.btnThem.Location = new System.Drawing.Point(244, 37);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(144, 60);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Image = global::QLSV_GUI.Properties.Resources.remove_32px;
            this.btnXoa.Location = new System.Drawing.Point(475, 37);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(145, 60);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Image = global::QLSV_GUI.Properties.Resources.Very_Basic_Reload_icon;
            this.btnReset.Location = new System.Drawing.Point(923, 37);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(72, 60);
            this.btnReset.TabIndex = 8;
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSua
            // 
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(1)))), ((int)(((byte)(171)))));
            this.btnSua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(0)))), ((int)(((byte)(227)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Image = global::QLSV_GUI.Properties.Resources.maintenance_32px;
            this.btnSua.Location = new System.Drawing.Point(704, 37);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(145, 60);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // gBThongTin
            // 
            this.gBThongTin.Controls.Add(this.cBDT);
            this.gBThongTin.Controls.Add(this.lblCCCD);
            this.gBThongTin.Controls.Add(this.lblTenSV);
            this.gBThongTin.Controls.Add(this.lblEmail);
            this.gBThongTin.Controls.Add(this.cBGioiTinh);
            this.gBThongTin.Controls.Add(this.txtEmail);
            this.gBThongTin.Controls.Add(this.dtpNgaySinh);
            this.gBThongTin.Controls.Add(this.lblGioiTinh);
            this.gBThongTin.Controls.Add(this.txtSDT);
            this.gBThongTin.Controls.Add(this.lblMaSV);
            this.gBThongTin.Controls.Add(this.cBMaLop);
            this.gBThongTin.Controls.Add(this.lblDiaChi);
            this.gBThongTin.Controls.Add(this.lblDienThoai);
            this.gBThongTin.Controls.Add(this.txtTenSV);
            this.gBThongTin.Controls.Add(this.lblNgaySinh);
            this.gBThongTin.Controls.Add(this.txtMaSV);
            this.gBThongTin.Controls.Add(this.txtDiaChi);
            this.gBThongTin.Controls.Add(this.lblLop);
            this.gBThongTin.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBThongTin.ForeColor = System.Drawing.Color.Blue;
            this.gBThongTin.Location = new System.Drawing.Point(28, 63);
            this.gBThongTin.Name = "gBThongTin";
            this.gBThongTin.Size = new System.Drawing.Size(1083, 188);
            this.gBThongTin.TabIndex = 6;
            this.gBThongTin.TabStop = false;
            this.gBThongTin.Text = "Thông Tin";
            // 
            // cBDT
            // 
            this.cBDT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBDT.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBDT.FormattingEnabled = true;
            this.cBDT.Items.AddRange(new object[] {
            "Kinh",
            "DTTS"});
            this.cBDT.Location = new System.Drawing.Point(503, 135);
            this.cBDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cBDT.Name = "cBDT";
            this.cBDT.Size = new System.Drawing.Size(196, 31);
            this.cBDT.TabIndex = 13;
            this.cBDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cBDT_KeyPress);
            this.cBDT.Validating += new System.ComponentModel.CancelEventHandler(this.cBDT_Validating);
            // 
            // lblCCCD
            // 
            this.lblCCCD.AutoSize = true;
            this.lblCCCD.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCCCD.ForeColor = System.Drawing.Color.Black;
            this.lblCCCD.Location = new System.Drawing.Point(394, 142);
            this.lblCCCD.Name = "lblCCCD";
            this.lblCCCD.Size = new System.Drawing.Size(75, 20);
            this.lblCCCD.TabIndex = 12;
            this.lblCCCD.Text = "Dân Tộc";
            // 
            // lblTenSV
            // 
            this.lblTenSV.AutoSize = true;
            this.lblTenSV.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSV.ForeColor = System.Drawing.Color.Black;
            this.lblTenSV.Location = new System.Drawing.Point(30, 92);
            this.lblTenSV.Name = "lblTenSV";
            this.lblTenSV.Size = new System.Drawing.Size(66, 20);
            this.lblTenSV.TabIndex = 10;
            this.lblTenSV.Text = "Tên SV";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(748, 92);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(54, 20);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "Email";
            // 
            // cBGioiTinh
            // 
            this.cBGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBGioiTinh.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBGioiTinh.FormattingEnabled = true;
            this.cBGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cBGioiTinh.Location = new System.Drawing.Point(125, 137);
            this.cBGioiTinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cBGioiTinh.Name = "cBGioiTinh";
            this.cBGioiTinh.Size = new System.Drawing.Size(196, 31);
            this.cBGioiTinh.TabIndex = 5;
            this.cBGioiTinh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cBGioiTinh_KeyPress);
            this.cBGioiTinh.Validating += new System.ComponentModel.CancelEventHandler(this.cBGioiTinh_Validating);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(849, 84);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(196, 30);
            this.txtEmail.TabIndex = 8;
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(503, 32);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(196, 30);
            this.dtpNgaySinh.TabIndex = 7;
            this.dtpNgaySinh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpNgaySinh_KeyPress);
            this.dtpNgaySinh.Validating += new System.ComponentModel.CancelEventHandler(this.dtpNgaySinh_Validating);
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.ForeColor = System.Drawing.Color.Black;
            this.lblGioiTinh.Location = new System.Drawing.Point(30, 145);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(79, 20);
            this.lblGioiTinh.TabIndex = 2;
            this.lblGioiTinh.Text = "Giới tính";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(849, 32);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(196, 30);
            this.txtSDT.TabIndex = 6;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDT_KeyPress);
            this.txtSDT.Validating += new System.ComponentModel.CancelEventHandler(this.txtDT_Validating);
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSV.ForeColor = System.Drawing.Color.Black;
            this.lblMaSV.Location = new System.Drawing.Point(30, 38);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(63, 20);
            this.lblMaSV.TabIndex = 2;
            this.lblMaSV.Text = "Mã SV";
            // 
            // cBMaLop
            // 
            this.cBMaLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBMaLop.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBMaLop.FormattingEnabled = true;
            this.cBMaLop.Items.AddRange(new object[] {
            "CNTT.A",
            "CNTT.B",
            "CNTT.C",
            "CNTT.D",
            "SPTIN.A",
            "SPTIN.B"});
            this.cBMaLop.Location = new System.Drawing.Point(849, 138);
            this.cBMaLop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cBMaLop.Name = "cBMaLop";
            this.cBMaLop.Size = new System.Drawing.Size(196, 31);
            this.cBMaLop.TabIndex = 5;
            this.cBMaLop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cBLop_KeyPress);
            this.cBMaLop.Validating += new System.ComponentModel.CancelEventHandler(this.cBMaLop_Validating);
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.ForeColor = System.Drawing.Color.Black;
            this.lblDiaChi.Location = new System.Drawing.Point(394, 89);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(64, 20);
            this.lblDiaChi.TabIndex = 2;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // lblDienThoai
            // 
            this.lblDienThoai.AutoSize = true;
            this.lblDienThoai.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDienThoai.ForeColor = System.Drawing.Color.Black;
            this.lblDienThoai.Location = new System.Drawing.Point(748, 40);
            this.lblDienThoai.Name = "lblDienThoai";
            this.lblDienThoai.Size = new System.Drawing.Size(90, 20);
            this.lblDienThoai.TabIndex = 2;
            this.lblDienThoai.Text = "Điện thoại";
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(125, 86);
            this.txtTenSV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(196, 30);
            this.txtTenSV.TabIndex = 1;
            this.txtTenSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenSV_KeyPress);
            this.txtTenSV.Validating += new System.ComponentModel.CancelEventHandler(this.txtTenSV_Validating);
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.ForeColor = System.Drawing.Color.Black;
            this.lblNgaySinh.Location = new System.Drawing.Point(394, 37);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(86, 20);
            this.lblNgaySinh.TabIndex = 2;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(125, 35);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(196, 30);
            this.txtMaSV.TabIndex = 1;
            this.txtMaSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaSV_KeyPress);
            this.txtMaSV.Validating += new System.ComponentModel.CancelEventHandler(this.txtMaSV_Validating);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(503, 86);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(196, 30);
            this.txtDiaChi.TabIndex = 1;
            this.txtDiaChi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiaChi_KeyPress);
            this.txtDiaChi.Validating += new System.ComponentModel.CancelEventHandler(this.txtDiaChi_Validating);
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLop.ForeColor = System.Drawing.Color.Black;
            this.lblLop.Location = new System.Drawing.Point(748, 145);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(72, 20);
            this.lblLop.TabIndex = 2;
            this.lblLop.Text = "Mã Lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thông tin chi tiết";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTim);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cBTimTheo);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(1127, 103);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(317, 113);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(104, 67);
            this.txtTim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(199, 30);
            this.txtTim.TabIndex = 2;
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(8, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tìm theo";
            // 
            // cBTimTheo
            // 
            this.cBTimTheo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBTimTheo.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBTimTheo.FormattingEnabled = true;
            this.cBTimTheo.Items.AddRange(new object[] {
            "Mã Sinh Viên",
            "Tên Sinh Viên",
            "Dân Tộc",
            "Số Điện Thoại",
            "Email",
            "Mã Lớp"});
            this.cBTimTheo.Location = new System.Drawing.Point(104, 27);
            this.cBTimTheo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cBTimTheo.Name = "cBTimTheo";
            this.cBTimTheo.Size = new System.Drawing.Size(199, 30);
            this.cBTimTheo.TabIndex = 0;
            this.cBTimTheo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cBTimTheo_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_Excel);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(1127, 278);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(317, 124);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Xuất Excel";
            // 
            // button_Excel
            // 
            this.button_Excel.AutoSize = true;
            this.button_Excel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.button_Excel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Excel.ForeColor = System.Drawing.Color.ForestGreen;
            this.button_Excel.Image = global::QLSV_GUI.Properties.Resources.mimetypes_excel_611;
            this.button_Excel.Location = new System.Drawing.Point(45, 42);
            this.button_Excel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Excel.Name = "button_Excel";
            this.button_Excel.Size = new System.Drawing.Size(230, 51);
            this.button_Excel.TabIndex = 18;
            this.button_Excel.Text = "Xuất Excel";
            this.button_Excel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Excel.UseVisualStyleBackColor = true;
            this.button_Excel.Click += new System.EventHandler(this.button_Excel_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dGVQLSV);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.gBThongTin);
            this.panel2.Controls.Add(this.gBChucNang);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1515, 945);
            this.panel2.TabIndex = 6;
            // 
            // dGVQLSV
            // 
            this.dGVQLSV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGVQLSV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGVQLSV.BackgroundColor = System.Drawing.Color.White;
            this.dGVQLSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVQLSV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dGVQLSV.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dGVQLSV.Location = new System.Drawing.Point(0, 408);
            this.dGVQLSV.Name = "dGVQLSV";
            this.dGVQLSV.RowHeadersWidth = 62;
            this.dGVQLSV.RowTemplate.Height = 28;
            this.dGVQLSV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVQLSV.Size = new System.Drawing.Size(1515, 537);
            this.dGVQLSV.TabIndex = 16;
            this.dGVQLSV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVQLSV_CellClick);
            // 
            // errMaSV
            // 
            this.errMaSV.BlinkRate = 0;
            this.errMaSV.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errMaSV.ContainerControl = this;
            // 
            // errTenSV
            // 
            this.errTenSV.BlinkRate = 0;
            this.errTenSV.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errTenSV.ContainerControl = this;
            // 
            // errGioiTinh
            // 
            this.errGioiTinh.BlinkRate = 0;
            this.errGioiTinh.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errGioiTinh.ContainerControl = this;
            // 
            // errNgaySinh
            // 
            this.errNgaySinh.BlinkRate = 0;
            this.errNgaySinh.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errNgaySinh.ContainerControl = this;
            // 
            // errDiaChi
            // 
            this.errDiaChi.BlinkRate = 0;
            this.errDiaChi.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errDiaChi.ContainerControl = this;
            // 
            // errDanToc
            // 
            this.errDanToc.BlinkRate = 0;
            this.errDanToc.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errDanToc.ContainerControl = this;
            // 
            // errSDT
            // 
            this.errSDT.BlinkRate = 0;
            this.errSDT.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errSDT.ContainerControl = this;
            // 
            // errEmail
            // 
            this.errEmail.BlinkRate = 0;
            this.errEmail.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errEmail.ContainerControl = this;
            // 
            // errMaLop
            // 
            this.errMaLop.BlinkRate = 0;
            this.errMaLop.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errMaLop.ContainerControl = this;
            // 
            // FrmQLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1515, 945);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmQLSV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_QLSV";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmQLSV_Load);
            this.panel1.ResumeLayout(false);
            this.gBChucNang.ResumeLayout(false);
            this.gBChucNang.PerformLayout();
            this.gBThongTin.ResumeLayout(false);
            this.gBThongTin.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVQLSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMaSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTenSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errGioiTinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNgaySinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDiaChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errDanToc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSDT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMaLop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gBChucNang;
        private System.Windows.Forms.GroupBox gBThongTin;
        private System.Windows.Forms.ComboBox cBDT;
        private System.Windows.Forms.Label lblCCCD;
        private System.Windows.Forms.Label lblTenSV;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ComboBox cBGioiTinh;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.ComboBox cBMaLop;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblDienThoai;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBTimTheo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_Excel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ErrorProvider errMaSV;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ErrorProvider errTenSV;
        private System.Windows.Forms.ErrorProvider errGioiTinh;
        private System.Windows.Forms.ErrorProvider errNgaySinh;
        private System.Windows.Forms.ErrorProvider errDiaChi;
        private System.Windows.Forms.ErrorProvider errDanToc;
        private System.Windows.Forms.ErrorProvider errSDT;
        private System.Windows.Forms.ErrorProvider errEmail;
        private System.Windows.Forms.ErrorProvider errMaLop;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView dGVQLSV;
    }
}