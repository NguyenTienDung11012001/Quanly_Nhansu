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
    public class ChucvuBLL
    {
        public static void SelectChucvu(DataGridView dgv)
        {
            dgv.DataSource = ChucvuDAL.selectChucvu();
        }
        public static void InsertChucvu(Chucvu Chucvu)
        {
            ChucvuDAL.insertChucvu(CreatePr(Chucvu));
        }

        public static void UpdateChucvu(Chucvu Chucvu)
        {
            ChucvuDAL.updateChucvu(CreatePr(Chucvu));
        }

        public static void DeleteChucvu(string maChucvu)
        {
            ChucvuDAL.deleteChucvu(CreatePrID(maChucvu));
        }

        private static SqlParameter[] CreatePr(Chucvu Chucvu)
        {
            SqlParameter[] pr = new SqlParameter[2]; 

            pr[0] = CreatePrID(Chucvu.MaCV); 
            pr[1] = CreatePrName(Chucvu.TenCV);

            return pr;
        }

        private static SqlParameter CreatePrID(string maChucvu)
        {
            SqlParameter pr = new SqlParameter("@MaCV", SqlDbType.Char, 5) { Value = maChucvu };
            return pr;
        }

        private static SqlParameter CreatePrName(string tenCV)
        {
            SqlParameter pr = new SqlParameter("@TenCV", SqlDbType.NVarChar, 50) { Value = tenCV };
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
