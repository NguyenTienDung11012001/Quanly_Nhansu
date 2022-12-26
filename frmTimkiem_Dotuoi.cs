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
    public partial class frmTimkiem_Dotuoi : Form
    {
        public frmTimkiem_Dotuoi()
        {
            InitializeComponent();
        }

        int state = 0;
        int tu, den, nam;
        private void frmTimkiem_Dotuoi_Load(object sender, EventArgs e)
        {
            cls_Base_SSR.ManagerControl(this, state);
            NhansuBLL.SelectNhansu(dgv);
        }
        //int tuoi;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (rdoKhoang.Checked == true)
            {
                try
                {
                    tu = int.Parse(txtStart.Text);
                    den = int.Parse(txtEnd.Text);
                    dgv.DataSource = TuoiBLL.TimkiemKhoang(tu, den);
                    state = 3;
                    cls_Base_SSR.ManagerControl(this, state);
                }
                catch
                {
                    MessageBox.Show("Hãy nhập tuổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (rdoMa.Checked == true)
            {
                try
                {
                    nam = int.Parse(txtMa.Text);
                    dgv.DataSource = TuoiBLL.TimkiemNam(nam);
                    state = 3;
                    cls_Base_SSR.ManagerControl(this, state);
                }
                catch
                {
                    MessageBox.Show("Hãy nhập năm sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            frmThongke_Tuoi frm = new frmThongke_Tuoi();

            if (rdoKhoang.Checked)
            {
                frm.type = "khoang";
                frm.tu = int.Parse(txtStart.Text);
                frm.den = int.Parse(txtEnd.Text);
            }
            else
            {
                frm.type = "nam";
                frm.nam = int.Parse(txtMa.Text);
            }

            frm.Location = new Point(470, 250);
            frm.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (rdoKhoang.Checked == true)
            {
                frmBaocao_Tuoi_Khoang frm = new frmBaocao_Tuoi_Khoang();
                frm.dt = TuoiBLL.TimkiemKhoang(tu, den);
                frm.ShowDialog();
            }
            else
            {
                frmBaocao_Tuoi_Nam frm = new frmBaocao_Tuoi_Nam();
                frm.dt = TuoiBLL.TimkiemNam(nam);
                frm.ShowDialog();
            }
        }

        private void rdoKhoang_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoKhoang.Checked == false)
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
