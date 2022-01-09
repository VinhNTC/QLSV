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
    public partial class FrmLopHoc : Form
    {
        string flag;
        string MaLop;
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        LopHocBLL bllLH;
        public FrmLopHoc()
        {
            InitializeComponent();
            bllLH = new LopHocBLL();
        }
        public FrmMenu frm;
        public delegate void _dongTap();
        public _dongTap DongTap;

        private void button1_Click(object sender, EventArgs e)
        {
            DongTap();
        }
        public void ShowAllLopHoc()
        {
            DataTable dt = bllLH.getALLLopHoc();
            dGVQLLH.DataSource = dt;
        }

        private void FrmLopHoc_Load(object sender, EventArgs e)
        {
            ShowAllLopHoc();

            dGVQLLH.Columns[0].HeaderText = "Mã Lớp Học";
            dGVQLLH.Columns[1].HeaderText = "Tên Lớp Học";

            gBThongTinLop.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            //btnTim.Enabled = false;
            btnLuu.Enabled = false;
            btnReset.Enabled = false;
            btnReturn.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = "add";
            gBThongTinLop.Enabled = true;
            txtMaLop.Focus();
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            //btnTim.Enabled = false;
            btnLuu.Enabled = true;
            btnReset.Enabled = true;
            btnReturn.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == "add")
            {
                LopHoc lh = new LopHoc();
                lh.MaLop = txtMaLop.Text;
                lh.TenLop = txtTenLop.Text;
                if (bllLH.InsertLopHoc(lh))
                {
                    ShowAllLopHoc();
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
                LopHoc lh = new LopHoc();
                lh.MaLop = MaLop;
                lh.TenLop = txtMaLop.Text;
                lh.TenLop = txtTenLop.Text;
                if (bllLH.UpdateLopHoc(lh))
                {
                    ShowAllLopHoc();
                    MessageBox.Show("Sửa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if (flag == "Delete")
            {
                LopHoc lh = new LopHoc();
                lh.MaLop = MaLop;
                if (bllLH.DeteleLopHoc(lh))
                {
                    ShowAllLopHoc();
                    MessageBox.Show("Xóa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            flag = "Delete";
            gBThongTinLop.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnReset.Enabled = true;
            btnReturn.Enabled = true;

            DialogResult isCancel = MessageBox.Show("Bạn có muốn xóa không???", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (isCancel == DialogResult.Yes)
            {
                int rowIndex = dGVQLLH.CurrentCell.RowIndex;
                dGVQLLH.Rows.RemoveAt(rowIndex);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = "Edit";
            gBThongTinLop.Enabled = true;
            txtMaLop.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnReset.Enabled = true;
            btnReturn.Enabled = false;
        }
        public void Reset()
        {
            txtMaLop.Text = "";
            txtTenLop.Text = "";
            rdbMaLop.Checked = false;
            rdbTenLop.Checked = false;
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
                ShowAllLopHoc();

                dGVQLLH.Columns[0].HeaderText = "Mã Lớp Học";
                dGVQLLH.Columns[1].HeaderText = "Tên Lớp Học";
                gBThongTinLop.Enabled = false;
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
                DataTable dt = bllLH.getALLLopHoc();
                dGVQLLH.DataSource = dt;
            }

            btnLuu.Enabled = false;
            btnReset.Enabled = true;
            btnReturn.Enabled = false;
        }

        private void dGVQLLH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dGVQLLH.CurrentCell.RowIndex;
            DataTable dt = (DataTable)dGVQLLH.DataSource;
            if (dt.Rows.Count > 0)
            {
                gBThongTinLop.Enabled = false;
                btnLuu.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnReset.Enabled = true;

                MaLop = dGVQLLH.Rows[index].Cells[0].Value.ToString();
                txtMaLop.Text = dGVQLLH.Rows[index].Cells[0].Value.ToString();
                txtTenLop.Text = dGVQLLH.Rows[index].Cells[1].Value.ToString();
            }
        }

        private void txtMaLop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtTenLop.Focus();
            }
        }
        private bool CheckExitMaLop()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-FMU45E7\\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True";
            con.Open();
            string MaLop = txtMaLop.Text.Trim();
            string query = "SELECT MaLop FROM Lop WHERE MaLop ='" + MaLop + "'";
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

        private void txtMaLop_Validating(object sender, CancelEventArgs e)
        {
            string MaLop = txtMaLop.Text.Trim();
            if (string.IsNullOrEmpty(MaLop))
            {
                e.Cancel = true;
                errMaLop.SetError(txtMaLop, "Vui lòng nhập mã lớp!!!");
            }
            else if (CheckExitMaLop())
            {
                e.Cancel = true;
                errMaLop.SetError(txtMaLop, "Mã lớp bị trùng!!!");
            }
            else
            {
                e.Cancel = false;
                errMaLop.Clear();
            }
        }

        private void txtTenLop_Validating(object sender, CancelEventArgs e)
        {
            string TenLop = txtTenLop.Text.Trim();

            if (string.IsNullOrEmpty(TenLop))
            {
                e.Cancel = true;
                errTenLop.SetError(txtTenLop, "Vui lòng nhập tên lớp!!!");
            }
            else if (TenLop.Length < 5)
            {
                e.Cancel = true;
                errTenLop.SetError(txtTenLop, "Tên lớp không hợp lệ!!!");
            }
            else
            {
                e.Cancel = false;
                errTenLop.Clear();
            }
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-FMU45E7\\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True");

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rdbMaLop.Checked) //tìm theo mã lớp
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Lop WHERE MaLop LIKE '%" + txtSearch.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dGVQLLH.DataSource = dt;
            }
            else   //tìm theo tên lớp
            {
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Lop WHERE TenLop LIKE '%" + txtSearch.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dGVQLLH.DataSource = dt;
            }
            btnReset.Enabled = true;
        }

        private void button_Excel_Click(object sender, EventArgs e)
        {
            frmXuatExcel x = new frmXuatExcel();
            x.BangThongTin = dGVQLLH;
            x.Show();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            // tạo SQL string goi thu tuc da xay dung va truyen tham so la dia chi nhap vao trong textBox
            string lSQLString = string.Format("execute SiSoLop '{0}'", this.cBMaLop.Text);
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
            this.dGVQLLH.DataSource = lTable;
            //Close connection
            con.Close();

            btnReset.Enabled = true;
        }

        private void cBMaLop_MouseClick(object sender, MouseEventArgs e)
        {
            da = new SqlDataAdapter("SELECT * FROM Lop", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cBMaLop.DisplayMember = "MaLop";
            cBMaLop.ValueMember = "MaLop";
            cBMaLop.DataSource = dt;
        }
    }
}



