using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_GUI
{
    public class DiemBLL
    {
        public static void Nhap_Diem(string masv, string mamh, string mahk, float diemgk, float diemck)
        {
            //Tính điểm trung bình của sinh viên và insert vào database
            float diemtb = (float)(diemgk * 3 + diemck * 7) / 10;

            string ketqua;
            if (diemtb >= 4.0)
            {
                ketqua= "Đậu";
            }
            else
            {
                ketqua = "Rớt";
            }
            SqlConnection con = new SqlConnection(connect.strcon);//tạo kết nối đến CSDL
            con.Open();//mở kết nối
            SqlCommand cmd = new SqlCommand("insert into Diem values ('" + masv + "','" + mamh + "','" + mahk + "','" + diemgk + "','" + diemck + "','" + diemtb + "',N'" + ketqua +  "')", con);//lệnh truy vấn
            cmd.ExecuteNonQuery();//thuwck hiện truy vấn
            con.Close();//đóng kết nối
        }
    }
}
