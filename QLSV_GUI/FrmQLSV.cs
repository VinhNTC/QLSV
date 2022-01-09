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
using System.Configuration;
using System.Text.RegularExpressions;

namespace QLSV_GUI
{
    public partial class FrmQLSV : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-FMU45E7\\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True");
        string MaSV;
        string flag;
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        SinhVienBLL bllSV;
        public FrmQLSV()
        {
            InitializeComponent();
            bllSV = new SinhVienBLL();
        }

        public FrmMenu frm;
        public delegate void _dongTap();
        public _dongTap DongTap;

        //public object ConfigurationManager { get; private set; }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DongTap();
            //Application.Exit();
        }
        public void ShowAllSinhVien()
        {
            DataTable dt = bllSV.getAllSinhVien();
            dGVQLSV.DataSource = dt;
        }
        public void Reset()
        {
            txtMaSV.Text = "";
            txtTenSV.Text = "";
            cBGioiTinh.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            txtDiaChi.Text = "";
            cBDT.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
            cBMaLop.Text = "";
            
        }
        private void FrmQLSV_Load(object sender, EventArgs e)
        {
            ShowAllSinhVien();

            //da = new SqlDataAdapter("SELECT * FROM Lop", con);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //cBMaLop.DisplayMember = "MaLop";
            //cBMaLop.ValueMember = "MaLop";
            //cBMaLop.DataSource = dt;
            //da = new SqlDataAdapter("SELECT DISTINCT MaLoP FROM SinhVien", con);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //cBMaLop.DisplayMember = "MaLop";
            //cBMaLop.ValueMember = "MaLop";
            //cBMaLop.DataSource = dt;
            //txtMaSV.Focus();
            dGVQLSV.Columns[0].HeaderText = "Mã Sinh Viên";
            dGVQLSV.Columns[1].HeaderText = "Tên Sinh Viên";
            dGVQLSV.Columns[2].HeaderText = "Giới Tính";
            dGVQLSV.Columns[3].HeaderText = "Ngày Sinh";
            dGVQLSV.Columns[4].HeaderText = "Địa Chỉ";
            dGVQLSV.Columns[5].HeaderText = "Dân Tộc";
            dGVQLSV.Columns[6].HeaderText = "Số Điện Thoại";
            dGVQLSV.Columns[7].HeaderText = "Email";
            dGVQLSV.Columns[8].HeaderText = "Mã Lớp";

            gBThongTin.Enabled = false;
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
            gBThongTin.Enabled = true;
            txtMaSV.Focus();
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
                int rowIndex = dGVQLSV.CurrentCell.RowIndex;
                dGVQLSV.Rows.RemoveAt(rowIndex);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            flag = "Edit";
            gBThongTin.Enabled = true;
            txtMaSV.ReadOnly = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnReset.Enabled = true;
            btnReturn.Enabled = false;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            //AutoValidate = AutoValidate.Disable;
            //CausesValidation = false;

            DialogResult isCancel = MessageBox.Show("Bạn có muốn làm mới thao tác không???", "Xác nhận Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(isCancel == DialogResult.Yes)
            {
                Reset();
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
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(flag == "add")
            {
                SinhVien sv = new SinhVien();
                sv.MaSV = txtMaSV.Text;
                sv.TenSV = txtTenSV.Text;
                sv.GioiTinh = cBGioiTinh.SelectedItem.ToString();
                sv.NgaySinh = dtpNgaySinh.Value;
                sv.DiaChi = txtDiaChi.Text;
                sv.DanToc = cBDT.SelectedItem.ToString();
                sv.SDT = txtSDT.Text;
                sv.Email = txtEmail.Text;
                sv.MaLop = cBMaLop.SelectedItem.ToString();
                if (bllSV.InsertSinhVien(sv))
                {
                    ShowAllSinhVien();
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
                SinhVien sv = new SinhVien();
                sv.MaSV = MaSV;
                sv.TenSV = txtTenSV.Text;
                sv.GioiTinh = cBGioiTinh.SelectedItem.ToString();
                sv.NgaySinh = dtpNgaySinh.Value;
                sv.DiaChi = txtDiaChi.Text;
                sv.DanToc = cBDT.SelectedItem.ToString();
                sv.SDT = txtSDT.Text;
                sv.Email = txtEmail.Text;
                sv.MaLop = cBMaLop.SelectedItem.ToString();
                if (bllSV.UpdateSinhVien(sv))
                {
                    ShowAllSinhVien();
                    MessageBox.Show("Sửa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if(flag == "Delete")
            {
                SinhVien sv = new SinhVien();
                sv.MaSV = MaSV;
                if (bllSV.DeteleSinhVien(sv))
                {
                    ShowAllSinhVien();
                    MessageBox.Show("Xóa thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txtMaSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtTenSV.Focus();
            }
            //if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
        }

        private void txtTenSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cBGioiTinh.Focus();
            }
        }

        private void cBGioiTinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dtpNgaySinh.Focus();
            }
        }

        private void dtpNgaySinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtDiaChi.Focus();
            }
        }

        private void txtDiaChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cBDT.Focus();
            }
        }

        private void cBDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtSDT.Focus();
            }
        }

        private void txtDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtEmail.Focus();
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cBMaLop.Focus();
            }
        }

        private void cBLop_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cBTimTheo.Focus();
            }
        }
        private void cBTimTheo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtTim.Focus();
            }
        }

        private bool CheckExitMaSV()
        {
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = "Data Source=DESKTOP-MQNB7VA\\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True";
            con.Open();
            string MaSV = txtMaSV.Text.Trim();
            string query = "SELECT MaSV FROM SinhVien WHERE MaSV ='" + MaSV + "'";
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
        private void txtMaSV_Validating(object sender, CancelEventArgs e)
        {
            string MaSV = txtMaSV.Text.Trim();
            if (string.IsNullOrEmpty(txtMaSV.Text))
            {
                e.Cancel = true;
                txtMaSV.Focus();
                errMaSV.SetError(txtMaSV, "Vui lòng nhập mã sinh viên!!!");
            }
            else if (CheckExitMaSV())
            {
                e.Cancel = true;
                txtMaSV.Focus();
                errMaSV.SetError(txtMaSV, "Mã sinh viên đã tồn tại!!!");
            }
            else if (MaSV.Length != 13)
            {
                e.Cancel = true;
                txtMaSV.Focus();
                errMaSV.SetError(txtMaSV, "Mã sinh viên không hợp lệ!!!");
            }
            else if (MaSV[7] != '0')
            {
                e.Cancel = true;
                txtMaSV.Focus();
                errMaSV.SetError(txtMaSV, "Mã sinh viên không hợp lệ!!!");
            }
            else if(MaSV[8] != '4')
            {
                e.Cancel = true;
                txtMaSV.Focus();
                errMaSV.SetError(txtMaSV, "Mã sinh viên không hợp lệ!!!");
            }
            else if (MaSV[1] != '5')
            {
                e.Cancel = true;
                txtMaSV.Focus();
                errMaSV.SetError(txtMaSV, "Mã sinh viên không hợp lệ!!!");
            }
            else if(MaSV[2] != '.' && MaSV[5] != '.' && MaSV[9] != '.')
            {
                e.Cancel = true;
                txtMaSV.Focus();
                errMaSV.SetError(txtMaSV, "Mã sinh viên không hợp lệ!!!");
            }
            else
            {
                e.Cancel = false;
                errMaSV.Clear();
            }
        }

        private void txtTenSV_Validating(object sender, CancelEventArgs e)
        {
            string TenSV = txtTenSV.Text.Trim();

            if (string.IsNullOrEmpty(TenSV))
            {
                e.Cancel = true;
                errTenSV.SetError(txtTenSV, "Vui lòng nhập tên sinh viên!!!");
            }
            else if (TenSV.Length < 5)
            {
                e.Cancel = true;
                errTenSV.SetError(txtTenSV, "Tên sinh viên không hợp lệ!!!");
            }
            else
            {
                e.Cancel = false;
                errTenSV.Clear();
            }
        }

        private void cBGioiTinh_Validating(object sender, CancelEventArgs e)
        {
            string GioiTinh = cBGioiTinh.Text.Trim();
            if (string.IsNullOrEmpty(GioiTinh))
            {
                e.Cancel = true;
                errGioiTinh.SetError(cBGioiTinh, "Vui lòng nhập giới tính!!!");
            }
            else if(GioiTinh != "Nam" && GioiTinh != "Nữ")
            {
                e.Cancel = true;
                errGioiTinh.SetError(cBGioiTinh, "Giới tính không hợp lệ!!!");
            }
            else
            {
                e.Cancel = false;
                errGioiTinh.Clear();
            }
        }

        private void dtpNgaySinh_Validating(object sender, CancelEventArgs e)
        {
            int yearCurrent = DateTime.Now.Year;
            int yearBorn = dtpNgaySinh.Value.Year;
            string MaSV = txtMaSV.Text.Trim();
            if (yearBorn >= yearCurrent)
            {
                e.Cancel = true;
                errNgaySinh.SetError(dtpNgaySinh, "Ngày sinh không hợp lệ");
            }
            //else if (MaSV[1] == '4' && (yearCurrent - yearBorn < 21))
            //{
            //    e.Cancel = true;
            //    errNgaySinh.SetError(dtpNgaySinh, "Ngày sinh không hợp lệ!!!");
            //}
            else if (MaSV[1] == '5' && (yearCurrent - yearBorn < 20))
            {
                e.Cancel = true;
                errNgaySinh.SetError(dtpNgaySinh, "Ngày sinh không hợp lệ!!!");
            }
            //else if (MaSV[1] == '6' && (yearCurrent - yearBorn < 19))
            //{
            //    e.Cancel = true;
            //    errNgaySinh.SetError(dtpNgaySinh, "Ngày sinh không hợp lệ!!!");
            //}
            //else if (MaSV[1] == '7' && (yearCurrent - yearBorn < 18))
            //{
            //    e.Cancel = true;
            //    errNgaySinh.SetError(dtpNgaySinh, "Ngày sinh không hợp lệ!!!");
            //}
            else
            {
                e.Cancel = false;
                errNgaySinh.Clear();
            }
        }

        private void txtDiaChi_Validating(object sender, CancelEventArgs e)
        {
            string DiaChi = txtDiaChi.Text.Trim();
            if (string.IsNullOrEmpty(DiaChi))
            {
                e.Cancel = true;
                errDiaChi.SetError(txtDiaChi, "Vui lòng nhập địa chỉ!!!");
            }
            else if (DiaChi.Length < 6 || DiaChi.Length > 17)
            {
                e.Cancel = true;
                errDiaChi.SetError(txtDiaChi, "Địa chỉ không hợp lệ!!!");
            }
            else
            {
                e.Cancel = false;
                errDiaChi.Clear();
            }
        }

        private void cBDT_Validating(object sender, CancelEventArgs e)
        {
            string DanToc = cBDT.Text.Trim();
            if (string.IsNullOrEmpty(DanToc))
            {
                e.Cancel = true;
                errDanToc.SetError(cBDT, "Vui lòng nhập dân tộc!!!");
            }
            else if (DanToc != "Kinh" && DanToc != "DTTS")
            {
                e.Cancel = true;
                errDanToc.SetError(cBDT, "Dân tộc không hợp lệ!!!");
            }
            else
            {
                e.Cancel = false;
                errDanToc.Clear();
            }
        }
        private bool CheckExitSDT()
        {
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = "Data Source=DESKTOP-MQNB7VA\\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True";
            con.Open();
            string SDT = txtSDT.Text.Trim();
            string query = "SELECT SDT FROM SinhVien WHERE SDT ='" + SDT + "'";
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
        private void txtDT_Validating(object sender, CancelEventArgs e)
        {
            string sdt = txtSDT.Text.Trim();
            bool sdtCheck = false;

            if (sdt.Length == 10)
            {
                if (sdt[1] == '3' || sdt[1] == '5' || sdt[1] == '7' || sdt[1] == '8' || sdt[1] == '9')
                {
                    sdtCheck = true;
                }
            }
            if (string.IsNullOrEmpty(sdt))
            {
                e.Cancel = true;
                errSDT.SetError(txtSDT, "Vui lòng nhập số điện thoại!!!");
            }
            else if (CheckExitSDT())
            {
                e.Cancel = true;
                txtSDT.Focus();
                errSDT.SetError(txtSDT, "Số điện thoại đã tồn tại!!!");
            }
            else if (sdt[0] != '0' || sdt.Length != 10)
            {
                e.Cancel = true;
                errSDT.SetError(txtSDT, "Số điện thoại không không hợp lệ!!!");
            }
            else if (!sdtCheck)
            {
                e.Cancel = true;
                errSDT.SetError(txtSDT, "Số điện thoại không hợp lệ!!!");
            }
            else
            {
                e.Cancel = false;
                errSDT.Clear();
            }
        }

        /*
            Regex Email:

            The personal_info part contains the following ASCII characters.
            Uppercase (A-Z) and lowercase (a-z) English letters.
            Digits (0-9).
            Characters ! # $ % & ' * + - / = ? ^ _ ` { | } ~
            Character . ( period, dot or fullstop) provided that it is not the first or last character and it will not come one after the other.
            The domain name [for example com, org, net, in, us, info] part contains letters, digits, hyphens, and dots.

             Example of valid email id

             mysite@ourearth.com
             my.ownsite@ourearth.org
             mysite@you.me.net

             Example of invalid email id

             mysite.ourearth.com [@ is not present]
             mysite@.com.my [ tld (Top Level domain) can not start with dot "." ]
             @you.me.net [ No character before @ ]
             mysite123@gmail.b [ ".b" is not a valid tld ]
             mysite@.org.org [ tld can not start with dot "." ]
             .mysite@mysite.org [ an email should not be start with "." ]
             mysite()*@gmail.com [ here the regular expression only allows character, digit, underscore, and dash ]
             mysite..1234@yahoo.com [double dots are not allowed]
         */
        private bool CheckEmailExit()
        {
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = "Data Source=DESKTOP-MQNB7VA\\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True";
            con.Open();
            string Email = txtEmail.Text.Trim();
            string query = " SELECT COUNT(*) FROM SinhVien WHERE Email ='" + Email + "'";
            cmd = new SqlCommand(query, con);
            da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            if (int.Parse(dt.Rows[0][0].ToString()) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            string email = txtEmail.Text.Trim();
            bool isEmail = Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);

            if (string.IsNullOrEmpty(email))
            {
                e.Cancel = true;
                errEmail.SetError(txtEmail, "Vui lòng nhập Email!!!");
            }
            else if (CheckEmailExit())
            {
                e.Cancel = true;
                errEmail.SetError(txtEmail, "Email đã tồn tại!!!");
            }
            else if (!isEmail)
            {
                e.Cancel = true;
                errEmail.SetError(txtEmail, "Email không hợp lệ!!!");
            }
            else if (email.Length > 30)
            {
                e.Cancel = true;
                errEmail.SetError(txtEmail, "Email quá dài!!!");
            }
            else
            {
                e.Cancel = false;
                errEmail.Clear();
            }
        }

        private void cBMaLop_Validating(object sender, CancelEventArgs e)
        {
            string MaLop = cBMaLop.Text.Trim();
            if (string.IsNullOrEmpty(MaLop))
            {
                e.Cancel = true;
                errMaLop.SetError(cBMaLop, "Vui lòng nhập mã lớp!!!");
            }
            else if (MaLop != "CNTT.A" && MaLop != "CNTT.B" && MaLop != "CNTT.C" && MaLop != "CNTT.D" && MaLop != "SPTIN.A" && MaLop != "SPTIN.B")
            {
                e.Cancel = true;
                errMaLop.SetError(cBMaLop, "Mã lớp không hợp lệ!!!");
            }
            else
            {
                e.Cancel = false;
                errMaLop.Clear();
            }
        }

        //private void dGVQLSV_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    int index = dGVQLSV.CurrentCell.RowIndex;
        //    DataTable dt = (DataTable)dGVQLSV.DataSource;
        //    if (dt.Rows.Count > 0)
        //    {
        //        gBThongTin.Enabled = false;
        //        btnLuu.Enabled = false;
        //        btnThem.Enabled = false;
        //        btnXoa.Enabled = true;
        //        btnSua.Enabled = true;
        //        btnReset.Enabled = true;

        //        MaSV = dGVQLSV.Rows[index].Cells[0].Value.ToString();
        //        txtMaSV.Text = dGVQLSV.Rows[index].Cells[0].Value.ToString();
        //        txtTenSV.Text = dGVQLSV.Rows[index].Cells[1].Value.ToString();
        //        cBGioiTinh.Text = dGVQLSV.Rows[index].Cells[2].Value.ToString();
        //        dtpNgaySinh.Text = dGVQLSV.Rows[index].Cells[3].Value.ToString();
        //        txtDiaChi.Text = dGVQLSV.Rows[index].Cells[4].Value.ToString();
        //        cBDT.Text = dGVQLSV.Rows[index].Cells[5].Value.ToString();
        //        txtSDT.Text = dGVQLSV.Rows[index].Cells[6].Value.ToString();
        //        txtEmail.Text = dGVQLSV.Rows[index].Cells[7].Value.ToString();
        //        cBMaLop.Text = dGVQLSV.Rows[index].Cells[8].Value.ToString();

        //        //errMaSV.Clear();
        //        //errTenSV.Clear();
        //        //errGioiTinh.Clear();
        //        //errNgaySinh.Clear();
        //        //errDiaChi.Clear();
        //        //errDanToc.Clear();
        //        //errSDT.Clear();
        //        //errEmail.Clear();
        //        //errMaLop.Clear();
        //    }
        //}

        private void Return_Click(object sender, EventArgs e)
        {
            DialogResult isCancel = MessageBox.Show("Bạn có muốn Return thao tác không???", "Xác nhận Return", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (isCancel == DialogResult.Yes)
            {
                DataTable dt = bllSV.getAllSinhVien();
                dGVQLSV.DataSource = dt;
            }
            
            btnLuu.Enabled = false;
            btnReset.Enabled = true;
            btnReturn.Enabled = false;
        }

        private void button_Excel_Click(object sender, EventArgs e)
        {
            frmXuatExcel x = new frmXuatExcel();
            x.BangThongTin = dGVQLSV;
            x.Show();
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            if(cBTimTheo.Text == "Mã Sinh Viên")
            {
                da = new SqlDataAdapter("SELECT * FROM SinhVien WHERE MaSV LIKE '%" + txtTim.Text + "%'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dGVQLSV.DataSource = dt;
            }
            else if(cBTimTheo.Text == "Tên Sinh Viên")
            {
                da = new SqlDataAdapter("SELECT * FROM SinhVien WHERE TenSV LIKE '%" + txtTim.Text + "%'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dGVQLSV.DataSource = dt;
            }
            else if(cBTimTheo.Text == "Số Điện Thoại")
            {
                da = new SqlDataAdapter("SELECT * FROM SinhVien WHERE SDT LIKE '%" + txtTim.Text + "%'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dGVQLSV.DataSource = dt;
            }
            else if(cBTimTheo.Text == "Email")
            {
                da = new SqlDataAdapter("SELECT * FROM SinhVien WHERE Email LIKE '%" + txtTim.Text + "%'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dGVQLSV.DataSource = dt;
            }
            else if(cBTimTheo.Text == "Dân Tộc")
            {
                da = new SqlDataAdapter("SELECT * FROM SinhVien WHERE DanToc LIKE '%" + txtTim.Text + "%'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dGVQLSV.DataSource = dt;
            }
            else if(cBTimTheo.Text == "Mã Lớp")
            {
                da = new SqlDataAdapter("SELECT * FROM SinhVien WHERE MaLop LIKE '%" + txtTim.Text + "%'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dGVQLSV.DataSource = dt;
            }
        }

        private void dGVQLSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dGVQLSV.CurrentCell.RowIndex;
            DataTable dt = (DataTable)dGVQLSV.DataSource;
            if (dt.Rows.Count > 0)
            {
                gBThongTin.Enabled = false;
                btnLuu.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnReset.Enabled = true;

                MaSV = dGVQLSV.Rows[index].Cells[0].Value.ToString();
                txtMaSV.Text = dGVQLSV.Rows[index].Cells[0].Value.ToString();
                txtTenSV.Text = dGVQLSV.Rows[index].Cells[1].Value.ToString();
                cBGioiTinh.Text = dGVQLSV.Rows[index].Cells[2].Value.ToString();
                dtpNgaySinh.Text = dGVQLSV.Rows[index].Cells[3].Value.ToString();
                txtDiaChi.Text = dGVQLSV.Rows[index].Cells[4].Value.ToString();
                cBDT.Text = dGVQLSV.Rows[index].Cells[5].Value.ToString();
                txtSDT.Text = dGVQLSV.Rows[index].Cells[6].Value.ToString();
                txtEmail.Text = dGVQLSV.Rows[index].Cells[7].Value.ToString();
                cBMaLop.Text = dGVQLSV.Rows[index].Cells[8].Value.ToString();

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
        }

        private void cBMaLop_MouseClick(object sender, MouseEventArgs e)
        {
            //da = new SqlDataAdapter("SELECT MaLop FROM Lop", con);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //cBMaLop.DisplayMember = "MaLop";
            //cBMaLop.ValueMember = "MaLop";
            //cBMaLop.DataSource = dt;
        }
    }
}
