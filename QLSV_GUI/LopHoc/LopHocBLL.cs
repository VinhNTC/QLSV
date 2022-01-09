using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_GUI
{
    class LopHocBLL
    {
        LopHocDAL dalLH;
        public LopHocBLL()
        {
            dalLH = new LopHocDAL();
        }
        public DataTable getALLLopHoc()
        {
            return dalLH.getALLLopHoc();
        }
        public bool InsertLopHoc(LopHoc lh)
        {
            return dalLH.InsertLopHoc(lh);
        }
        public bool UpdateLopHoc(LopHoc lh)
        {
            return dalLH.UpdateLopHoc(lh);
        }
        public bool DeteleLopHoc(LopHoc lh)
        {
            return dalLH.DeleteLopHoc(lh);
        }
    }
}
