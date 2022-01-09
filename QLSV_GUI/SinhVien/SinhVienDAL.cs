using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_GUI
{
    class SinhVienDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public SinhVienDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getALLSinhVien()
        {
            //B1: Tạo câu lệnh sql để lấy toàn bộ sinh viên
            string sql = "SELECT * FROM SinhVien";
            //B2: Tạo một kết nối đến sql
            SqlConnection con = dc.GetConnect();
            //B3: Khởi tạo đối tượng của lớp SqlDataAdapter
            da = new SqlDataAdapter(sql, con);
            //B4: Mở kết nối
            con.Open();
            //B5: Đổ dữ liệu từ SqlDataAdapter vào Datatable
            DataTable dt = new DataTable();
            da.Fill(dt);
            //B6: Đóng kết nối
            con.Close();
            return dt;
        }
        public bool InsertSinhVien(SinhVien sv)
        {
            string sql = "INSERT INTO SinhVien(MaSV, TenSV, GioiTinh, NgaySinh, DiaChi, DanToc, SDT, Email, MaLop) VALUES(@MaSV, @TenSV, @GioiTinh, @NgaySinh, @DiaChi, @DanToc, @SDT, @Email, @MaLop)";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaSV", SqlDbType.VarChar).Value = sv.MaSV;
                cmd.Parameters.Add("@TenSV", SqlDbType.NVarChar).Value = sv.TenSV;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = sv.GioiTinh;
                cmd.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = sv.NgaySinh;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = sv.DiaChi;
                cmd.Parameters.Add("@DanToc", SqlDbType.NVarChar).Value = sv.DanToc;
                cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = sv.SDT;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = sv.Email;
                cmd.Parameters.Add("@MaLop", SqlDbType.VarChar).Value = sv.MaLop;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool UpdateSinhVien(SinhVien sv)
        {
            string sql = "UPDATE SinhVien SET TenSV = @TenSV, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, DiaChi = @DiaChi, DanToc = @DanToc, SDT = @SDT, Email = @Email, MaLop = @MaLop WHERE MaSV = @MaSV";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaSV", SqlDbType.VarChar).Value = sv.MaSV;
                cmd.Parameters.Add("@TenSV", SqlDbType.NVarChar).Value = sv.TenSV;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = sv.GioiTinh;
                cmd.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = sv.NgaySinh;
                cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = sv.DiaChi;
                cmd.Parameters.Add("@DanToc", SqlDbType.NVarChar).Value = sv.DanToc;
                cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = sv.SDT;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = sv.Email;
                cmd.Parameters.Add("@MaLop", SqlDbType.VarChar).Value = sv.MaLop;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool DeleteSinhVien(SinhVien sv)
        {
            string sql = "DELETE SinhVien WHERE MaSV = @MaSV";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaSV", SqlDbType.VarChar).Value = sv.MaSV;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
    }
}
