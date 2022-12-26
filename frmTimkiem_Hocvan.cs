using BLL;
using Entities;
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
    public partial class frmTimkiem_Hocvan : Form
    {
        public frmTimkiem_Hocvan()
        {
            InitializeComponent();
        }

        private void frmTimkiem_Hocvan_Load(object sender, EventArgs e)
        {
            cls_Base_SSR.ManagerControl(this, state);
            HocvanBLL.SelectHocvan(dgv);
        }
        int state = 0;
        string maHocvan, tenHocvan; 

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rdoMa.Checked == true)
            {
                maHocvan = txtMa.Text;
                dgv.DataSource = HocvanBLL.TimkiemmaHocvan(maHocvan);
            }
            if (rdoTen.Checked == true)
            {
                tenHocvan = "%" + txtTen.Text.Trim() + "%";
                dgv.DataSource = HocvanBLL.TimkiemtenHocvan(tenHocvan);
            }
            state = 3;
            cls_Base_SSR.ManagerControl(this, state);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            HocvanBLL.SelectHocvan(dgv);
            state = 0;
            cls_Base_SSR.ManagerControl(this, state);
        }

        private void btnStt_Click(object sender, EventArgs e)
        {
            frmThongke_Hocvan frm = new frmThongke_Hocvan();
            if (rdoMa.Checked == true)
                frm.maHocvan = maHocvan;
            else
                frm.tenHocvan = tenHocvan;
            frm.Location = new Point(470, 250);
            frm.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmBaocao_Hocvan frm = new frmBaocao_Hocvan();
            if (rdoMa.Checked == true)
                frm.dt = HocvanBLL.TimkiemmaHocvan(maHocvan);
            else
                frm.dt = HocvanBLL.TimkiemtenHocvan(tenHocvan);
            frm.ShowDialog();
        } 

        private void rdoSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoMa.Checked == true)
            {
                state = 1;
                cls_Base_SSR.ManagerControl(this, state);
                HocvanBLL.SelectHocvan(dgv);
            }
            else
            {
                state = 2;
                cls_Base_SSR.ManagerControl(this, state);
                HocvanBLL.SelectHocvan(dgv);
            }
        }
    }
}
