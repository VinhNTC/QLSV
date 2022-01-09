
namespace QLSV_GUI
{
    partial class FrmMenu
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
            this.pn_left = new System.Windows.Forms.Panel();
            this.pn_leftcon1 = new System.Windows.Forms.Panel();
            this.menu_left = new System.Windows.Forms.FlowLayoutPanel();
            this.btnqlsv = new System.Windows.Forms.Button();
            this.btnqllh = new System.Windows.Forms.Button();
            this.btnqlmh = new System.Windows.Forms.Button();
            this.btnqldsv = new System.Windows.Forms.Button();
            this.btnDoiPass = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btntt = new System.Windows.Forms.Button();
            this.timedate = new System.Windows.Forms.Timer(this.components);
            this.pn_center = new System.Windows.Forms.Panel();
            this.tabcontrol_center = new DevComponents.DotNetBar.TabControl();
            this.pn_top = new System.Windows.Forms.Panel();
            this.bntZoom = new System.Windows.Forms.Button();
            this.lb_thoigian = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.pn_left.SuspendLayout();
            this.menu_left.SuspendLayout();
            this.pn_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabcontrol_center)).BeginInit();
            this.pn_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_left
            // 
            this.pn_left.AutoSize = true;
            this.pn_left.BackColor = System.Drawing.Color.White;
            this.pn_left.Controls.Add(this.pn_leftcon1);
            this.pn_left.Controls.Add(this.menu_left);
            this.pn_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_left.Location = new System.Drawing.Point(0, 0);
            this.pn_left.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pn_left.Name = "pn_left";
            this.pn_left.Size = new System.Drawing.Size(450, 1050);
            this.pn_left.TabIndex = 1;
            // 
            // pn_leftcon1
            // 
            this.pn_leftcon1.BackgroundImage = global::QLSV_GUI.Properties.Resources.anhmenuprj31;
            this.pn_leftcon1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_leftcon1.Enabled = false;
            this.pn_leftcon1.Location = new System.Drawing.Point(0, 0);
            this.pn_leftcon1.Margin = new System.Windows.Forms.Padding(0);
            this.pn_leftcon1.Name = "pn_leftcon1";
            this.pn_leftcon1.Size = new System.Drawing.Size(450, 386);
            this.pn_leftcon1.TabIndex = 3;
            // 
            // menu_left
            // 
            this.menu_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.menu_left.Controls.Add(this.btnqlsv);
            this.menu_left.Controls.Add(this.btnqllh);
            this.menu_left.Controls.Add(this.btnqlmh);
            this.menu_left.Controls.Add(this.btnqldsv);
            this.menu_left.Controls.Add(this.btnDoiPass);
            this.menu_left.Controls.Add(this.btnDangXuat);
            this.menu_left.Controls.Add(this.btntt);
            this.menu_left.Location = new System.Drawing.Point(0, 391);
            this.menu_left.Margin = new System.Windows.Forms.Padding(0);
            this.menu_left.Name = "menu_left";
            this.menu_left.Size = new System.Drawing.Size(450, 1106);
            this.menu_left.TabIndex = 2;
            // 
            // btnqlsv
            // 
            this.btnqlsv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnqlsv.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnqlsv.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnqlsv.FlatAppearance.BorderSize = 0;
            this.btnqlsv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnqlsv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnqlsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnqlsv.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnqlsv.ForeColor = System.Drawing.Color.White;
            this.btnqlsv.Image = global::QLSV_GUI.Properties.Resources.icons9_student_male_32;
            this.btnqlsv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnqlsv.Location = new System.Drawing.Point(0, 0);
            this.btnqlsv.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnqlsv.Name = "btnqlsv";
            this.btnqlsv.Size = new System.Drawing.Size(450, 77);
            this.btnqlsv.TabIndex = 0;
            this.btnqlsv.Text = "Quản Lý Sinh Viên";
            this.btnqlsv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnqlsv.UseVisualStyleBackColor = false;
            this.btnqlsv.Click += new System.EventHandler(this.btnqlsv_Click);
            // 
            // btnqllh
            // 
            this.btnqllh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnqllh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnqllh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnqllh.FlatAppearance.BorderSize = 0;
            this.btnqllh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnqllh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnqllh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnqllh.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnqllh.ForeColor = System.Drawing.Color.White;
            this.btnqllh.Image = global::QLSV_GUI.Properties.Resources.icons8_google_classroom_32;
            this.btnqllh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnqllh.Location = new System.Drawing.Point(0, 80);
            this.btnqllh.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnqllh.Name = "btnqllh";
            this.btnqllh.Size = new System.Drawing.Size(450, 77);
            this.btnqllh.TabIndex = 6;
            this.btnqllh.Text = "Quản Lý Lớp Học";
            this.btnqllh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnqllh.UseVisualStyleBackColor = false;
            this.btnqllh.Click += new System.EventHandler(this.btnqllh_Click);
            // 
            // btnqlmh
            // 
            this.btnqlmh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnqlmh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnqlmh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnqlmh.FlatAppearance.BorderSize = 0;
            this.btnqlmh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnqlmh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnqlmh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnqlmh.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnqlmh.ForeColor = System.Drawing.Color.White;
            this.btnqlmh.Image = global::QLSV_GUI.Properties.Resources.icons8_book_and_pencil_32;
            this.btnqlmh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnqlmh.Location = new System.Drawing.Point(0, 160);
            this.btnqlmh.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnqlmh.Name = "btnqlmh";
            this.btnqlmh.Size = new System.Drawing.Size(450, 77);
            this.btnqlmh.TabIndex = 4;
            this.btnqlmh.Text = "Quản Lý Môn Học";
            this.btnqlmh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnqlmh.UseVisualStyleBackColor = false;
            this.btnqlmh.Click += new System.EventHandler(this.btnqlmh_Click);
            // 
            // btnqldsv
            // 
            this.btnqldsv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnqldsv.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnqldsv.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnqldsv.FlatAppearance.BorderSize = 0;
            this.btnqldsv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnqldsv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnqldsv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnqldsv.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnqldsv.ForeColor = System.Drawing.Color.White;
            this.btnqldsv.Image = global::QLSV_GUI.Properties.Resources.icons8_true_false_32;
            this.btnqldsv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnqldsv.Location = new System.Drawing.Point(0, 240);
            this.btnqldsv.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnqldsv.Name = "btnqldsv";
            this.btnqldsv.Size = new System.Drawing.Size(450, 77);
            this.btnqldsv.TabIndex = 1;
            this.btnqldsv.Text = "Quản Lý Điểm";
            this.btnqldsv.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnqldsv.UseVisualStyleBackColor = false;
            this.btnqldsv.Click += new System.EventHandler(this.btnqldsv_Click);
            // 
            // btnDoiPass
            // 
            this.btnDoiPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnDoiPass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoiPass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDoiPass.FlatAppearance.BorderSize = 0;
            this.btnDoiPass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnDoiPass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnDoiPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiPass.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiPass.ForeColor = System.Drawing.Color.White;
            this.btnDoiPass.Image = global::QLSV_GUI.Properties.Resources.icons8_help_32;
            this.btnDoiPass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoiPass.Location = new System.Drawing.Point(0, 320);
            this.btnDoiPass.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnDoiPass.Name = "btnDoiPass";
            this.btnDoiPass.Size = new System.Drawing.Size(450, 77);
            this.btnDoiPass.TabIndex = 10;
            this.btnDoiPass.Text = "Trợ Giúp";
            this.btnDoiPass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDoiPass.UseVisualStyleBackColor = false;
            this.btnDoiPass.Click += new System.EventHandler(this.btnDoiPass_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDangXuat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnDangXuat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Image = global::QLSV_GUI.Properties.Resources.icons8_Logout_32;
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 400);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(450, 77);
            this.btnDangXuat.TabIndex = 11;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btntt
            // 
            this.btntt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btntt.Dock = System.Windows.Forms.DockStyle.Top;
            this.btntt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btntt.FlatAppearance.BorderSize = 0;
            this.btntt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btntt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.btntt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntt.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntt.ForeColor = System.Drawing.Color.White;
            this.btntt.Image = global::QLSV_GUI.Properties.Resources.icons8_information_32;
            this.btntt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btntt.Location = new System.Drawing.Point(0, 480);
            this.btntt.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btntt.Name = "btntt";
            this.btntt.Size = new System.Drawing.Size(450, 77);
            this.btntt.TabIndex = 9;
            this.btntt.Text = "Thông Tin";
            this.btntt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btntt.UseVisualStyleBackColor = false;
            this.btntt.Click += new System.EventHandler(this.btntt_Click);
            // 
            // timedate
            // 
            this.timedate.Interval = 1000;
            this.timedate.Tick += new System.EventHandler(this.timedate_Tick);
            // 
            // pn_center
            // 
            this.pn_center.AutoSize = true;
            this.pn_center.Controls.Add(this.tabcontrol_center);
            this.pn_center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_center.Location = new System.Drawing.Point(450, 66);
            this.pn_center.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pn_center.Name = "pn_center";
            this.pn_center.Size = new System.Drawing.Size(1470, 984);
            this.pn_center.TabIndex = 3;
            // 
            // tabcontrol_center
            // 
            this.tabcontrol_center.CanReorderTabs = true;
            this.tabcontrol_center.CloseButtonPosition = DevComponents.DotNetBar.eTabCloseButtonPosition.Right;
            this.tabcontrol_center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcontrol_center.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabcontrol_center.Location = new System.Drawing.Point(0, 0);
            this.tabcontrol_center.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabcontrol_center.Name = "tabcontrol_center";
            this.tabcontrol_center.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tabcontrol_center.SelectedTabIndex = 0;
            this.tabcontrol_center.Size = new System.Drawing.Size(1470, 984);
            this.tabcontrol_center.TabIndex = 1;
            this.tabcontrol_center.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
            this.tabcontrol_center.Text = "tabControl1";
            // 
            // pn_top
            // 
            this.pn_top.BackgroundImage = global::QLSV_GUI.Properties.Resources.panner_top_21;
            this.pn_top.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pn_top.Controls.Add(this.bntZoom);
            this.pn_top.Controls.Add(this.lb_thoigian);
            this.pn_top.Controls.Add(this.btn_exit);
            this.pn_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_top.Location = new System.Drawing.Point(450, 0);
            this.pn_top.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pn_top.Name = "pn_top";
            this.pn_top.Size = new System.Drawing.Size(1470, 66);
            this.pn_top.TabIndex = 2;
            // 
            // bntZoom
            // 
            this.bntZoom.AutoSize = true;
            this.bntZoom.BackColor = System.Drawing.Color.Snow;
            this.bntZoom.Dock = System.Windows.Forms.DockStyle.Right;
            this.bntZoom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Snow;
            this.bntZoom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.bntZoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntZoom.Image = global::QLSV_GUI.Properties.Resources.icons8_zoom_out_32;
            this.bntZoom.Location = new System.Drawing.Point(1336, 0);
            this.bntZoom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bntZoom.Name = "bntZoom";
            this.bntZoom.Size = new System.Drawing.Size(65, 62);
            this.bntZoom.TabIndex = 4;
            this.bntZoom.UseVisualStyleBackColor = false;
            this.bntZoom.Click += new System.EventHandler(this.bntZoom_Click);
            // 
            // lb_thoigian
            // 
            this.lb_thoigian.BackColor = System.Drawing.Color.White;
            this.lb_thoigian.Dock = System.Windows.Forms.DockStyle.Left;
            this.lb_thoigian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lb_thoigian.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_thoigian.ForeColor = System.Drawing.Color.Blue;
            this.lb_thoigian.Image = global::QLSV_GUI.Properties.Resources.panner_top_21;
            this.lb_thoigian.Location = new System.Drawing.Point(0, 0);
            this.lb_thoigian.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_thoigian.Name = "lb_thoigian";
            this.lb_thoigian.Size = new System.Drawing.Size(218, 62);
            this.lb_thoigian.TabIndex = 1;
            this.lb_thoigian.Text = "Time";
            this.lb_thoigian.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_exit
            // 
            this.btn_exit.AutoSize = true;
            this.btn_exit.BackColor = System.Drawing.Color.Snow;
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Snow;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Image = global::QLSV_GUI.Properties.Resources.icons8_cancel_32;
            this.btn_exit.Location = new System.Drawing.Point(1401, 0);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(65, 62);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1050);
            this.Controls.Add(this.pn_center);
            this.Controls.Add(this.pn_top);
            this.Controls.Add(this.pn_left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMenu_Load);
            this.pn_left.ResumeLayout(false);
            this.menu_left.ResumeLayout(false);
            this.pn_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabcontrol_center)).EndInit();
            this.pn_top.ResumeLayout(false);
            this.pn_top.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pn_left;
        private System.Windows.Forms.Panel pn_leftcon1;
        private System.Windows.Forms.FlowLayoutPanel menu_left;
        private System.Windows.Forms.Button btnqlsv;
        private System.Windows.Forms.Button btnqldsv;
        private System.Windows.Forms.Button btnqlmh;
        private System.Windows.Forms.Timer timedate;
        private System.Windows.Forms.Panel pn_top;
        private System.Windows.Forms.Label lb_thoigian;
        private System.Windows.Forms.Panel pn_center;
        private System.Windows.Forms.Button btnqllh;
        private System.Windows.Forms.Button btntt;
        private DevComponents.DotNetBar.TabControl tabcontrol_center;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button bntZoom;
        private System.Windows.Forms.Button btnDoiPass;
        private System.Windows.Forms.Button btnDangXuat;
    }
}

