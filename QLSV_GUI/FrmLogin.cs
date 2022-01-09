using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_GUI
{
    public partial class FrmLogin : Form
    {
        String strConnection = @"Data Source=DESKTOP-FMU45E7\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True";
        SqlConnection conn;
        FrmMenu mnt;
        SqlCommand cmd;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void bntDangNhap_Click(object sender, EventArgs e)
        {
            Regex reg1 = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,16}$");
            Regex reg2 = new Regex("(?=.*?[A-Z])");
            Regex reg3 = new Regex("(?=.*?[a-z])");
            Regex reg4 = new Regex("(?=.*?[0-9])");
            Regex reg5 = new Regex("(?=.*?[#?!@$%^&*-])");
            Regex reg6 = new Regex(".{8,16}");
            conn = new SqlConnection(strConnection);
            try
            {
                conn.Open();
                string tk = txtUser.Text;
                string mk = txtPass.Text;
                string sql = "SELECT * FROM DangNhap WHERE TaiKhoan='" + tk + "'AND MatKhau='" + mk + "'";

                cmd = new SqlCommand(sql, conn);
                SqlDataReader data = cmd.ExecuteReader();
                if (data.Read() == true)
                {
                    if (reg1.IsMatch(txtPass.Text) == true)
                    {
                        MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        mnt = new FrmMenu();
                        mnt.Show();
                    }
                    else if (reg2.IsMatch(txtPass.Text) == false)
                    {
                        MessageBox.Show("Password thiếu chữ cái viết hoa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        MessageBox.Show("Đăng nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (reg3.IsMatch(txtPass.Text) == false)
                    {
                        MessageBox.Show("Password thiếu chữ cái viết thường!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        MessageBox.Show("Đăng nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (reg4.IsMatch(txtPass.Text) == false)
                    {
                        MessageBox.Show("Password thiếu chữ số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        MessageBox.Show("Đăng nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (reg5.IsMatch(txtPass.Text) == false)
                    {
                        MessageBox.Show("Password thiếu ký tự đặc biệt!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        MessageBox.Show("Đăng nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (reg6.IsMatch(txtPass.Text) == false)
                    {
                        MessageBox.Show("Password ko đảm bảo từ 8 đến 16 ký tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        MessageBox.Show("Đăng nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản và mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MessageBox.Show("Đăng nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUser.Text = "";
                    txtPass.Text = "";
                    txtUser.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("Đăng nhập thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void checkpass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkpass.Checked)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc chắn không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
