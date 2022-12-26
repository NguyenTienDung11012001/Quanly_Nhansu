using BLL;
using Entities;
using QLKS;
using QLNhansu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace QLKS
{
    public partial class frmQuatrinhhoctap : Form
    {
        public frmQuatrinhhoctap()
        {
            InitializeComponent();
        }

        int state = 0;

        private void frmQuatrinhhoctap_Load(object sender, EventArgs e)
        {
            QuatrinhhoctapBLL.FillComboBox(cboMaHV, "Hocvan_Select");
            QuatrinhhoctapBLL.FillComboBox(cboMaNS, "Nhansu_Select");

            QuatrinhhoctapBLL.SelectQuatrinhhoctap(dgv);
            clsBase.ManagerControl(this, state);
            dgv.Columns[0].Width = 140;
            dgv.Columns[1].Width = 140;
            dgv.Columns[2].Width = 140;
            dgv.Columns[3].Width = 400;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            state = 1;
            clsBase.ManagerControl(this, state);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            state = 2;
            clsBase.ManagerControl(this, state);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maQuatrinhhoctap = txtMa.Text;
            try
            {
                QuatrinhhoctapBLL.DeleteQuatrinhhoctap(maQuatrinhhoctap);
            }
            catch
            {
                MessageBox.Show("Có lỗi rồi!");
            }
            QuatrinhhoctapBLL.SelectQuatrinhhoctap(dgv);
            state = 0;
            clsBase.ManagerControl(this, state);
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgv.Rows[e.RowIndex];
                txtMa.Text = row.Cells[0].Value.ToString();
                cboMaNS.SelectedValue = row.Cells[1].Value.ToString();
                cboMaHV.SelectedValue = row.Cells[2].Value.ToString();
                txtTruong.Text = row.Cells[3].Value.ToString();
                dtS.Value = DateTime.Parse(row.Cells[4].Value.ToString());
                dtE.Value = DateTime.Parse(row.Cells[5].Value.ToString());
            }
            catch { }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Quatrinhhoctap Quatrinhhoctap = new Quatrinhhoctap();

            Quatrinhhoctap.MaHT = txtMa.Text;
            Quatrinhhoctap.MaNS = cboMaNS.SelectedValue.ToString();
            Quatrinhhoctap.MaHV = cboMaHV.SelectedValue.ToString();
            Quatrinhhoctap.Noihoctap = txtTruong.Text;
            Quatrinhhoctap.Nambatdau = dtS.Value;
            if(dtE.Value != DateTime.Today)
                Quatrinhhoctap.Namketthuc = dtE.Value;

            try
            {
                switch (state)
                {
                    case 1:
                        QuatrinhhoctapBLL.InsertQuatrinhhoctap(Quatrinhhoctap);
                        break;
                    case 2:
                        QuatrinhhoctapBLL.UpdateQuatrinhhoctap(Quatrinhhoctap);
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi rồi!");
            }
            QuatrinhhoctapBLL.SelectQuatrinhhoctap(dgv);
            state = 0;
            clsBase.ManagerControl(this, state);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            state = 0;
            clsBase.ManagerControl(this, state);
        }
    }
}
