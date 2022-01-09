using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_GUI
{
    public class connect
    {
        public static string strcon = @"Data Source=DESKTOP-FMU45E7\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True";
        SqlConnection con = new SqlConnection(strcon);
    }
}
