using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_GUI
{
    class MonHocDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public MonHocDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getALLMonHoc()
        {
            //B1: Tạo câu lệnh sql để lấy toàn bộ lớp học
            string sql = "SELECT * FROM MonHoc";
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
        public bool InsertMonHoc(MonHoc mh)
        {
            string sql = "INSERT INTO MonHoc(MaMH, TenMH, SoTinChi, HPTienQuyet, HPHocTruoc, MaHK) VALUES(@MaMH, @TenMH, @SoTinChi, @HPTienQuyet, @HPHocTruoc, @MaHk)";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaMH", SqlDbType.VarChar).Value = mh.MaMH;
                cmd.Parameters.Add("@TenMH", SqlDbType.NVarChar).Value = mh.TenMH;
                cmd.Parameters.Add("@SoTinChi", SqlDbType.Int).Value = mh.SoTinChi;
                cmd.Parameters.Add("@HPTienQuyet", SqlDbType.VarChar).Value = mh.HPTienQuyet;
                cmd.Parameters.Add("@HPHocTruoc", SqlDbType.VarChar).Value = mh.HPHocTruoc;
                cmd.Parameters.Add("@MaHK", SqlDbType.VarChar).Value = mh.MaHK;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool UpdateMonHoc(MonHoc mh)
        {
            string sql = "UPDATE MonHoc SET TenMH = @TenMH, SoTinChi = @SoTinChi, HPTienQuyet = @HPTienQuyet, HPHocTruoc = @HPHocTruoc, MaHK = @MaHK WHERE MaMH = @MaMH";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaMH", SqlDbType.VarChar).Value = mh.MaMH;
                cmd.Parameters.Add("@TenMH", SqlDbType.NVarChar).Value = mh.TenMH;
                cmd.Parameters.Add("@SoTinChi", SqlDbType.Int).Value = mh.SoTinChi;
                cmd.Parameters.Add("@HPTienQuyet", SqlDbType.VarChar).Value = mh.HPTienQuyet;
                cmd.Parameters.Add("@HPHocTruoc", SqlDbType.VarChar).Value = mh.HPHocTruoc;
                cmd.Parameters.Add("@MaHK", SqlDbType.VarChar).Value = mh.MaHK;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool DeleteMonHoc(MonHoc mh)
        {
            string sql = "DELETE MonHoc WHERE MaMH = @MaMH";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaMH", SqlDbType.VarChar).Value = mh.MaMH;
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
