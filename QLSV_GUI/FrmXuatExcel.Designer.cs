
namespace QLSV_GUI
{
    partial class frmXuatExcel
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
            this.label1 = new System.Windows.Forms.Label();
            this.xuatBang_duongdan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.xuatBang_ten = new System.Windows.Forms.TextBox();
            this.buttonxuatBang_duongDan = new System.Windows.Forms.Button();
            this.xuatBang_xuat = new System.Windows.Forms.Button();
            this.xuatBang_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 41;
            this.label1.Text = "Địa chỉ:";
            // 
            // xuatBang_duongdan
            // 
            this.xuatBang_duongdan.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.xuatBang_duongdan.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuatBang_duongdan.Location = new System.Drawing.Point(113, 71);
            this.xuatBang_duongdan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xuatBang_duongdan.Name = "xuatBang_duongdan";
            this.xuatBang_duongdan.ReadOnly = true;
            this.xuatBang_duongdan.Size = new System.Drawing.Size(504, 28);
            this.xuatBang_duongdan.TabIndex = 42;
            this.xuatBang_duongdan.Text = "C:\\Users\\";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 128);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 43;
            this.label2.Text = "Tên file:";
            // 
            // xuatBang_ten
            // 
            this.xuatBang_ten.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.xuatBang_ten.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuatBang_ten.Location = new System.Drawing.Point(114, 125);
            this.xuatBang_ten.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xuatBang_ten.Name = "xuatBang_ten";
            this.xuatBang_ten.Size = new System.Drawing.Size(504, 28);
            this.xuatBang_ten.TabIndex = 44;
            // 
            // buttonxuatBang_duongDan
            // 
            this.buttonxuatBang_duongDan.AutoSize = true;
            this.buttonxuatBang_duongDan.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonxuatBang_duongDan.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonxuatBang_duongDan.Location = new System.Drawing.Point(635, 69);
            this.buttonxuatBang_duongDan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonxuatBang_duongDan.Name = "buttonxuatBang_duongDan";
            this.buttonxuatBang_duongDan.Size = new System.Drawing.Size(65, 30);
            this.buttonxuatBang_duongDan.TabIndex = 45;
            this.buttonxuatBang_duongDan.Text = "...";
            this.buttonxuatBang_duongDan.UseVisualStyleBackColor = false;
            this.buttonxuatBang_duongDan.Click += new System.EventHandler(this.buttonxuatBang_duongDan_Click);
            // 
            // xuatBang_xuat
            // 
            this.xuatBang_xuat.BackColor = System.Drawing.Color.Red;
            this.xuatBang_xuat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.xuatBang_xuat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.xuatBang_xuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xuatBang_xuat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuatBang_xuat.Location = new System.Drawing.Point(113, 191);
            this.xuatBang_xuat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xuatBang_xuat.Name = "xuatBang_xuat";
            this.xuatBang_xuat.Size = new System.Drawing.Size(226, 51);
            this.xuatBang_xuat.TabIndex = 46;
            this.xuatBang_xuat.Text = "Xuất";
            this.xuatBang_xuat.UseVisualStyleBackColor = false;
            this.xuatBang_xuat.Click += new System.EventHandler(this.xuatBang_xuat_Click);
            // 
            // xuatBang_Thoat
            // 
            this.xuatBang_Thoat.BackColor = System.Drawing.Color.Red;
            this.xuatBang_Thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.xuatBang_Thoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.xuatBang_Thoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.xuatBang_Thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xuatBang_Thoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xuatBang_Thoat.Location = new System.Drawing.Point(392, 191);
            this.xuatBang_Thoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.xuatBang_Thoat.Name = "xuatBang_Thoat";
            this.xuatBang_Thoat.Size = new System.Drawing.Size(226, 51);
            this.xuatBang_Thoat.TabIndex = 47;
            this.xuatBang_Thoat.Text = "Thoát";
            this.xuatBang_Thoat.UseVisualStyleBackColor = false;
            this.xuatBang_Thoat.Click += new System.EventHandler(this.xuatBang_Thoat_Click);
            // 
            // frmXuatExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(730, 300);
            this.Controls.Add(this.xuatBang_Thoat);
            this.Controls.Add(this.xuatBang_xuat);
            this.Controls.Add(this.buttonxuatBang_duongDan);
            this.Controls.Add(this.xuatBang_ten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.xuatBang_duongdan);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmXuatExcel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xuất Excel";
            this.Load += new System.EventHandler(this.frmXuatExcel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox xuatBang_duongdan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox xuatBang_ten;
        private System.Windows.Forms.Button buttonxuatBang_duongDan;
        private System.Windows.Forms.Button xuatBang_xuat;
        private System.Windows.Forms.Button xuatBang_Thoat;
    }
}