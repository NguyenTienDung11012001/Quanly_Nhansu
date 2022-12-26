using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class NhansuBLL
    {
        public static void SelectNhansu(DataGridView dgv)
        {
            dgv.DataSource = NhansuDAL.selectNhansu();
        }
        public static void InsertNhansu(Nhansu Nhansu)
        {
            NhansuDAL.insertNhansu(CreatePr(Nhansu));
        }

        public static void UpdateNhansu(Nhansu Nhansu)
        {
            NhansuDAL.updateNhansu(CreatePr(Nhansu));
        }

        public static void DeleteNhansu(string maNhansu)
        {
            NhansuDAL.deleteNhansu(CreatePrID(maNhansu));
        }

        private static SqlParameter[] CreatePr(Nhansu Nhansu)
        {
            SqlParameter[] pr = new SqlParameter[7];
            SqlParameter pr2 = new SqlParameter("@Gioitinh", SqlDbType.NVarChar, 5) { Value = Nhansu.Gioitinh };
            SqlParameter pr3 = new SqlParameter("@Ngaysinh", SqlDbType.Date) { Value = Nhansu.Ngaysinh };
            SqlParameter pr4 = new SqlParameter("@SDT", SqlDbType.VarChar, 10) { Value = Nhansu.SDT };
            SqlParameter pr5 = new SqlParameter("@Diachi", SqlDbType.NVarChar, 50) { Value = Nhansu.Diachi };
            SqlParameter pr6 = new SqlParameter("@Email", SqlDbType.NVarChar, 50) { Value = Nhansu.Email };

            pr[0] = CreatePrID(Nhansu.MaNS);
            pr[1] = CreatePrName(Nhansu.TenNS);
            pr[2] = pr2;
            pr[3] = pr3;
            pr[4] = pr4;
            pr[5] = pr5;
            pr[6] = pr6;

            return pr;
        }

        private static SqlParameter CreatePrID(string maNhansu)
        {
            SqlParameter pr = new SqlParameter("@MaNS", SqlDbType.Char, 5) { Value = maNhansu };
            return pr;
        }

        private static SqlParameter CreatePrName(string tenNS)
        {
            SqlParameter pr = new SqlParameter("@TenNS", SqlDbType.NVarChar, 50) { Value = tenNS };
            return pr;
        }

        public static void FillComboBox(ComboBox cbo, string storename)
        {
            cbo.DataSource = AllDAL.getData(storename);
            cbo.DisplayMember = AllDAL.getData(storename).Columns[1].ColumnName;
            cbo.ValueMember = AllDAL.getData(storename).Columns[0].ColumnName;
        }
        public static void FillComboBoxS(ComboBox cbo, string storename)
        {
            cbo.DataSource = AllDAL.getData(storename);
            cbo.DisplayMember = AllDAL.getData(storename).Columns[0].ColumnName;
            cbo.ValueMember = AllDAL.getData(storename).Columns[0].ColumnName;
        }
        public static DataTable TimkiemmaNhansu(string maNhansu)
        {
            return NhansuDAL.timkiemmaNhansu(CreatePrID(maNhansu));
        } 
        public static DataTable TimkiemmaNhansu_Qtct(string maNhansu)
        {
            return NhansuDAL.timkiemmaNhansu_Qtct(CreatePrID(maNhansu));
        }
        public static DataTable TimkiemtenNhansu(string tenNhansu)
        {
            return NhansuDAL.timkiemtenNhansu(CreatePrName(tenNhansu));
        } 
        public static DataTable TimkiemtenNhansu_Qtct(string tenNhansu)
        {
            return NhansuDAL.timkiemtenNhansu_Qtct(CreatePrName(tenNhansu));
        }
        public static void ThongKeMaNhansu(DataGridView dgv, string maNhansu)
        {
            dgv.DataSource = NhansuDAL.thongkemaNhansu(CreatePrID(maNhansu));
        }

        public static void ThongKeTenNhansu(DataGridView dgv, string tenNhansu)
        {
            dgv.DataSource = NhansuDAL.thongketenNhansu(CreatePrName(tenNhansu));
        }        
    }
}
