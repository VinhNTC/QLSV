
namespace QLSV_GUI
{
    partial class FrmLopHoc
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
            this.rdbTenLop = new System.Windows.Forms.RadioButton();
            this.rdbMaLop = new System.Windows.Forms.RadioButton();
            this.gBThongTinLop = new System.Windows.Forms.GroupBox();
            this.txtTenLop = new System.Windows.Forms.TextBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dGVQLLH = new System.Windows.Forms.DataGridView();
            this.gBChucNang = new System.Windows.Forms.GroupBox();
            this.button_Excel = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.gBChucNangPhu = new System.Windows.Forms.GroupBox();
            this.cBMaLop = new System.Windows.Forms.ComboBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.errMaLop = new System.Windows.Forms.ErrorProvider(this.components);
            this.errTenLop = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gBSearch.SuspendLayout();
            this.gBThongTinLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVQLLH)).BeginInit();
            this.gBChucNang.SuspendLayout();
            this.gBChucNangPhu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errMaLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTenLop)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1623, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "QUẢN LÝ LỚP HỌC";
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
            this.panel1.Size = new System.Drawing.Size(1623, 46);
            this.panel1.TabIndex = 4;
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
            this.panel2.Controls.Add(this.gBThongTinLop);
            this.panel2.Controls.Add(this.dGVQLLH);
            this.panel2.Controls.Add(this.gBChucNang);
            this.panel2.Controls.Add(this.gBChucNangPhu);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 46);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1623, 977);
            this.panel2.TabIndex = 6;
            // 
            // gBSearch
            // 
            this.gBSearch.Controls.Add(this.btnSearch);
            this.gBSearch.Controls.Add(this.txtSearch);
            this.gBSearch.Controls.Add(this.rdbTenLop);
            this.gBSearch.Controls.Add(this.rdbMaLop);
            this.gBSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBSearch.ForeColor = System.Drawing.Color.Blue;
            this.gBSearch.Location = new System.Drawing.Point(131, 224);
            this.gBSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gBSearch.Name = "gBSearch";
            this.gBSearch.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gBSearch.Size = new System.Drawing.Size(432, 143);
            this.gBSearch.TabIndex = 29;
            this.gBSearch.TabStop = false;
            this.gBSearch.Text = "Tìm kiếm";
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.BackColor = System.Drawing.Color.Cyan;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(317, 83);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 38);
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
            this.txtSearch.Size = new System.Drawing.Size(242, 35);
            this.txtSearch.TabIndex = 2;
            // 
            // rdbTenLop
            // 
            this.rdbTenLop.AutoSize = true;
            this.rdbTenLop.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTenLop.ForeColor = System.Drawing.Color.Black;
            this.rdbTenLop.Location = new System.Drawing.Point(250, 35);
            this.rdbTenLop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbTenLop.Name = "rdbTenLop";
            this.rdbTenLop.Size = new System.Drawing.Size(154, 27);
            this.rdbTenLop.TabIndex = 1;
            this.rdbTenLop.TabStop = true;
            this.rdbTenLop.Text = "Theo Tên Lớp";
            this.rdbTenLop.UseVisualStyleBackColor = true;
            // 
            // rdbMaLop
            // 
            this.rdbMaLop.AutoSize = true;
            this.rdbMaLop.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMaLop.ForeColor = System.Drawing.Color.Black;
            this.rdbMaLop.Location = new System.Drawing.Point(31, 35);
            this.rdbMaLop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdbMaLop.Name = "rdbMaLop";
            this.rdbMaLop.Size = new System.Drawing.Size(150, 27);
            this.rdbMaLop.TabIndex = 0;
            this.rdbMaLop.TabStop = true;
            this.rdbMaLop.Text = "Theo Mã Lớp";
            this.rdbMaLop.UseVisualStyleBackColor = true;
            // 
            // gBThongTinLop
            // 
            this.gBThongTinLop.Controls.Add(this.txtTenLop);
            this.gBThongTinLop.Controls.Add(this.txtMaLop);
            this.gBThongTinLop.Controls.Add(this.label4);
            this.gBThongTinLop.Controls.Add(this.label2);
            this.gBThongTinLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBThongTinLop.ForeColor = System.Drawing.Color.Blue;
            this.gBThongTinLop.Location = new System.Drawing.Point(131, 18);
            this.gBThongTinLop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gBThongTinLop.Name = "gBThongTinLop";
            this.gBThongTinLop.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gBThongTinLop.Size = new System.Drawing.Size(432, 152);
            this.gBThongTinLop.TabIndex = 1;
            this.gBThongTinLop.TabStop = false;
            this.gBThongTinLop.Text = "Thông tin về lớp";
            // 
            // txtTenLop
            // 
            this.txtTenLop.Location = new System.Drawing.Point(142, 100);
            this.txtTenLop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(261, 35);
            this.txtTenLop.TabIndex = 10;
            this.txtTenLop.Validating += new System.ComponentModel.CancelEventHandler(this.txtTenLop_Validating);
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(142, 38);
            this.txtMaLop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(261, 35);
            this.txtMaLop.TabIndex = 9;
            this.txtMaLop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaLop_KeyPress);
            this.txtMaLop.Validating += new System.ComponentModel.CancelEventHandler(this.txtMaLop_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(26, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã lớp";
            // 
            // dGVQLLH
            // 
            this.dGVQLLH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGVQLLH.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGVQLLH.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dGVQLLH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVQLLH.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dGVQLLH.Location = new System.Drawing.Point(700, 242);
            this.dGVQLLH.Name = "dGVQLLH";
            this.dGVQLLH.RowHeadersWidth = 62;
            this.dGVQLLH.RowTemplate.Height = 28;
            this.dGVQLLH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVQLLH.Size = new System.Drawing.Size(640, 462);
            this.dGVQLLH.TabIndex = 0;
            this.dGVQLLH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVQLLH_CellClick);
            // 
            // gBChucNang
            // 
            this.gBChucNang.Controls.Add(this.button_Excel);
            this.gBChucNang.Controls.Add(this.btnThem);
            this.gBChucNang.Controls.Add(this.btnXoa);
            this.gBChucNang.Controls.Add(this.btnLuu);
            this.gBChucNang.Controls.Add(this.btnSua);
            this.gBChucNang.Controls.Add(this.btnReset);
            this.gBChucNang.Controls.Add(this.btnReturn);
            this.gBChucNang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBChucNang.ForeColor = System.Drawing.Color.Blue;
            this.gBChucNang.Location = new System.Drawing.Point(131, 609);
            this.gBChucNang.Name = "gBChucNang";
            this.gBChucNang.Size = new System.Drawing.Size(432, 339);
            this.gBChucNang.TabIndex = 37;
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
            this.button_Excel.Location = new System.Drawing.Point(260, 255);
            this.button_Excel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Excel.Name = "button_Excel";
            this.button_Excel.Size = new System.Drawing.Size(146, 60);
            this.button_Excel.TabIndex = 36;
            this.button_Excel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Excel.UseVisualStyleBackColor = true;
            this.button_Excel.Click += new System.EventHandler(this.button_Excel_Click);
            // 
            // btnThem
            // 
            this.btnThem.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(171)))), ((int)(((byte)(1)))));
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(171)))), ((int)(((byte)(1)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnThem.Image = global::QLSV_GUI.Properties.Resources.add_32px;
            this.btnThem.Location = new System.Drawing.Point(260, 35);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(144, 60);
            this.btnThem.TabIndex = 31;
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
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Image = global::QLSV_GUI.Properties.Resources.remove_32px;
            this.btnXoa.Location = new System.Drawing.Point(31, 143);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(145, 60);
            this.btnXoa.TabIndex = 32;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btnLuu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnLuu.Image = global::QLSV_GUI.Properties.Resources.floppy_icon;
            this.btnLuu.Location = new System.Drawing.Point(31, 35);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(144, 60);
            this.btnLuu.TabIndex = 30;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(1)))), ((int)(((byte)(171)))));
            this.btnSua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(0)))), ((int)(((byte)(227)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Image = global::QLSV_GUI.Properties.Resources.maintenance_32px;
            this.btnSua.Location = new System.Drawing.Point(258, 143);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(145, 60);
            this.btnSua.TabIndex = 33;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Image = global::QLSV_GUI.Properties.Resources.Very_Basic_Reload_icon;
            this.btnReset.Location = new System.Drawing.Point(31, 254);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(72, 60);
            this.btnReset.TabIndex = 34;
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.AutoSize = true;
            this.btnReturn.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.ForeColor = System.Drawing.Color.Black;
            this.btnReturn.Image = global::QLSV_GUI.Properties.Resources.icons8_return_32;
            this.btnReturn.Location = new System.Drawing.Point(103, 254);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(72, 60);
            this.btnReturn.TabIndex = 35;
            this.btnReturn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // gBChucNangPhu
            // 
            this.gBChucNangPhu.Controls.Add(this.cBMaLop);
            this.gBChucNangPhu.Controls.Add(this.btnThongKe);
            this.gBChucNangPhu.Controls.Add(this.label3);
            this.gBChucNangPhu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBChucNangPhu.ForeColor = System.Drawing.Color.Blue;
            this.gBChucNangPhu.Location = new System.Drawing.Point(131, 420);
            this.gBChucNangPhu.Name = "gBChucNangPhu";
            this.gBChucNangPhu.Size = new System.Drawing.Size(432, 135);
            this.gBChucNangPhu.TabIndex = 38;
            this.gBChucNangPhu.TabStop = false;
            this.gBChucNangPhu.Text = "Chức Năng Phụ";
            // 
            // cBMaLop
            // 
            this.cBMaLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBMaLop.FormattingEnabled = true;
            this.cBMaLop.Items.AddRange(new object[] {
            "CNTT.A",
            "CNTT.B",
            "CNTT.C",
            "CNTT.D",
            "SPTIN.A",
            "SPTIN.B"});
            this.cBMaLop.Location = new System.Drawing.Point(142, 35);
            this.cBMaLop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cBMaLop.Name = "cBMaLop";
            this.cBMaLop.Size = new System.Drawing.Size(261, 34);
            this.cBMaLop.TabIndex = 43;
            this.cBMaLop.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cBMaLop_MouseClick);
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
            this.btnThongKe.Text = "Xem Sĩ Số";
            this.btnThongKe.UseVisualStyleBackColor = false;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(26, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Chọn Lớp";
            // 
            // errMaLop
            // 
            this.errMaLop.BlinkRate = 0;
            this.errMaLop.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errMaLop.ContainerControl = this;
            // 
            // errTenLop
            // 
            this.errTenLop.BlinkRate = 0;
            this.errTenLop.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errTenLop.ContainerControl = this;
            // 
            // FrmLopHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1623, 1023);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLopHoc";
            this.Text = "FrmLopHoc";
            this.Load += new System.EventHandler(this.FrmLopHoc_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gBSearch.ResumeLayout(false);
            this.gBSearch.PerformLayout();
            this.gBThongTinLop.ResumeLayout(false);
            this.gBThongTinLop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVQLLH)).EndInit();
            this.gBChucNang.ResumeLayout(false);
            this.gBChucNang.PerformLayout();
            this.gBChucNangPhu.ResumeLayout(false);
            this.gBChucNangPhu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errMaLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTenLop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dGVQLLH;
        private System.Windows.Forms.GroupBox gBThongTinLop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gBSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.RadioButton rdbTenLop;
        private System.Windows.Forms.RadioButton rdbMaLop;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.GroupBox gBChucNang;
        private System.Windows.Forms.Button button_Excel;
        private System.Windows.Forms.TextBox txtTenLop;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errMaLop;
        private System.Windows.Forms.ErrorProvider errTenLop;
        private System.Windows.Forms.GroupBox gBChucNangPhu;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.ComboBox cBMaLop;
    }
}