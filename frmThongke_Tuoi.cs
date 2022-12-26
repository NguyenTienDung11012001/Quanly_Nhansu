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
    public partial class frmThongke_Tuoi : Form
    {
        public frmThongke_Tuoi()
        {
            InitializeComponent();
        }
        public string type;
        public int nam;
        public int tu, den;

        private void frmThongke_Nhansu_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmThongke_Tuoi_Load(object sender, EventArgs e)
        {
             
            if (type == "nam")
            { 
                TuoiBLL.ThongKe_Tuoi_Nam(dgv, nam);
            }
            else
            {
                TuoiBLL.ThongKe_Tuoi_Khoang(dgv, tu, den); 
            }
        }
    }
}
