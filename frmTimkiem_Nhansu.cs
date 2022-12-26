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
    public partial class frmTimkiem_Nhansu : Form
    {
        public frmTimkiem_Nhansu()
        {
            InitializeComponent();
        }

        private void frmTimkiem_Nhansu_Load(object sender, EventArgs e)
        {
            cls_Base_SSR.ManagerControl(this, state);
            NhansuBLL.SelectNhansu(dgv);
            cbo.SelectedIndex = 0;
        }
        int state = 0;
        string maNhansu, tenNhansu;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rdoMa.Checked == true)
            {
                maNhansu = txtMa.Text;
                if (cbo.SelectedIndex == 1) 
                    dgv.DataSource = NhansuBLL.TimkiemmaNhansu_Qtct(maNhansu);
                else
                    dgv.DataSource = NhansuBLL.TimkiemmaNhansu(maNhansu);
            }
            if (rdoTen.Checked == true)
            {
                tenNhansu = "%" + txtTen.Text.Trim() + "%";
                if (cbo.SelectedIndex == 1) 
                    dgv.DataSource = NhansuBLL.TimkiemtenNhansu_Qtct(tenNhansu);
                else 
                    dgv.DataSource = NhansuBLL.TimkiemtenNhansu(tenNhansu);
            }
            state = 3;
            cls_Base_SSR.ManagerControl(this, state);
            if(cbo.SelectedIndex != 1)
            {
                btnStt.Enabled = false;
                btnReport.Enabled = true;
            }
            else
            {
                btnStt.Enabled = true;
                btnReport.Enabled = false;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            NhansuBLL.SelectNhansu(dgv);
            state = 0;
            cls_Base_SSR.ManagerControl(this, state);
        }

        private void btnStt_Click(object sender, EventArgs e)
        {
            frmThongke_Nhansu frm = new frmThongke_Nhansu();
            if (rdoMa.Checked == true)
                frm.maNhansu = maNhansu;
            else
                frm.tenNhansu = tenNhansu;
            frm.Location = new Point(470, 250);
            frm.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frm_Baocao_Nhansu frm = new frm_Baocao_Nhansu();
            if (rdoMa.Checked == true)
                frm.dt = NhansuBLL.TimkiemmaNhansu(maNhansu);
            else
                frm.dt = NhansuBLL.TimkiemtenNhansu(tenNhansu); 
            frm.ShowDialog();
        }

        private void rdoSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoMa.Checked == true)
            {
                state = 1;
                cls_Base_SSR.ManagerControl(this, state);
                NhansuBLL.SelectNhansu(dgv);
            }
            else
            {
                state = 2;
                cls_Base_SSR.ManagerControl(this, state);
                NhansuBLL.SelectNhansu(dgv);
            }
        }
    }
}
