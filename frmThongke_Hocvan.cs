using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhansu
{
    public partial class frmThongke_Hocvan : Form
    {
        public frmThongke_Hocvan()
        {
            InitializeComponent();
        }

        public string maHocvan, tenHocvan;

        private void frmThongke_Hocvan_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThongke_Hocvan_Load(object sender, EventArgs e)
        {
            if (maHocvan != null)
            {
                HocvanBLL.ThongKeMaHocvan(dgv, maHocvan);
                maHocvan = null;
            }
            else
            {
                HocvanBLL.ThongKeTenHocvan(dgv, tenHocvan);
                tenHocvan = null;
            }
        }
    }
}
