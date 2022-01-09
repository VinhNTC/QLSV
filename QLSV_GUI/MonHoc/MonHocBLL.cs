using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_GUI
{
    class MonHocBLL
    {
        MonHocDAL dalMH;
        public MonHocBLL()
        {
            dalMH = new MonHocDAL();
        }
        public DataTable getALLMonHoc()
        {
            return dalMH.getALLMonHoc();
        }
        public bool InsertMonHoc(MonHoc mh)
        {
            return dalMH.InsertMonHoc(mh);
        }
        public bool UpdateMonHoc(MonHoc mh)
        {
            return dalMH.UpdateMonHoc(mh);
        }
        public bool DeteleMonHoc(MonHoc mh)
        {
            return dalMH.DeleteMonHoc(mh);
        }
    }
}
