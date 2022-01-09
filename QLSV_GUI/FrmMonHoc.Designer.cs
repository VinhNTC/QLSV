
namespace QLSV_GUI
{
    partial class FrmMonHoc
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gBSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rdbTenMH = new System.Windows.Forms.RadioButton();
            this.rdbMaMH = new System.Windows.Forms.RadioButton();
            this.gBChucNangPhu = new System.Windows.Forms.GroupBox();
            this.cBHK = new System.Windows.Forms.ComboBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.lblChonHK = new System.Windows.Forms.Label();
            this.gBChucNang = new System.Windows.Forms.GroupBox();
            this.button_Excel = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.gBThongTin = new System.Windows.Forms.GroupBox();
            this.lblTenMH = new System.Windows.Forms.Label();
            this.lblHPHT = new System.Windows.Forms.Label();
            this.cBTinChi = new System.Windows.Forms.ComboBox();
            this.txtHPHT = new System.Windows.Forms.TextBox();
            this.lblSTC = new System.Windows.Forms.Label();
            this.lblMaMh = new System.Windows.Forms.Label();
            this.cBMaHK = new System.Windows.Forms.ComboBox();
            this.lblHPTQ = new System.Windows.Forms.Label();
            this.txtTenMH = new System.Windows.Forms.TextBox();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.txtHPTQ = new System.Windows.Forms.TextBox();
            this.lblHK = new System.Windows.Forms.Label();
            this.dGVQLMH = new System.Windows.Forms.DataGridView();
            this.errMaMH = new System.Windows.Forms.ErrorProvider(this.components);
            this.errTenMH = new System.Windows.Forms.ErrorProvider(this.components);
            this.errTinChi = new System.Windows.Forms.ErrorProvider(this.components);
            this.errHPTQ = new System.Windows.Forms.ErrorProvider(this.components);
            this.errHPHT = new System.Windows.Forms.ErrorProvider(this.components);
            this.errMaHK = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gBSearch.SuspendLayout();
            this.gBChucNangPhu.SuspendLayout();
            this.gBChucNang.SuspendLayout();
            this.gBThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVQLMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMaMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTenMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTinChi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errHPTQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errHPHT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMaHK)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1601, 50);
            this.label1.TabIndex = 4;
            this.label1.Text = "QUẢN LÝ MÔN HỌC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1601, 46);
            this.panel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::QLSV_GUI.Properties.Resources.no_32px;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 46);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gBSearch);
            this.panel2.Controls.Add(this.gBChucNangPhu);
            this.panel2.Controls.Add(this.gBChucNang);
            this.panel2.Controls.Add(this.gBThongTin);
            this.panel2.Controls.Add(this.dGVQLMH);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1601, 921);
            this.panel2.TabIndex = 7;
            // 
            // gBSearch
            // 
            this.gBSearch.Controls.Add(this.btnSearch);
            this.gBSearch.Controls.Add(this.txtSearch);
            this.gBSearch.Controls.Add(this.rdbTenMH);
            this.gBSearch.Controls.Add(this.rdbMaMH);
            this.gBSearch.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBSearch.ForeColor = System.Drawing.Color.Blue;
            this.gBSearch.Location = new System.Drawing.Point(770, 388);
            this.gBSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gBSearch.Name = "gBSearch";
            this.gBSearch.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gBSearch.Size = new System.Drawing.Size(432, 135);
            this.gBSearch.TabIndex = 40;
            this.gBSearch.TabStop = false;
            this.gBSearch.Text = "Tìm kiếm";
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.BackColor = System.Drawing.Color.Cyan;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(317, 83);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 33);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(31, 85);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(242, 30);
            this.txtSearch.TabIndex = 2;
            // 
            // rdbTenMH
            // 
            this.rdbTenMH.AutoSize = true;
            this.rdbTenMH.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTenMH.ForeColor = System.Drawing.Color.Black;
            this.rdbTenMH.Location = new System.Drawing.Point(250, 35);
            this.rdbTenMH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbTenMH.Name = "rdbTenMH";
            this.rdbTenMH.Size = new System.Drawing.Size(153, 27);
            this.rdbTenMH.TabIndex = 1;
            this.rdbTenMH.TabStop = true;
            this.rdbTenMH.Text = "Theo Tên MH";
            this.rdbTenMH.UseVisualStyleBackColor = true;
            // 
            // rdbMaMH
            // 
            this.rdbMaMH.AutoSize = true;
            this.rdbMaMH.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMaMH.ForeColor = System.Drawing.Color.Black;
            this.rdbMaMH.Location = new System.Drawing.Point(31, 35);
            this.rdbMaMH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbMaMH.Name = "rdbMaMH";
            this.rdbMaMH.Size = new System.Drawing.Size(116, 27);
            this.rdbMaMH.TabIndex = 0;
            this.rdbMaMH.TabStop = true;
            this.rdbMaMH.Text = "Theo MH";
            this.rdbMaMH.UseVisualStyleBackColor = true;
            // 
            // gBChucNangPhu
            // 
            this.gBChucNangPhu.Controls.Add(this.cBHK);
            this.gBChucNangPhu.Controls.Add(this.btnThongKe);
            this.gBChucNangPhu.Controls.Add(this.lblChonHK);
            this.gBChucNangPhu.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBChucNangPhu.ForeColor = System.Drawing.Color.Blue;
            this.gBChucNangPhu.Location = new System.Drawing.Point(152, 388);
            this.gBChucNangPhu.Name = "gBChucNangPhu";
            this.gBChucNangPhu.Size = new System.Drawing.Size(432, 135);
            this.gBChucNangPhu.TabIndex = 39;
            this.gBChucNangPhu.TabStop = false;
            this.gBChucNangPhu.Text = "Chức Năng Phụ";
            // 
            // cBHK
            // 
            this.cBHK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBHK.FormattingEnabled = true;
            this.cBHK.Items.AddRange(new object[] {
            "CNTT.A",
            "CNTT.B",
            "CNTT.C",
            "CNTT.D",
            "SPTIN.A",
            "SPTIN.B"});
            this.cBHK.Location = new System.Drawing.Point(142, 35);
            this.cBHK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cBHK.Name = "cBHK";
            this.cBHK.Size = new System.Drawing.Size(261, 34);
            this.cBHK.TabIndex = 43;
            this.cBHK.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cBHK_MouseClick);
            // 
            // btnThongKe
            // 
            this.btnThongKe.AutoSize = true;
            this.btnThongKe.BackColor = System.Drawing.Color.Cyan;
            this.btnThongKe.ForeColor = System.Drawing.Color.Black;
            this.btnThongKe.Location = new System.Drawing.Point(142, 84);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(264, 36);
            this.btnThongKe.TabIndex = 42;
            this.btnThongKe.Text = "Xem Danh Sách Môn Học";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // lblChonHK
            // 
            this.lblChonHK.AutoSize = true;
            this.lblChonHK.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChonHK.ForeColor = System.Drawing.Color.Black;
            this.lblChonHK.Location = new System.Drawing.Point(26, 42);
            this.lblChonHK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChonHK.Name = "lblChonHK";
            this.lblChonHK.Size = new System.Drawing.Size(88, 23);
            this.lblChonHK.TabIndex = 11;
            this.lblChonHK.Text = "Chọn HK";
            // 
            // gBChucNang
            // 
            this.gBChucNang.Controls.Add(this.button_Excel);
            this.gBChucNang.Controls.Add(this.btnReturn);
            this.gBChucNang.Controls.Add(this.btnLuu);
            this.gBChucNang.Controls.Add(this.btnThem);
            this.gBChucNang.Controls.Add(this.btnXoa);
            this.gBChucNang.Controls.Add(this.btnReset);
            this.gBChucNang.Controls.Add(this.btnSua);
            this.gBChucNang.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBChucNang.ForeColor = System.Drawing.Color.Blue;
            this.gBChucNang.Location = new System.Drawing.Point(152, 222);
            this.gBChucNang.Name = "gBChucNang";
            this.gBChucNang.Size = new System.Drawing.Size(1178, 124);
            this.gBChucNang.TabIndex = 14;
            this.gBChucNang.TabStop = false;
            this.gBChucNang.Text = "Chức Năng Chính";
            // 
            // button_Excel
            // 
            this.button_Excel.AutoSize = true;
            this.button_Excel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.button_Excel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Excel.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Excel.ForeColor = System.Drawing.Color.ForestGreen;
            this.button_Excel.Image = global::QLSV_GUI.Properties.Resources.mimetypes_excel_611;
            this.button_Excel.Location = new System.Drawing.Point(1025, 37);
            this.button_Excel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Excel.Name = "button_Excel";
            this.button_Excel.Size = new System.Drawing.Size(146, 60);
            this.button_Excel.TabIndex = 37;
            this.button_Excel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Excel.UseVisualStyleBackColor = true;
            this.button_Excel.Click += new System.EventHandler(this.button_Excel_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.AutoSize = true;
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.ForeColor = System.Drawing.Color.Black;
            this.btnReturn.Image = global::QLSV_GUI.Properties.Resources.icons8_return_32;
            this.btnReturn.Location = new System.Drawing.Point(891, 37);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(72, 60);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnLuu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnLuu.Image = global::QLSV_GUI.Properties.Resources.floppy_icon;
            this.btnLuu.Location = new System.Drawing.Point(6, 37);
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
            this.btnThem.Location = new System.Drawing.Point(211, 37);
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
            this.btnXoa.Location = new System.Drawing.Point(413, 37);
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
            this.btnReset.Location = new System.Drawing.Point(826, 37);
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
            this.btnSua.Location = new System.Drawing.Point(618, 37);
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
            this.gBThongTin.Controls.Add(this.lblTenMH);
            this.gBThongTin.Controls.Add(this.lblHPHT);
            this.gBThongTin.Controls.Add(this.cBTinChi);
            this.gBThongTin.Controls.Add(this.txtHPHT);
            this.gBThongTin.Controls.Add(this.lblSTC);
            this.gBThongTin.Controls.Add(this.lblMaMh);
            this.gBThongTin.Controls.Add(this.cBMaHK);
            this.gBThongTin.Controls.Add(this.lblHPTQ);
            this.gBThongTin.Controls.Add(this.txtTenMH);
            this.gBThongTin.Controls.Add(this.txtMaMH);
            this.gBThongTin.Controls.Add(this.txtHPTQ);
            this.gBThongTin.Controls.Add(this.lblHK);
            this.gBThongTin.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBThongTin.ForeColor = System.Drawing.Color.Blue;
            this.gBThongTin.Location = new System.Drawing.Point(152, 25);
            this.gBThongTin.Name = "gBThongTin";
            this.gBThongTin.Size = new System.Drawing.Size(1178, 156);
            this.gBThongTin.TabIndex = 7;
            this.gBThongTin.TabStop = false;
            this.gBThongTin.Text = "Thông Tin";
            // 
            // lblTenMH
            // 
            this.lblTenMH.AutoSize = true;
            this.lblTenMH.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMH.ForeColor = System.Drawing.Color.Black;
            this.lblTenMH.Location = new System.Drawing.Point(30, 92);
            this.lblTenMH.Name = "lblTenMH";
            this.lblTenMH.Size = new System.Drawing.Size(74, 20);
            this.lblTenMH.TabIndex = 10;
            this.lblTenMH.Text = "Tên MH";
            // 
            // lblHPHT
            // 
            this.lblHPHT.AutoSize = true;
            this.lblHPHT.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHPHT.ForeColor = System.Drawing.Color.Black;
            this.lblHPHT.Location = new System.Drawing.Point(813, 40);
            this.lblHPHT.Name = "lblHPHT";
            this.lblHPHT.Size = new System.Drawing.Size(121, 20);
            this.lblHPHT.TabIndex = 9;
            this.lblHPHT.Text = "HP Học Trước";
            // 
            // cBTinChi
            // 
            this.cBTinChi.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBTinChi.FormattingEnabled = true;
            this.cBTinChi.Location = new System.Drawing.Point(527, 30);
            this.cBTinChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cBTinChi.Name = "cBTinChi";
            this.cBTinChi.Size = new System.Drawing.Size(196, 31);
            this.cBTinChi.TabIndex = 5;
            this.cBTinChi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cBTinChi_KeyPress);
            this.cBTinChi.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cBTinChi_MouseClick);
            this.cBTinChi.Validating += new System.ComponentModel.CancelEventHandler(this.cBTinChi_Validating);
            // 
            // txtHPHT
            // 
            this.txtHPHT.Location = new System.Drawing.Point(940, 31);
            this.txtHPHT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHPHT.Name = "txtHPHT";
            this.txtHPHT.Size = new System.Drawing.Size(196, 30);
            this.txtHPHT.TabIndex = 8;
            this.txtHPHT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHPHT_KeyPress);
            this.txtHPHT.Validating += new System.ComponentModel.CancelEventHandler(this.txtHPHT_Validating);
            // 
            // lblSTC
            // 
            this.lblSTC.AutoSize = true;
            this.lblSTC.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSTC.ForeColor = System.Drawing.Color.Black;
            this.lblSTC.Location = new System.Drawing.Point(394, 40);
            this.lblSTC.Name = "lblSTC";
            this.lblSTC.Size = new System.Drawing.Size(93, 20);
            this.lblSTC.TabIndex = 2;
            this.lblSTC.Text = "Số Tín Chỉ";
            // 
            // lblMaMh
            // 
            this.lblMaMh.AutoSize = true;
            this.lblMaMh.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaMh.ForeColor = System.Drawing.Color.Black;
            this.lblMaMh.Location = new System.Drawing.Point(30, 38);
            this.lblMaMh.Name = "lblMaMh";
            this.lblMaMh.Size = new System.Drawing.Size(71, 20);
            this.lblMaMh.TabIndex = 2;
            this.lblMaMh.Text = "Mã MH";
            // 
            // cBMaHK
            // 
            this.cBMaHK.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBMaHK.FormattingEnabled = true;
            this.cBMaHK.Location = new System.Drawing.Point(940, 84);
            this.cBMaHK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cBMaHK.Name = "cBMaHK";
            this.cBMaHK.Size = new System.Drawing.Size(196, 31);
            this.cBMaHK.TabIndex = 5;
            this.cBMaHK.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cBMaHK_MouseClick);
            this.cBMaHK.Validating += new System.ComponentModel.CancelEventHandler(this.cBMaHK_Validating);
            // 
            // lblHPTQ
            // 
            this.lblHPTQ.AutoSize = true;
            this.lblHPTQ.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHPTQ.ForeColor = System.Drawing.Color.Black;
            this.lblHPTQ.Location = new System.Drawing.Point(394, 89);
            this.lblHPTQ.Name = "lblHPTQ";
            this.lblHPTQ.Size = new System.Drawing.Size(124, 20);
            this.lblHPTQ.TabIndex = 2;
            this.lblHPTQ.Text = "HP Tiên Quyết";
            // 
            // txtTenMH
            // 
            this.txtTenMH.Location = new System.Drawing.Point(125, 86);
            this.txtTenMH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenMH.Name = "txtTenMH";
            this.txtTenMH.Size = new System.Drawing.Size(196, 30);
            this.txtTenMH.TabIndex = 1;
            this.txtTenMH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenMH_KeyPress);
            this.txtTenMH.Validating += new System.ComponentModel.CancelEventHandler(this.txtTenMH_Validating);
            // 
            // txtMaMH
            // 
            this.txtMaMH.Location = new System.Drawing.Point(125, 35);
            this.txtMaMH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(196, 30);
            this.txtMaMH.TabIndex = 1;
            this.txtMaMH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaMH_KeyPress);
            this.txtMaMH.Validating += new System.ComponentModel.CancelEventHandler(this.txtMaMH_Validating);
            // 
            // txtHPTQ
            // 
            this.txtHPTQ.Location = new System.Drawing.Point(527, 84);
            this.txtHPTQ.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHPTQ.Name = "txtHPTQ";
            this.txtHPTQ.Size = new System.Drawing.Size(196, 30);
            this.txtHPTQ.TabIndex = 1;
            this.txtHPTQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHPTQ_KeyPress);
            this.txtHPTQ.Validating += new System.ComponentModel.CancelEventHandler(this.txtHPTQ_Validating);
            // 
            // lblHK
            // 
            this.lblHK.AutoSize = true;
            this.lblHK.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHK.ForeColor = System.Drawing.Color.Black;
            this.lblHK.Location = new System.Drawing.Point(813, 92);
            this.lblHK.Name = "lblHK";
            this.lblHK.Size = new System.Drawing.Size(68, 20);
            this.lblHK.TabIndex = 2;
            this.lblHK.Text = "Mã HK";
            // 
            // dGVQLMH
            // 
            this.dGVQLMH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGVQLMH.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGVQLMH.BackgroundColor = System.Drawing.Color.White;
            this.dGVQLMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVQLMH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dGVQLMH.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dGVQLMH.Location = new System.Drawing.Point(0, 546);
            this.dGVQLMH.Name = "dGVQLMH";
            this.dGVQLMH.RowHeadersWidth = 62;
            this.dGVQLMH.RowTemplate.Height = 28;
            this.dGVQLMH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVQLMH.Size = new System.Drawing.Size(1601, 375);
            this.dGVQLMH.TabIndex = 0;
            this.dGVQLMH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVQLMH_CellClick);
            // 
            // errMaMH
            // 
            this.errMaMH.BlinkRate = 0;
            this.errMaMH.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errMaMH.ContainerControl = this;
            // 
            // errTenMH
            // 
            this.errTenMH.BlinkRate = 0;
            this.errTenMH.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errTenMH.ContainerControl = this;
            // 
            // errTinChi
            // 
            this.errTinChi.BlinkRate = 0;
            this.errTinChi.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errTinChi.ContainerControl = this;
            // 
            // errHPTQ
            // 
            this.errHPTQ.BlinkRate = 0;
            this.errHPTQ.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errHPTQ.ContainerControl = this;
            // 
            // errHPHT
            // 
            this.errHPHT.BlinkRate = 0;
            this.errHPHT.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errHPHT.ContainerControl = this;
            // 
            // errMaHK
            // 
            this.errMaHK.BlinkRate = 0;
            this.errMaHK.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errMaHK.ContainerControl = this;
            // 
            // FrmMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1601, 967);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMonHoc";
            this.Text = "Môn Học";
            this.Load += new System.EventHandler(this.FrmMonHoc_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gBSearch.ResumeLayout(false);
            this.gBSearch.PerformLayout();
            this.gBChucNangPhu.ResumeLayout(false);
            this.gBChucNangPhu.PerformLayout();
            this.gBChucNang.ResumeLayout(false);
            this.gBChucNang.PerformLayout();
            this.gBThongTin.ResumeLayout(false);
            this.gBThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVQLMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMaMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTenMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTinChi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errHPTQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errHPHT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMaHK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dGVQLMH;
        private System.Windows.Forms.GroupBox gBThongTin;
        private System.Windows.Forms.Label lblTenMH;
        private System.Windows.Forms.Label lblHPHT;
        private System.Windows.Forms.ComboBox cBTinChi;
        private System.Windows.Forms.TextBox txtHPHT;
        private System.Windows.Forms.Label lblSTC;
        private System.Windows.Forms.Label lblMaMh;
        private System.Windows.Forms.ComboBox cBMaHK;
        private System.Windows.Forms.Label lblHPTQ;
        private System.Windows.Forms.TextBox txtTenMH;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.TextBox txtHPTQ;
        private System.Windows.Forms.Label lblHK;
        private System.Windows.Forms.GroupBox gBChucNang;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button button_Excel;
        private System.Windows.Forms.GroupBox gBChucNangPhu;
        private System.Windows.Forms.ComboBox cBHK;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label lblChonHK;
        private System.Windows.Forms.ErrorProvider errMaMH;
        private System.Windows.Forms.ErrorProvider errTenMH;
        private System.Windows.Forms.ErrorProvider errTinChi;
        private System.Windows.Forms.ErrorProvider errHPTQ;
        private System.Windows.Forms.ErrorProvider errHPHT;
        private System.Windows.Forms.ErrorProvider errMaHK;
        private System.Windows.Forms.GroupBox gBSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rdbTenMH;
        private System.Windows.Forms.RadioButton rdbMaMH;
    }
}