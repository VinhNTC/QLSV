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
    public partial class FrmDiem : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-FMU45E7\\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True");
        string flag;
        string MaMH;
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        //DiemBLL bllMH;
        public FrmDiem()
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

        private void cboKhoaHoc_MouseClick(object sender, MouseEventArgs e)
        {
            //da = new SqlDataAdapter("SELECT * FROM SinhVien", con);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //cboMaSV.DisplayMember = "MaSV";
            //cboMaSV.ValueMember = "MaSV";
            //cboMaSV.DataSource = dt;
            // tạo SQL string goi thu tuc da xay dung va truyen tham so la dia chi nhap vao trong textBox
            string lSQLString = string.Format("execute dssv '{0}'", this.cBMaLop.Text);
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
            cboMaSV.DisplayMember = "MaSV";
            cboMaSV.ValueMember = "MaSV";
            this.cboMaSV.DataSource = lTable.DefaultView;
            //Close connection
            con.Close();
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

        private void cBMH_MouseClick(object sender, MouseEventArgs e)
        {
            // tạo SQL string goi thu tuc da xay dung va truyen tham so la dia chi nhap vao trong textBox
            string lSQLString = string.Format("execute sp_dsmh '{0}'", this.cBHK.Text);
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
            cBMH.DisplayMember = "TenMH";
            cBMH.ValueMember = "MaMH";
            this.cBMH.DataSource = lTable.DefaultView;
            //Close connection
            con.Close();
            //da = new SqlDataAdapter("SELECT * FROM MonHoc", con);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //cBMH.DisplayMember = "MaMH";
            //cBMH.ValueMember = "MaMH";
            //cBMH.DataSource = dt;
        }

        
        int row;

        //private void dGVDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    row = e.RowIndex;
        //    cboMaSV.Text = dGVDiem.Rows[row].Cells[0].Value.ToString();
        //    cBHK.Text = dGVDiem.Rows[row].Cells[2].Value.ToString();
        //    cBMH.Text = dGVDiem.Rows[row].Cells[1].Value.ToString();
        //    txtGK.Text = dGVDiem.Rows[row].Cells[3].Value.ToString();
        //    txtCK.Text = dGVDiem.Rows[row].Cells[4].Value.ToString();
        //}

        private void btnGK_Click(object sender, EventArgs e)
        {
            Random rdiem = new Random();
            int a = rdiem.Next(0, 10);
            txtGK.Text = a.ToString();
        }

        private void btnCK_Click(object sender, EventArgs e)
        {
            Random rdiem = new Random();
            int a = rdiem.Next(0, 10);
            txtCK.Text = a.ToString();
        }

        private void FrmDiem_Load(object sender, EventArgs e)
        {
            dGVDiem.DataSource = DiemDAL.DS_DIEM();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (cBMH.Text == "")
                {
                    MessageBox.Show("Cac truong khong dc trong", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DiemBLL.Nhap_Diem(cboMaSV.SelectedValue.ToString(), cBMH.SelectedValue.ToString(), cBHK.SelectedValue.ToString(), float.Parse(txtGK.Text), float.Parse(txtCK.Text));
                    dGVDiem.DataSource = DiemDAL.DS_DIEM();
                }
            }
            catch
            {
                dGVDiem.DataSource = DiemDAL.DS_DIEM();
            }
        }

        private void button_Excel_Click(object sender, EventArgs e)
        {
            frmXuatExcel x = new frmXuatExcel();
            x.BangThongTin = dGVDiem;
            x.Show();
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

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (cBDau.Checked)
            {
                // tạo SQL string goi thu tuc da xay dung va truyen tham so la dia chi nhap vao trong textBox
                string lSQLString = string.Format("execute tksv '{0}'", this.cBMonHoc.Text);
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
                this.dGVThongKe.DataSource = lTable;
                //Close connection
                con.Close();
            }
            else if (cBRot.Checked)
            {
                // tạo SQL string goi thu tuc da xay dung va truyen tham so la dia chi nhap vao trong textBox
                string lSQLString = string.Format("execute tksv1 '{0}'", this.cBMonHoc.Text);
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
                this.dGVThongKe.DataSource = lTable;
                //Close connection
                con.Close();
            }
            else if (cBTK.Checked)
            {
                // tạo SQL string goi thu tuc da xay dung va truyen tham so la dia chi nhap vao trong textBox
                string lSQLString = string.Format("execute tktk '{0}'", this.cBMonHoc.Text);
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
                this.dGVThongKe.DataSource = lTable;
                //Close connection
                con.Close();
            }
        }

        private void dGVDiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dGVDiem.CurrentCell.RowIndex;
            cboMaSV.Text = dGVDiem.Rows[index].Cells[0].Value.ToString();
            cBHK.Text = dGVDiem.Rows[index].Cells[2].Value.ToString();
            cBMH.Text = dGVDiem.Rows[index].Cells[1].Value.ToString();
            txtGK.Text = dGVDiem.Rows[index].Cells[3].Value.ToString();
            txtCK.Text = dGVDiem.Rows[index].Cells[4].Value.ToString();
        }
        private void cBHocKy_MouseClick(object sender, MouseEventArgs e)
        {
            da = new SqlDataAdapter("SELECT * FROM HocKy", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cBHocKy.DisplayMember = "MaHK";
            cBHocKy.ValueMember = "MaHK";
            cBHocKy.DataSource = dt;
        }
        private void cBMonHoc_MouseClick(object sender, MouseEventArgs e)
        {
            // tạo SQL string goi thu tuc da xay dung va truyen tham so la dia chi nhap vao trong textBox
            string lSQLString = string.Format("execute sp_dsmh '{0}'", this.cBHocKy.Text);
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
            cBMonHoc.DisplayMember = "MaMH";
            cBMonHoc.ValueMember = "MaMH";
            this.cBMonHoc.DataSource = lTable.DefaultView;
            //Close connection
            con.Close();
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            if (cBTimTheo.Text == "Mã SV")
            {
                da = new SqlDataAdapter("SELECT * FROM Diem WHERE MaSV LIKE '%" + txtTim.Text + "%'", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dGVDiem.DataSource = dt;
            }
        }
    }
}
