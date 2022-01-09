using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_GUI
{
    class LopHocDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public LopHocDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getALLLopHoc()
        {
            //B1: Tạo câu lệnh sql để lấy toàn bộ lớp học
            string sql = "SELECT * FROM Lop";
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
        public bool InsertLopHoc(LopHoc lh)
        {
            string sql = "INSERT INTO Lop(MaLop, TenLop) VALUES(@MaLop, @TenLop)";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaLop", SqlDbType.VarChar).Value = lh.MaLop;
                cmd.Parameters.Add("@TenLop", SqlDbType.NVarChar).Value = lh.TenLop;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool UpdateLopHoc(LopHoc lh)
        {
            string sql = "UPDATE Lop SET TenLop = @TenLop WHERE MaLop = @MaLop";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaLop", SqlDbType.VarChar).Value = lh.MaLop;
                cmd.Parameters.Add("@TenLop", SqlDbType.NVarChar).Value = lh.TenLop;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool DeleteLopHoc(LopHoc lh)
        {
            string sql = "DELETE Lop WHERE MaLop = @MaLop";
            SqlConnection con = dc.GetConnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@MaLop", SqlDbType.VarChar).Value = lh.MaLop;
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
