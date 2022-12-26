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
    public partial class frmChucvu : Form
    {
        public frmChucvu()
        {
            InitializeComponent();
        }

        int state = 0;

        private void frmChucvu_Load(object sender, EventArgs e)
        {
            ChucvuBLL.SelectChucvu(dgv);
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
            string maChucvu = txtMa.Text;
            try
            {
                ChucvuBLL.DeleteChucvu(maChucvu);
            }
            catch
            {
                MessageBox.Show("Có lỗi rồi!");
            }
            ChucvuBLL.SelectChucvu(dgv);
            state = 0;
            clsBase.ManagerControl(this, state);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Chucvu Chucvu = new Chucvu();
            Chucvu.MaCV = txtMa.Text;
            Chucvu.TenCV = txtTen.Text;

            try
            {
                switch (state)
                {
                    case 1:
                        ChucvuBLL.InsertChucvu(Chucvu);
                        break;
                    case 2:
                        ChucvuBLL.UpdateChucvu(Chucvu);
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi rồi!");
            }
            ChucvuBLL.SelectChucvu(dgv);
            state = 0;
            clsBase.ManagerControl(this, state);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
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
                txtTen.Text = row.Cells[1].Value.ToString();
            }
            catch { }
        }
    }
}
