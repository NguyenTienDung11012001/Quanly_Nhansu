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
    public class HocvanBLL
    {
        public static void SelectHocvan(DataGridView dgv)
        {
            dgv.DataSource = HocvanDAL.selectHocvan();
        }
        public static void InsertHocvan(Hocvan Hocvan)
        {
            HocvanDAL.insertHocvan(CreatePr(Hocvan));
        }

        public static void UpdateHocvan(Hocvan Hocvan)
        {
            HocvanDAL.updateHocvan(CreatePr(Hocvan));
        }

        public static void DeleteHocvan(string maHocvan)
        {
            HocvanDAL.deleteHocvan(CreatePrID(maHocvan));
        }

        private static SqlParameter[] CreatePr(Hocvan Hocvan)
        {
            SqlParameter[] pr = new SqlParameter[2]; 

            pr[0] = CreatePrID(Hocvan.MaHV); 
            pr[1] = CreatePrName(Hocvan.TenHV);

            return pr;
        }

        private static SqlParameter CreatePrID(string maHocvan)
        {
            SqlParameter pr = new SqlParameter("@MaHV", SqlDbType.Char, 5) { Value = maHocvan };
            return pr;
        }

        private static SqlParameter CreatePrName(string tenHocvan)
        {
            SqlParameter pr = new SqlParameter("@TenHV", SqlDbType.NVarChar, 50) { Value = tenHocvan };
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
        public static DataTable TimkiemmaHocvan(string maHocvan)
        {
            return HocvanDAL.timkiemmaHocvan(CreatePrID(maHocvan));
        }

        public static DataTable TimkiemtenHocvan(string tenHocvan)
        {
            return HocvanDAL.timkiemtenHocvan(CreatePrName(tenHocvan));
        }
        public static void ThongKeMaHocvan(DataGridView dgv, string maHocvan)
        {
            dgv.DataSource = HocvanDAL.thongkemaHocvan(CreatePrID(maHocvan));
        }

        public static void ThongKeTenHocvan(DataGridView dgv, string tenHocvan)
        {
            dgv.DataSource = HocvanDAL.thongketenHocvan(CreatePrName(tenHocvan));
        }
    }
}
