using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV_GUI
{
    public partial class FrmThongTin : Form
    {
        public FrmThongTin()
        {
            InitializeComponent();
        }
        public FrmMenu frm;
        public delegate void _dongTap();
        public _dongTap DongTap;
        private void FrmThongTin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DongTap();
        }
    }
}
