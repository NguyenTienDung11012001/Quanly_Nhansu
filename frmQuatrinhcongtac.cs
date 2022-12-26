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
    public partial class frmQuatrinhcongtac : Form
    {
        public frmQuatrinhcongtac()
        {
            InitializeComponent();
        }

        int state = 0;

        private void frmQuatrinhcongtac_Load(object sender, EventArgs e)
        {
            QuatrinhcongtacBLL.FillComboBox(cboMaCV, "Chucvu_Select");
            QuatrinhcongtacBLL.FillComboBox(cboMaKhoa, "Khoa_Select");
            QuatrinhcongtacBLL.FillComboBox(cboMaNS, "Nhansu_Select");

            QuatrinhcongtacBLL.SelectQuatrinhcongtac(dgv);
            clsBase.ManagerControl(this, state);
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
            string maQuatrinhcongtac = txtMa.Text;
            try
            {
                QuatrinhcongtacBLL.DeleteQuatrinhcongtac(maQuatrinhcongtac);
            }
            catch
            {
                MessageBox.Show("Có lỗi rồi!");
            }
            QuatrinhcongtacBLL.SelectQuatrinhcongtac(dgv);
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
                cboMaKhoa.SelectedValue = row.Cells[2].Value.ToString();
                cboMaCV.SelectedValue = row.Cells[3].Value.ToString();
                dtS.Value = DateTime.Parse(row.Cells[4].Value.ToString());
                dtE.Value = DateTime.Parse(row.Cells[5].Value.ToString());
            }
            catch { }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Quatrinhcongtac Quatrinhcongtac = new Quatrinhcongtac();

            Quatrinhcongtac.MaCT = txtMa.Text;
            Quatrinhcongtac.MaNS = cboMaNS.SelectedValue.ToString();
            Quatrinhcongtac.MaKhoa = cboMaKhoa.SelectedValue.ToString(); 
            Quatrinhcongtac.MaCV = cboMaCV.SelectedValue.ToString();
            Quatrinhcongtac.Nambatdau = dtS.Value;
            if (dtE.Value != DateTime.Today)
                Quatrinhcongtac.Namketthuc = dtE.Value; 

            try
            {
                switch (state)
                {
                    case 1:
                        QuatrinhcongtacBLL.InsertQuatrinhcongtac(Quatrinhcongtac);
                        break;
                    case 2:
                        QuatrinhcongtacBLL.UpdateQuatrinhcongtac(Quatrinhcongtac);
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi rồi!");
            }
            QuatrinhcongtacBLL.SelectQuatrinhcongtac(dgv);
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
