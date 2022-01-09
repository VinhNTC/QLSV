
namespace QLSV_GUI
{
    partial class FrmTroGiup
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpasscu = new System.Windows.Forms.TextBox();
            this.txtpassmoi = new System.Windows.Forms.TextBox();
            this.txtxacnhan = new System.Windows.Forms.TextBox();
            this.cBshowpass = new System.Windows.Forms.CheckBox();
            this.btndoipass = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.errpasscu = new System.Windows.Forms.ErrorProvider(this.components);
            this.errpassmoi = new System.Windows.Forms.ErrorProvider(this.components);
            this.errxacnhan = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.erruser = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errpasscu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errpassmoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errxacnhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erruser)).BeginInit();
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
            this.label1.Text = "TRỢ GIÚP";
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
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(619, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 41);
            this.label2.TabIndex = 6;
            this.label2.Text = "Đổi Mật Khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mật khẩu hiện tại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mật khẩu mới";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 30);
            this.label6.TabIndex = 10;
            this.label6.Text = "Xác nhận mật khẩu";
            // 
            // txtpasscu
            // 
            this.txtpasscu.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpasscu.Location = new System.Drawing.Point(285, 123);
            this.txtpasscu.Name = "txtpasscu";
            this.txtpasscu.Size = new System.Drawing.Size(251, 37);
            this.txtpasscu.TabIndex = 12;
            this.txtpasscu.UseSystemPasswordChar = true;
            this.txtpasscu.Validating += new System.ComponentModel.CancelEventHandler(this.txtpasscu_Validating);
            // 
            // txtpassmoi
            // 
            this.txtpassmoi.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassmoi.Location = new System.Drawing.Point(285, 204);
            this.txtpassmoi.Name = "txtpassmoi";
            this.txtpassmoi.Size = new System.Drawing.Size(251, 37);
            this.txtpassmoi.TabIndex = 13;
            this.txtpassmoi.UseSystemPasswordChar = true;
            // 
            // txtxacnhan
            // 
            this.txtxacnhan.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtxacnhan.Location = new System.Drawing.Point(285, 285);
            this.txtxacnhan.Name = "txtxacnhan";
            this.txtxacnhan.Size = new System.Drawing.Size(251, 37);
            this.txtxacnhan.TabIndex = 14;
            this.txtxacnhan.UseSystemPasswordChar = true;
            // 
            // cBshowpass
            // 
            this.cBshowpass.AutoSize = true;
            this.cBshowpass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBshowpass.Location = new System.Drawing.Point(285, 346);
            this.cBshowpass.Name = "cBshowpass";
            this.cBshowpass.Size = new System.Drawing.Size(212, 31);
            this.cBshowpass.TabIndex = 15;
            this.cBshowpass.Text = "Hiển thị mật khẩu";
            this.cBshowpass.UseVisualStyleBackColor = true;
            this.cBshowpass.CheckedChanged += new System.EventHandler(this.cBshowpass_CheckedChanged);
            // 
            // btndoipass
            // 
            this.btndoipass.AutoSize = true;
            this.btndoipass.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btndoipass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btndoipass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aqua;
            this.btndoipass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndoipass.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndoipass.Location = new System.Drawing.Point(320, 418);
            this.btndoipass.Name = "btndoipass";
            this.btndoipass.Size = new System.Drawing.Size(201, 44);
            this.btndoipass.TabIndex = 16;
            this.btndoipass.Text = "Đổi Mật Khẩu";
            this.btndoipass.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtxacnhan);
            this.groupBox1.Controls.Add(this.cBshowpass);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtpassmoi);
            this.groupBox1.Controls.Add(this.btndoipass);
            this.groupBox1.Controls.Add(this.txtpasscu);
            this.groupBox1.Location = new System.Drawing.Point(442, 247);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 500);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // errpasscu
            // 
            this.errpasscu.BlinkRate = 0;
            this.errpasscu.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errpasscu.ContainerControl = this;
            // 
            // errpassmoi
            // 
            this.errpassmoi.BlinkRate = 0;
            this.errpassmoi.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errpassmoi.ContainerControl = this;
            // 
            // errxacnhan
            // 
            this.errxacnhan.BlinkRate = 0;
            this.errxacnhan.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errxacnhan.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 30);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tài khoản";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(285, 41);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(251, 37);
            this.txtUser.TabIndex = 18;
            this.txtUser.Validating += new System.ComponentModel.CancelEventHandler(this.txtUser_Validating);
            // 
            // erruser
            // 
            this.erruser.BlinkRate = 0;
            this.erruser.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.erruser.ContainerControl = this;
            // 
            // FrmTroGiup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1601, 967);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTroGiup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trợ Giúp";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errpasscu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errpassmoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errxacnhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erruser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtpasscu;
        private System.Windows.Forms.TextBox txtpassmoi;
        private System.Windows.Forms.TextBox txtxacnhan;
        private System.Windows.Forms.CheckBox cBshowpass;
        private System.Windows.Forms.Button btndoipass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider errpasscu;
        private System.Windows.Forms.ErrorProvider errpassmoi;
        private System.Windows.Forms.ErrorProvider errxacnhan;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider erruser;
    }
}