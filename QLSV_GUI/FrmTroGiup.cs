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
    public partial class FrmTroGiup : Form
    {
        public FrmTroGiup()
        {
            InitializeComponent();
        }
        public FrmMenu frm;
        public delegate void _dongTap();
        public _dongTap DongTap;
        private void button1_Click(object sender, EventArgs e)
        {
            DongTap();
        }

        private void cBshowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (cBshowpass.Checked)
            {
                txtpasscu.UseSystemPasswordChar = false;
                txtpassmoi.UseSystemPasswordChar = false;
                txtxacnhan.UseSystemPasswordChar = false;
            }
            else
            {
                txtpasscu.UseSystemPasswordChar = true;
                txtpassmoi.UseSystemPasswordChar = true;
                txtxacnhan.UseSystemPasswordChar = true;
            }
        }

        private void txtpasscu_Validating(object sender, CancelEventArgs e)
        {
            string passcu = txtpasscu.Text.Trim();
            if (string.IsNullOrEmpty(passcu))
            {
                e.Cancel = true;
                errpasscu.SetError(txtpasscu, "Vui lòng nhập mật khẩu!!!");
            }
            else
            {
                e.Cancel = false;
                errpasscu.Clear();
            }
            
        }

        private void txtUser_Validating(object sender, CancelEventArgs e)
        {
            string user = txtUser.Text.Trim();
            if (string.IsNullOrEmpty(user))
            {
                e.Cancel = true;
                erruser.SetError(txtUser, "Vui lòng nhập tài khoản!!!");
            }
            else
            {
                e.Cancel = false;
                erruser.Clear();
            }
        }
    }
}
