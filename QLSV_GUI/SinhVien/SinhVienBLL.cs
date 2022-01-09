using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV_GUI
{
    class SinhVienBLL
    {
        SinhVienDAL dalSV;
        public SinhVienBLL()
        {
            dalSV = new SinhVienDAL();
        }
        public DataTable getAllSinhVien()
        {
            return dalSV.getALLSinhVien();
        }
        public bool InsertSinhVien(SinhVien sv)
        {
            return dalSV.InsertSinhVien(sv);
        }
        public bool UpdateSinhVien(SinhVien sv)
        {
            return dalSV.UpdateSinhVien(sv);
        }
        public bool DeteleSinhVien(SinhVien sv)
        {
            return dalSV.DeleteSinhVien(sv);
        }
    }
}
