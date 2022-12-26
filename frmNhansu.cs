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
    public partial class frmNhansu : Form
    {
        public frmNhansu()
        {
            InitializeComponent();
        }

        int state = 0;

        private void frmNhansu_Load(object sender, EventArgs e)
        {
            NhansuBLL.SelectNhansu(dgv);  
            dgv.Columns[0].Width = 70;
            dgv.Columns[2].Width = 70;
            dgv.Columns[3].Width = 100;
            dgv.Columns[4].Width = 100;
            dgv.Columns[5].Width = 100;
            dgv.Columns[6].Width = 200;
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
            string maNhansu = txtMa.Text;
            try
            {
                NhansuBLL.DeleteNhansu(maNhansu);
            }
            catch
            {
                MessageBox.Show("Có lỗi rồi!");
            }
            NhansuBLL.SelectNhansu(dgv);
            state = 0;
            clsBase.ManagerControl(this, state);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Nhansu Nhansu = new Nhansu();
            Nhansu.MaNS = txtMa.Text;
            Nhansu.TenNS = txtTen.Text;
            Nhansu.Gioitinh = txtGt.Text;
            Nhansu.Ngaysinh = dt.Value;
            Nhansu.SDT = txtSDT.Text;
            Nhansu.Diachi = txtDc.Text;
            Nhansu.Email = txtEmail.Text;

            try
            {
                switch (state)
                {
                    case 1:
                        NhansuBLL.InsertNhansu(Nhansu);
                        break;
                    case 2:
                        NhansuBLL.UpdateNhansu(Nhansu);
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi rồi!");
            }
            NhansuBLL.SelectNhansu(dgv);
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
                txtGt.Text = row.Cells[2].Value.ToString();
                dt.Text = row.Cells[3].Value.ToString();
                txtSDT.Text = row.Cells[4].Value.ToString();
                txtDc.Text = row.Cells[5].Value.ToString();
                txtEmail.Text = row.Cells[6].Value.ToString();
            }
            catch { }
        }
    }
}
