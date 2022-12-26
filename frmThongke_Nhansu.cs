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
    public partial class frmThongke_Nhansu : Form
    {
        public frmThongke_Nhansu()
        {
            InitializeComponent();
        }

        public string maNhansu, tenNhansu;

        private void frmThongke_Nhansu_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThongke_Nhansu_Load(object sender, EventArgs e)
        { 
            if (maNhansu != null)
            {
                NhansuBLL.ThongKeMaNhansu(dgv, maNhansu);
                maNhansu = null;
            }
            else
            {
                NhansuBLL.ThongKeTenNhansu(dgv, tenNhansu);
                tenNhansu = null;
            }
        }
    }
}
