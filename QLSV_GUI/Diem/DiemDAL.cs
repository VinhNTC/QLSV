using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_GUI
{
    public class DiemDAL
    {
        public static DataTable DS_DIEM()
        {
            SqlConnection con = new SqlConnection(connect.strcon);
            con.Open();
            SqlDataAdapter adap = new SqlDataAdapter("select * from Diem", con);
            DataTable ds = new DataTable();
            adap.Fill(ds);
            return ds;
        }
    }
}
