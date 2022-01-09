
namespace QLSV_GUI
{
    partial class FrmDiem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvSV = new System.Windows.Forms.DataGridView();
            this.maSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cBMaLop = new System.Windows.Forms.ComboBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnCK = new System.Windows.Forms.Button();
            this.btnGK = new System.Windows.Forms.Button();
            this.txtCK = new System.Windows.Forms.TextBox();
            this.cBMH = new System.Windows.Forms.ComboBox();
            this.txtGK = new System.Windows.Forms.TextBox();
            this.lblMH = new System.Windows.Forms.Label();
            this.lblHK = new System.Windows.Forms.Label();
            this.cBHK = new System.Windows.Forms.ComboBox();
            this.cboMaSV = new System.Windows.Forms.ComboBox();
            this.lblLop = new System.Windows.Forms.Label();
            this.dGVDiem = new System.Windows.Forms.DataGridView();
            this.button_Excel = new System.Windows.Forms.Button();
            this.lblsldau = new System.Windows.Forms.Label();
            this.dGVThongKe = new System.Windows.Forms.DataGridView();
            this.btnShow = new System.Windows.Forms.Button();
            this.cBDau = new System.Windows.Forms.CheckBox();
            this.cBRot = new System.Windows.Forms.CheckBox();
            this.cBTK = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cBHocKy = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cBMonHoc = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cBTimTheo = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSV)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVThongKe)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SkyBlue;
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1601, 46);
            this.panel1.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvSV);
            this.groupBox4.Location = new System.Drawing.Point(427, 43);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(380, 732);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách sinh viên";
            // 
            // dgvSV
            // 
            this.dgvSV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSV,
            this.hoTen});
            this.dgvSV.Location = new System.Drawing.Point(9, 23);
            this.dgvSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvSV.Name = "dgvSV";
            this.dgvSV.RowHeadersWidth = 62;
            this.dgvSV.Size = new System.Drawing.Size(366, 700);
            this.dgvSV.TabIndex = 0;
            // 
            // maSV
            // 
            this.maSV.DataPropertyName = "maSV";
            this.maSV.HeaderText = "Mã SV";
            this.maSV.MinimumWidth = 8;
            this.maSV.Name = "maSV";
            this.maSV.Width = 80;
            // 
            // hoTen
            // 
            this.hoTen.DataPropertyName = "hoTen";
            this.hoTen.HeaderText = "Họ Tên SV";
            this.hoTen.MinimumWidth = 8;
            this.hoTen.Name = "hoTen";
            this.hoTen.Width = 120;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = global::QLSV_GUI.Properties.Resources.no_32px;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 46);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1601, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "QUẢN LÝ ĐIỂM SINH VIÊN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cBMaLop);
            this.groupBox1.Controls.Add(this.btnLuu);
            this.groupBox1.Controls.Add(this.btnCK);
            this.groupBox1.Controls.Add(this.btnGK);
            this.groupBox1.Controls.Add(this.txtCK);
            this.groupBox1.Controls.Add(this.cBMH);
            this.groupBox1.Controls.Add(this.txtGK);
            this.groupBox1.Controls.Add(this.lblMH);
            this.groupBox1.Controls.Add(this.lblHK);
            this.groupBox1.Controls.Add(this.cBHK);
            this.groupBox1.Controls.Add(this.cboMaSV);
            this.groupBox1.Controls.Add(this.lblLop);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(141, 46);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(426, 435);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lựa chọn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(20, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Mã Lớp";
            // 
            // cBMaLop
            // 
            this.cBMaLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBMaLop.FormattingEnabled = true;
            this.cBMaLop.Location = new System.Drawing.Point(149, 33);
            this.cBMaLop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cBMaLop.Name = "cBMaLop";
            this.cBMaLop.Size = new System.Drawing.Size(234, 31);
            this.cBMaLop.TabIndex = 18;
            this.cBMaLop.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cBMaLop_MouseClick);
            // 
            // btnLuu
            // 
            this.btnLuu.AutoSize = true;
            this.btnLuu.BackColor = System.Drawing.Color.Aqua;
            this.btnLuu.Location = new System.Drawing.Point(226, 376);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 33);
            this.btnLuu.TabIndex = 17;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnCK
            // 
            this.btnCK.AutoSize = true;
            this.btnCK.BackColor = System.Drawing.Color.Aqua;
            this.btnCK.Location = new System.Drawing.Point(15, 321);
            this.btnCK.Name = "btnCK";
            this.btnCK.Size = new System.Drawing.Size(97, 33);
            this.btnCK.TabIndex = 16;
            this.btnCK.Text = "Điểm CK";
            this.btnCK.UseVisualStyleBackColor = false;
            this.btnCK.Click += new System.EventHandler(this.btnCK_Click);
            // 
            // btnGK
            // 
            this.btnGK.AutoSize = true;
            this.btnGK.BackColor = System.Drawing.Color.Aqua;
            this.btnGK.Location = new System.Drawing.Point(14, 264);
            this.btnGK.Name = "btnGK";
            this.btnGK.Size = new System.Drawing.Size(99, 33);
            this.btnGK.TabIndex = 16;
            this.btnGK.Text = "Điểm GK";
            this.btnGK.UseVisualStyleBackColor = false;
            this.btnGK.Click += new System.EventHandler(this.btnGK_Click);
            // 
            // txtCK
            // 
            this.txtCK.Location = new System.Drawing.Point(149, 324);
            this.txtCK.Name = "txtCK";
            this.txtCK.Size = new System.Drawing.Size(234, 30);
            this.txtCK.TabIndex = 15;
            // 
            // cBMH
            // 
            this.cBMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBMH.FormattingEnabled = true;
            this.cBMH.Location = new System.Drawing.Point(149, 209);
            this.cBMH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cBMH.Name = "cBMH";
            this.cBMH.Size = new System.Drawing.Size(234, 31);
            this.cBMH.TabIndex = 11;
            this.cBMH.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cBMH_MouseClick);
            // 
            // txtGK
            // 
            this.txtGK.Location = new System.Drawing.Point(149, 267);
            this.txtGK.Name = "txtGK";
            this.txtGK.Size = new System.Drawing.Size(234, 30);
            this.txtGK.TabIndex = 15;
            // 
            // lblMH
            // 
            this.lblMH.AutoSize = true;
            this.lblMH.ForeColor = System.Drawing.Color.Black;
            this.lblMH.Location = new System.Drawing.Point(20, 212);
            this.lblMH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMH.Name = "lblMH";
            this.lblMH.Size = new System.Drawing.Size(87, 23);
            this.lblMH.TabIndex = 12;
            this.lblMH.Text = "Môn Học";
            // 
            // lblHK
            // 
            this.lblHK.AutoSize = true;
            this.lblHK.ForeColor = System.Drawing.Color.Black;
            this.lblHK.Location = new System.Drawing.Point(20, 153);
            this.lblHK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHK.Name = "lblHK";
            this.lblHK.Size = new System.Drawing.Size(73, 23);
            this.lblHK.TabIndex = 14;
            this.lblHK.Text = "Học Kỳ";
            // 
            // cBHK
            // 
            this.cBHK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBHK.FormattingEnabled = true;
            this.cBHK.Location = new System.Drawing.Point(149, 150);
            this.cBHK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cBHK.Name = "cBHK";
            this.cBHK.Size = new System.Drawing.Size(234, 31);
            this.cBHK.TabIndex = 13;
            this.cBHK.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cBHK_MouseClick);
            // 
            // cboMaSV
            // 
            this.cboMaSV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaSV.FormattingEnabled = true;
            this.cboMaSV.Location = new System.Drawing.Point(149, 92);
            this.cboMaSV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboMaSV.Name = "cboMaSV";
            this.cboMaSV.Size = new System.Drawing.Size(234, 31);
            this.cboMaSV.TabIndex = 1;
            this.cboMaSV.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cboKhoaHoc_MouseClick);
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.ForeColor = System.Drawing.Color.Black;
            this.lblLop.Location = new System.Drawing.Point(20, 95);
            this.lblLop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(121, 23);
            this.lblLop.TabIndex = 0;
            this.lblLop.Text = "Mã Sinh Viên";
            // 
            // dGVDiem
            // 
            this.dGVDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dGVDiem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dGVDiem.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dGVDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDiem.Dock = System.Windows.Forms.DockStyle.Right;
            this.dGVDiem.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dGVDiem.Location = new System.Drawing.Point(814, 46);
            this.dGVDiem.Name = "dGVDiem";
            this.dGVDiem.RowHeadersWidth = 62;
            this.dGVDiem.RowTemplate.Height = 28;
            this.dGVDiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGVDiem.Size = new System.Drawing.Size(787, 921);
            this.dGVDiem.TabIndex = 31;
            this.dGVDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVDiem_CellClick);
            // 
            // button_Excel
            // 
            this.button_Excel.AutoSize = true;
            this.button_Excel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.button_Excel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Excel.ForeColor = System.Drawing.Color.ForestGreen;
            this.button_Excel.Image = global::QLSV_GUI.Properties.Resources.mimetypes_excel_611;
            this.button_Excel.Location = new System.Drawing.Point(405, 900);
            this.button_Excel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Excel.Name = "button_Excel";
            this.button_Excel.Size = new System.Drawing.Size(129, 51);
            this.button_Excel.TabIndex = 18;
            this.button_Excel.Text = "Xuất Excel";
            this.button_Excel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_Excel.UseVisualStyleBackColor = true;
            this.button_Excel.Click += new System.EventHandler(this.button_Excel_Click);
            // 
            // lblsldau
            // 
            this.lblsldau.AutoSize = true;
            this.lblsldau.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsldau.Location = new System.Drawing.Point(318, 549);
            this.lblsldau.Name = "lblsldau";
            this.lblsldau.Size = new System.Drawing.Size(0, 33);
            this.lblsldau.TabIndex = 35;
            // 
            // dGVThongKe
            // 
            this.dGVThongKe.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dGVThongKe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVThongKe.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dGVThongKe.Location = new System.Drawing.Point(43, 188);
            this.dGVThongKe.Name = "dGVThongKe";
            this.dGVThongKe.RowHeadersWidth = 62;
            this.dGVThongKe.RowTemplate.Height = 28;
            this.dGVThongKe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dGVThongKe.Size = new System.Drawing.Size(288, 100);
            this.dGVThongKe.TabIndex = 41;
            // 
            // btnShow
            // 
            this.btnShow.AutoSize = true;
            this.btnShow.BackColor = System.Drawing.Color.Aqua;
            this.btnShow.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(337, 219);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(87, 35);
            this.btnShow.TabIndex = 44;
            this.btnShow.Text = "Xem";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // cBDau
            // 
            this.cBDau.AutoSize = true;
            this.cBDau.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBDau.ForeColor = System.Drawing.Color.Black;
            this.cBDau.Location = new System.Drawing.Point(43, 34);
            this.cBDau.Name = "cBDau";
            this.cBDau.Size = new System.Drawing.Size(70, 27);
            this.cBDau.TabIndex = 46;
            this.cBDau.Text = "Đậu";
            this.cBDau.UseVisualStyleBackColor = true;
            // 
            // cBRot
            // 
            this.cBRot.AutoSize = true;
            this.cBRot.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBRot.ForeColor = System.Drawing.Color.Black;
            this.cBRot.Location = new System.Drawing.Point(132, 34);
            this.cBRot.Name = "cBRot";
            this.cBRot.Size = new System.Drawing.Size(68, 27);
            this.cBRot.TabIndex = 47;
            this.cBRot.Text = "Rớt";
            this.cBRot.UseVisualStyleBackColor = true;
            // 
            // cBTK
            // 
            this.cBTK.AutoSize = true;
            this.cBTK.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBTK.ForeColor = System.Drawing.Color.Black;
            this.cBTK.Location = new System.Drawing.Point(213, 34);
            this.cBTK.Name = "cBTK";
            this.cBTK.Size = new System.Drawing.Size(118, 27);
            this.cBTK.TabIndex = 48;
            this.cBTK.Text = "Thủ Khoa";
            this.cBTK.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cBHocKy);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cBMonHoc);
            this.groupBox2.Controls.Add(this.dGVThongKe);
            this.groupBox2.Controls.Add(this.btnShow);
            this.groupBox2.Controls.Add(this.cBDau);
            this.groupBox2.Controls.Add(this.cBRot);
            this.groupBox2.Controls.Add(this.cBTK);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(141, 512);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 314);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống Kê";
            // 
            // cBHocKy
            // 
            this.cBHocKy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBHocKy.FormattingEnabled = true;
            this.cBHocKy.Location = new System.Drawing.Point(132, 78);
            this.cBHocKy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cBHocKy.Name = "cBHocKy";
            this.cBHocKy.Size = new System.Drawing.Size(199, 31);
            this.cBHocKy.TabIndex = 52;
            this.cBHocKy.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cBHocKy_MouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(39, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 23);
            this.label5.TabIndex = 51;
            this.label5.Text = "Học Kỳ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(39, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 50;
            this.label3.Text = "Môn Học";
            // 
            // cBMonHoc
            // 
            this.cBMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBMonHoc.FormattingEnabled = true;
            this.cBMonHoc.Location = new System.Drawing.Point(132, 133);
            this.cBMonHoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cBMonHoc.Name = "cBMonHoc";
            this.cBMonHoc.Size = new System.Drawing.Size(199, 31);
            this.cBMonHoc.TabIndex = 49;
            this.cBMonHoc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cBMonHoc_MouseClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTim);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cBTimTheo);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(141, 854);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(256, 113);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(104, 67);
            this.txtTim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(143, 30);
            this.txtTim.TabIndex = 2;
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(8, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Tìm theo";
            // 
            // cBTimTheo
            // 
            this.cBTimTheo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBTimTheo.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBTimTheo.FormattingEnabled = true;
            this.cBTimTheo.Items.AddRange(new object[] {
            "Mã SV"});
            this.cBTimTheo.Location = new System.Drawing.Point(104, 27);
            this.cBTimTheo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cBTimTheo.Name = "cBTimTheo";
            this.cBTimTheo.Size = new System.Drawing.Size(143, 31);
            this.cBTimTheo.TabIndex = 0;
            // 
            // FrmDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1601, 967);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button_Excel);
            this.Controls.Add(this.lblsldau);
            this.Controls.Add(this.dGVDiem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDiem";
            this.Load += new System.EventHandler(this.FrmDiem_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVThongKe)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboMaSV;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.ComboBox cBMH;
        private System.Windows.Forms.Label lblMH;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTen;
        private System.Windows.Forms.DataGridView dGVDiem;
        private System.Windows.Forms.Label lblHK;
        private System.Windows.Forms.ComboBox cBHK;
        private System.Windows.Forms.Button btnCK;
        private System.Windows.Forms.Button btnGK;
        private System.Windows.Forms.TextBox txtCK;
        private System.Windows.Forms.TextBox txtGK;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button button_Excel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBMaLop;
        private System.Windows.Forms.Label lblsldau;
        private System.Windows.Forms.DataGridView dGVThongKe;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.CheckBox cBDau;
        private System.Windows.Forms.CheckBox cBRot;
        private System.Windows.Forms.CheckBox cBTK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBMonHoc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cBTimTheo;
        private System.Windows.Forms.ComboBox cBHocKy;
        private System.Windows.Forms.Label label5;
    }
}