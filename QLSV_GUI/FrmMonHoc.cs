using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_GUI
{
    public partial class FrmMonHoc : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-FMU45E7\\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True");
        string flag;
        string MaMH;
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        MonHocBLL bllMH;
        public FrmMonHoc()
        {
            InitializeComponent();
            bllMH = new MonHocBLL();
        }
        public FrmMenu frm;
        public delegate void _dongTap();
        public _dongTap DongTap;
        private void button1_Click(object sender, EventArgs e)
        {
            DongTap();
        }
        public void ShowAllMonHoc()
        {
            DataTable dt = bllMH.getALLMonHoc();
            dGVQLMH.DataSource = dt;
        }
        private void FrmMonHoc_Load(object sender, EventArgs e)
        {
            ShowAllMonHoc();

            dGVQLMH.Columns[0].HeaderText = "Mã Môn Học";
            dGVQLMH.Columns[1].HeaderText = "Tên Môn Học";
            dGVQLMH.Columns[2].HeaderText = "Số Tín Chỉ";
            dGVQLMH.Columns[3].HeaderText = "Học Phần Tiên Quyết";
            dGVQLMH.Columns[4].HeaderText = "Học Phần Học Trước";
            dGVQLMH.Columns[5].HeaderText = "Mã Học Kỳ";

            gBThongTin.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            //btnTim.Enabled = false;
            btnLuu.Enabled = false;
            btnReset.Enabled = false;
            btnReturn.Enabled = false;
        }

        private void cBHK_MouseClick(object sender, MouseEventArgs e)
        {
            da = new SqlDataAdapter("SELECT * FROM HocKy", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cBHK.DisplayMember = "MaHK";
            cBHK.ValueMember = "MaHK";
            cBHK.DataSource = dt;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            // tạo SQL string goi thu tuc da xay dung va truyen tham so la dia chi nhap vao trong textBox
            string lSQLString = string.Format("execute thongkemonhoc '{0}'", this.cBHK.Text);
            // tao SQL command
            cmd = new SqlCommand(lSQLString);
            //open connection
            con.Open();
            //gan connection cho command
            cmd.Connection = con;
            //doc du lieu tu SQL
            SqlDataReader lDr = cmd.ExecuteReader();
            //tao DataTable
            DataTable lTable = new DataTable();
            //load du lieu tu DataReader -> DataTable
            lTable.Load(lDr);
            //gan datasource cho datagridview
            this.dGVQLMH.DataSource = lTable;
            //Close connection
            con.Close();

            btnReset.Enabled = true;
        }

        private void txtMaMH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtTenMH.Focus();
            }
        }

        private void txtTenMH_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cBTinChi.Focus();
            }
        }

        private void cBTinChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtHPTQ.Focus();
            }
        }

        private void txtHPTQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtHPHT.Focus();
            }
        }

        private void txtHPHT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cBMaHK.Focus();
            }
        }

        //private void cBTinChi_MouseClick(object sender, MouseEventArgs e)
        //{
        //    da = new SqlDataAdapter("SELECT DISTINCT SoTinChi FROM MonHoc", con);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    cBTinChi.DisplayMember = "SoTinChi";
        //    cBTinChi.ValueMember = "SoTinchi";
        //    cBTinChi.DataSource = dt;
        //}

        private bool CheckExitMaMH()
        {
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = "Data Source=DESKTOP-MQNB7VA\\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True";
            con.Open();
            string MaMH = txtMaMH.Text.Trim();
            string query = "SELECT MaMH FROM MonHoc WHERE MaMH ='" + MaMH + "'";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void txtMaMH_Validating(object sender, CancelEventArgs e)
        {
            string MaMH = txtMaMH.Text.Trim();
            if (string.IsNullOrEmpty(txtMaMH.Text))
            {
                e.Cancel = true;
                txtMaMH.Focus();
                errMaMH.SetError(txtMaMH, "Vui lòng nhập mã môn học!!!");
            }
            else if (CheckExitMaMH())
            {
                e.Cancel = true;
                txtMaMH.Focus();
                errMaMH.SetError(txtMaMH, "Mã môn học đã tồn tại!!!");
            }
            else if (MaMH.Length != 8)
            {
                e.Cancel = true;
                txtMaMH.Focus();
                errMaMH.SetError(txtMaMH, "Mã môn học không hợp lệ!!!");
            }
            else
            {
                e.Cancel = false;
                errMaMH.Clear();
            }
        }

        private void txtTenMH_Validating(object sender, CancelEventArgs e)
        {
            string TenMH = txtTenMH.Text.Trim();

            if (string.IsNullOrEmpty(TenMH))
            {
                e.Cancel = true;
                errTenMH.SetError(txtTenMH, "Vui lòng nhập tên môn học!!!");
            }
            else if (TenMH.Length < 5)
            {
                e.Cancel = true;
                errTenMH.SetError(txtTenMH, "Tên môn học không hợp lệ!!!");
            }
            else
            {
                e.Cancel = false;
                errTenMH.Clear();
            }
        }

        private void cBTinChi_Validating(object sender, CancelEventArgs e)
        {
            string TinChi = cBTinChi.Text.Trim();
            if (string.IsNullOrEmpty(TinChi))
            {
                e.Cancel = true;
                errTinChi.SetError(cBTinChi, "Vui lòng chọn tín chỉ!!!");
            }
            
            else
            {
                e.Cancel = false;
                errTinChi.Clear();
            }
        }

        private void txtHPTQ_Validating(object sender, CancelEventArgs e)
        {
            string HPTQ = txtHPTQ.Text.Trim();
            if (string.IsNullOrEmpty(HPTQ))
            {
                e.Cancel = true;
                errHPTQ.SetError(txtHPTQ, "Vui lòng nhập học tiên quyết!!!");
            }

            else
            {
                e.Cancel = false;
                errHPTQ.Clear();
            }
        }

        private void txtHPHT_Validating(object sender, CancelEventArgs e)
        {
            string HPHT = txtHPHT.Text.Trim();
            if (string.IsNullOrEmpty(HPHT))
            {
                e.Cancel = true;
                errHPHT.SetError(txtHPHT, "Vui lòng nhập học học trước!!!");
            }

            else
            {
                e.Cancel = false;
                errHPHT.Clear();
            }
        }

        private void cBMaHK_Validating(object sender, CancelEventArgs e)
        {
            string MaHK = cBMaHK.Text.Trim();
            if (string.IsNullOrEmpty(MaHK))
            {
                e.Cancel = true;
                errTinChi.SetError(cBTinChi, "Vui lòng chọn mã học kì!!!");
            }

            else
            {
                e.Cancel = false;
                errMaHK.Clear();
            }
        }

        //private void cBMaHK_MouseClick(object sender, MouseEventArgs e)
        //{
        //    da = new SqlDataAdapter("SELECT * FROM HocKy", con);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    cBHK.DisplayMember = "MaHK";
        //    cBHK.ValueMember = "MaHK";
        //    cBHK.DataSource = dt;
        //}

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = "add";
            gBThongTin.Enabled = true;
            txtMaMH.Focus();
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            //btnTim.Enabled = false;
            btnLuu.Enabled = true;
            btnReset.Enabled = true;
            btnReturn.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            flag = "Delete";
            gBThongTin.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnReset.Enabled = true;
            btnReturn.Enabled = true;

            DialogResult isCancel = MessageBox.Show("Bạn có muốn xóa không???", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (isCancel == DialogResult.Yes)
            {
                int rowIndex = dGVQLMH.CurrentCell.RowIndex;
                dGVQLMH.Rows.RemoveAt(rowIndex);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = "Edit";
            gBThongTin.Enabled = true;
            txtMaMH.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnReset.Enabled = true;
            btnReturn.Enabled = false;
        }
        public void Reset()
        {
            txtMaMH.Text = "";
            txtTenMH.Text = "";
            cBTinChi.Text = "";
            txtHPTQ.Text = "";
            txtHPHT.Text = "";
            cBMaHK.Text = "";
            rdbMaMH.Checked = false;
            rdbTenMH.Checked = false;
            txtSearch.Text = "";
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            //AutoValidate = AutoValidate.Disable;
            //CausesValidation = false;

            DialogResult isCancel = MessageBox.Show("Bạn có muốn làm mới thao tác không???", "Xác nhận Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (isCancel == DialogResult.Yes)
            {
                Reset();

                ShowAllMonHoc();

                dGVQLMH.Columns[0].HeaderText = "Mã Môn Học";
                dGVQLMH.Columns[1].HeaderText = "Tên Môn Học";
                dGVQLMH.Columns[2].HeaderText = "Số Tín Chỉ";
                dGVQLMH.Columns[3].HeaderText = "Học Phần Tiên Quyết";
                dGVQLMH.Columns[4].HeaderText = "Học Phần Học Trước";
                dGVQLMH.Columns[5].HeaderText = "Mã Học Kỳ";

                gBThongTin.Enabled = false;
                //txtMaSV.Focus();
                btnThem.Enabled = true;
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                //btnTim.Enabled = false;
                btnLuu.Enabled = true;
                btnReset.Enabled = true;
                //cBSapXep.Focus();

                //errMaSV.Clear();
                //errTenSV.Clear();
                //errGioiTinh.Clear();
                //errNgaySinh.Clear();
                //errDiaChi.Clear();
                //errDanToc.Clear();
                //errSDT.Clear();
                //errEmail.Clear();
                //errMaLop.Clear();
            }
            else
            {
                return;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            DialogResult isCancel = MessageBox.Show("Bạn có muốn Return thao tác không???", "Xác nhận Return", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (isCancel == DialogResult.Yes)
            {
                DataTable dt = bllMH.getALLMonHoc();
                dGVQLMH.DataSource = dt;
            }

            btnLuu.Enabled = false;
            btnReset.Enabled = true;
            btnReturn.Enabled = false;
        }

        private void button_Excel_Click(object sender, EventArgs e)
        {
            frmXuatExcel x = new frmXuatExcel();
            x.BangThongTin = dGVQLMH;
            x.Show();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == "add")
            {
                MonHoc mh = new MonHoc();
                mh.MaMH = txtMaMH.Text;
                mh.TenMH = txtTenMH.Text;
                mh.SoTinChi = int.Parse(cBTinChi.Text);
                mh.HPTienQuyet = txtHPTQ.Text;
                mh.HPHocTruoc = txtHPHT.Text;
                mh.MaHK = cBMaHK.Text;
                if (bllMH.InsertMonHoc(mh))
                {
                    ShowAllMonHoc();
                    MessageBox.Show("Thêm thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                btnThem.Enabled = false;
            }
            else if (flag == "Edit")
            {
                MonHoc mh = new MonHoc();
                mh.MaMH = txtMaMH.Text;
                mh.TenMH = txtTenMH.Text;
                mh.SoTinChi = int.Parse(cBTinChi.Text);
                mh.HPTienQuyet = txtHPTQ.Text;
                mh.HPHocTruoc = txtHPHT.Text;
                mh.MaHK = cBMaHK.Text;
                if (bllMH.UpdateMonHoc(mh))
                {
                    ShowAllMonHoc();
                    MessageBox.Show("Sửa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (flag == "Delete")
            {
                MonHoc mh = new MonHoc();
                mh.MaMH = MaMH;
                if (bllMH.DeteleMonHoc(mh))
                {
                    ShowAllMonHoc();
                    MessageBox.Show("Xóa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dGVQLMH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dGVQLMH.CurrentCell.RowIndex;
            DataTable dt = (DataTable)dGVQLMH.DataSource;
            if (dt.Rows.Count > 0)
            {
                gBThongTin.Enabled = false;
                btnLuu.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnReset.Enabled = true;

                MaMH = dGVQLMH.Rows[index].Cells[0].Value.ToString();
                txtMaMH.Text = dGVQLMH.Rows[index].Cells[0].Value.ToString();
                txtTenMH.Text = dGVQLMH.Rows[index].Cells[1].Value.ToString();
                cBTinChi.Text = dGVQLMH.Rows[index].Cells[2].Value.ToString();
                txtHPTQ.Text = dGVQLMH.Rows[index].Cells[3].Value.ToString();
                txtHPHT.Text = dGVQLMH.Rows[index].Cells[4].Value.ToString();
                cBMaHK.Text = dGVQLMH.Rows[index].Cells[5].Value.ToString();
            }
        }

        private void cBMaHK_MouseClick(object sender, MouseEventArgs e)
        {
            da = new SqlDataAdapter("SELECT * FROM HocKy", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cBMaHK.DisplayMember = "MaHK";
            cBMaHK.ValueMember = "MaHK";
            cBMaHK.DataSource = dt;
        }

        private void cBTinChi_MouseClick(object sender, MouseEventArgs e)
        {
            da = new SqlDataAdapter("SELECT DISTINCT SoTinChi FROM MonHoc", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cBTinChi.DisplayMember = "SoTinChi";
            cBTinChi.ValueMember = "SoTinchi";
            cBTinChi.DataSource = dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rdbMaMH.Checked) //tìm theo mã MH
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM MonHoc WHERE MaMH LIKE '%" + txtSearch.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dGVQLMH.DataSource = dt;
            }
            else   //tìm theo tên MH
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM MonHoc WHERE TenMH LIKE '%" + txtSearch.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dGVQLMH.DataSource = dt;
            }
            btnReset.Enabled = true;
        }
    }
}
