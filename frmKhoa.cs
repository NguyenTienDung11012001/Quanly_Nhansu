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
    public partial class frmKhoa : Form
    {
        public frmKhoa()
        {
            InitializeComponent();
        }

        int state = 0;

        private void frmKhoa_Load(object sender, EventArgs e)
        {
            KhoaBLL.SelectKhoa(dgv);
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
            string maKhoa = txtMa.Text;
            try
            {
                KhoaBLL.DeleteKhoa(maKhoa);
            }
            catch
            {
                MessageBox.Show("Có lỗi rồi!");
            }
            KhoaBLL.SelectKhoa(dgv);
            state = 0;
            clsBase.ManagerControl(this, state);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Khoa Khoa = new Khoa();
            Khoa.MaKhoa = txtMa.Text;
            Khoa.TenKhoa = txtTen.Text;

            try
            {
                switch (state)
                {
                    case 1:
                        KhoaBLL.InsertKhoa(Khoa);
                        break;
                    case 2:
                        KhoaBLL.UpdateKhoa(Khoa);
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi rồi!");
            }
            KhoaBLL.SelectKhoa(dgv);
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
