using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_GUI
{
    class DataConnection
    {
        string conStr;
        public DataConnection()
        {
            conStr = @"Data Source=DESKTOP-FMU45E7\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True";
        }
        public SqlConnection GetConnect()
        {
            return new SqlConnection(conStr);
        }
    }
}
