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
    public class QuatrinhcongtacBLL
    {
        public static void SelectQuatrinhcongtac(DataGridView dgv)
        {
            dgv.DataSource = QuatrinhcongtacDAL.selectQuatrinhcongtac();
        }
        public static void InsertQuatrinhcongtac(Quatrinhcongtac Quatrinhcongtac)
        {
            QuatrinhcongtacDAL.insertQuatrinhcongtac(CreatePr(Quatrinhcongtac));
        }

        public static void UpdateQuatrinhcongtac(Quatrinhcongtac Quatrinhcongtac)
        {
            QuatrinhcongtacDAL.updateQuatrinhcongtac(CreatePr(Quatrinhcongtac));
        }

        public static void DeleteQuatrinhcongtac(string maQuatrinhcongtac)
        {
            QuatrinhcongtacDAL.deleteQuatrinhcongtac(CreatePrID(maQuatrinhcongtac));
        }

        private static SqlParameter[] CreatePr(Quatrinhcongtac Quatrinhcongtac)
        {
            SqlParameter[] pr = new SqlParameter[6];
            SqlParameter pr1 = new SqlParameter("@MaNS", SqlDbType.Char, 5) { Value = Quatrinhcongtac.MaNS };
            SqlParameter pr2 = new SqlParameter("@MaKhoa", SqlDbType.Char, 5) { Value = Quatrinhcongtac.MaKhoa };
            SqlParameter pr3 = new SqlParameter("@MaCV", SqlDbType.Char, 5) { Value = Quatrinhcongtac.MaCV };
            SqlParameter pr4 = new SqlParameter("@Nambatdau", SqlDbType.Date) { Value = Quatrinhcongtac.Nambatdau };
            SqlParameter pr5 = new SqlParameter("@Namketthuc", SqlDbType.Date) { Value = Quatrinhcongtac.Namketthuc };

            pr[0] = CreatePrID(Quatrinhcongtac.MaCT);
            pr[1] = pr1;
            pr[2] = pr2;
            pr[3] = pr3;
            pr[4] = pr4;
            pr[5] = pr5;

            return pr;
        }

        private static SqlParameter CreatePrID(string maQuatrinhcongtac)
        {
            SqlParameter pr = new SqlParameter("@MaCT", SqlDbType.Char, 5) { Value = maQuatrinhcongtac };
            return pr;
        }

        private static SqlParameter CreatePrName(string tinhtrang)
        {
            SqlParameter pr = new SqlParameter("@Tinhtrang", SqlDbType.NVarChar, 50) { Value = tinhtrang };
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
