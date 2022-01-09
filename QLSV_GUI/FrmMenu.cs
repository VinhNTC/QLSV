using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_GUI
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timedate_Tick(object sender, EventArgs e)
        {
            lb_thoigian.Text = string.Format("{0:HH:mm:ss tt}", DateTime.Now);
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            timedate.Start();
        }

        #region Kiem Tra Tab
        bool trangThai = false;
        private String tentabmo;
        private bool Kiemtramotab(string name)
        {
            for (int i = 0; i < tabcontrol_center.Tabs.Count; i++)
            {
                if (tabcontrol_center.Tabs[i].Text == name)
                {
                    tabcontrol_center.SelectedTabIndex = i;
                    return true;
                }
            }
            return false;
        }
        private void DongTab()
        {
            foreach (TabItem item in tabcontrol_center.Tabs)
            {
                if (item.IsSelected == true)
                {
                    tabcontrol_center.Tabs.Remove(item);
                    return;
                }
            }
        }
        #endregion

        public FrmMenu frm;
        public delegate void _dongTap();
        private void btnqlsv_Click(object sender, EventArgs e)
        {
            this.trangThai = true;
            this.tentabmo = "Quản Lý Sinh Viên";
            if (!Kiemtramotab(tentabmo))
            {
                TabItem t = tabcontrol_center.CreateTab(tentabmo);
                t.Name = "FrmQLSV";
                FrmQLSV frmQLSV = new FrmQLSV()
                {
                    DongTap = new FrmQLSV._dongTap(DongTab),
                    frm = this,
                    TopLevel = false,
                    Dock = DockStyle.Fill,
                };
                t.AttachedControl.Controls.Add(frmQLSV);
                frmQLSV.Show();
                tabcontrol_center.SelectedTabIndex = tabcontrol_center.Tabs.Count - 1;
            }
        }

        private void bntZoom_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnqllh_Click(object sender, EventArgs e)
        {
            this.trangThai = true;
            this.tentabmo = "Quản Lý Lớp Học";
            if (!Kiemtramotab(tentabmo))
            {
                TabItem t = tabcontrol_center.CreateTab(tentabmo);
                t.Name = "FrmLopHoc";

                FrmLopHoc frmQLLH = new FrmLopHoc()
                {
                    DongTap = new FrmLopHoc._dongTap(DongTab),
                    frm = this,
                    TopLevel = false,
                    Dock = DockStyle.Fill,
                };
                t.AttachedControl.Controls.Add(frmQLLH);
                frmQLLH.Show();
                tabcontrol_center.SelectedTabIndex = tabcontrol_center.Tabs.Count - 1;
            }
        }

        private void btnqlmh_Click(object sender, EventArgs e)
        {
            this.trangThai = true;
            this.tentabmo = "Quản Lý Môn Học";
            if (!Kiemtramotab(tentabmo))
            {
                TabItem t = tabcontrol_center.CreateTab(tentabmo);
                t.Name = "FrmMonHoc";

                FrmMonHoc frmQLMH = new FrmMonHoc()
                {
                    DongTap = new FrmMonHoc._dongTap(DongTab),
                    frm = this,
                    TopLevel = false,
                    Dock = DockStyle.Fill,
                };
                t.AttachedControl.Controls.Add(frmQLMH);
                frmQLMH.Show();
                tabcontrol_center.SelectedTabIndex = tabcontrol_center.Tabs.Count - 1;
            }
        }

        private void btnqldsv_Click(object sender, EventArgs e)
        {
            this.trangThai = true;
            this.tentabmo = "Quản Lý Điểm Sinh Viên";
            if (!Kiemtramotab(tentabmo))
            {
                TabItem t = tabcontrol_center.CreateTab(tentabmo);
                t.Name = "FrmDiem";

                FrmDiem frmQLD = new FrmDiem()
                {
                    DongTap = new FrmDiem._dongTap(DongTab),
                    frm = this,
                    TopLevel = false,
                    Dock = DockStyle.Fill,
                };
                t.AttachedControl.Controls.Add(frmQLD);
                frmQLD.Show();
                tabcontrol_center.SelectedTabIndex = tabcontrol_center.Tabs.Count - 1;
            }
        }

        private void btntt_Click(object sender, EventArgs e)
        {
            //FrmThongTin frm = new FrmThongTin();
            //frm.Show();

            this.trangThai = true;
            this.tentabmo = "Thông Tin";
            if (!Kiemtramotab(tentabmo))
            {
                TabItem t = tabcontrol_center.CreateTab(tentabmo);
                t.Name = "FrmThongTin";

                FrmThongTin frmQLD = new FrmThongTin()
                {
                    DongTap = new FrmThongTin._dongTap(DongTab),
                    frm = this,
                    TopLevel = false,
                    Dock = DockStyle.Fill,
                };
                t.AttachedControl.Controls.Add(frmQLD);
                frmQLD.Show();
                tabcontrol_center.SelectedTabIndex = tabcontrol_center.Tabs.Count - 1;
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có muốn xóa đăng xuất không ?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                this.Hide();
                FrmLogin login = new FrmLogin();
                login.ShowDialog();
                this.Close();
            }
        }

        private void btnDoiPass_Click(object sender, EventArgs e)
        {
            this.trangThai = true;
            this.tentabmo = "Trợ Giúp";
            if (!Kiemtramotab(tentabmo))
            {
                TabItem t = tabcontrol_center.CreateTab(tentabmo);
                t.Name = "FrmTroGiup";

                FrmTroGiup frmTG = new FrmTroGiup()
                {
                    DongTap = new FrmTroGiup._dongTap(DongTab),
                    frm = this,
                    TopLevel = false,
                    Dock = DockStyle.Fill,
                };
                t.AttachedControl.Controls.Add(frmTG);
                frmTG.Show();
                tabcontrol_center.SelectedTabIndex = tabcontrol_center.Tabs.Count - 1;
            }
            //MessageBox.Show("Sẽ cập nhật trong thời gian tới!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
