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
    public class KhoaBLL
    {
        public static void SelectKhoa(DataGridView dgv)
        {
            dgv.DataSource = KhoaDAL.selectKhoa();
        }
        public static void InsertKhoa(Khoa Khoa)
        {
            KhoaDAL.insertKhoa(CreatePr(Khoa));
        }

        public static void UpdateKhoa(Khoa Khoa)
        {
            KhoaDAL.updateKhoa(CreatePr(Khoa));
        }

        public static void DeleteKhoa(string maKhoa)
        {
            KhoaDAL.deleteKhoa(CreatePrID(maKhoa));
        }

        private static SqlParameter[] CreatePr(Khoa Khoa)
        {
            SqlParameter[] pr = new SqlParameter[2]; 

            pr[0] = CreatePrID(Khoa.MaKhoa); 
            pr[1] = CreatePrName(Khoa.TenKhoa);

            return pr;
        }

        private static SqlParameter CreatePrID(string maKhoa)
        {
            SqlParameter pr = new SqlParameter("@MaKhoa", SqlDbType.Char, 5) { Value = maKhoa };
            return pr;
        }

        private static SqlParameter CreatePrName(string tenKhoa)
        {
            SqlParameter pr = new SqlParameter("@TenKhoa", SqlDbType.NVarChar, 50) { Value = tenKhoa };
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
    }
}
