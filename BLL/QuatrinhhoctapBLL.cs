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
    public class QuatrinhhoctapBLL
    {
        public static void SelectQuatrinhhoctap(DataGridView dgv)
        {
            dgv.DataSource = QuatrinhhoctapDAL.selectQuatrinhhoctap();
        }
        public static void InsertQuatrinhhoctap(Quatrinhhoctap Quatrinhhoctap)
        {
            QuatrinhhoctapDAL.insertQuatrinhhoctap(CreatePr(Quatrinhhoctap));
        }

        public static void UpdateQuatrinhhoctap(Quatrinhhoctap Quatrinhhoctap)
        {
            QuatrinhhoctapDAL.updateQuatrinhhoctap(CreatePr(Quatrinhhoctap));
        }

        public static void DeleteQuatrinhhoctap(string maQuatrinhhoctap)
        {
            QuatrinhhoctapDAL.deleteQuatrinhhoctap(CreatePrID(maQuatrinhhoctap));
        }

        private static SqlParameter[] CreatePr(Quatrinhhoctap Quatrinhhoctap)
        {
            SqlParameter[] pr = new SqlParameter[6];
            SqlParameter pr1 = new SqlParameter("@MaNS", SqlDbType.Char, 5) { Value = Quatrinhhoctap.MaNS };
            SqlParameter pr2 = new SqlParameter("@MaHV", SqlDbType.Char, 5) { Value = Quatrinhhoctap.MaHV };
            SqlParameter pr3 = new SqlParameter("@Noihoctap", SqlDbType.NVarChar, 50) { Value = Quatrinhhoctap.Noihoctap };
            SqlParameter pr4 = new SqlParameter("@Nambatdau", SqlDbType.Date) { Value = Quatrinhhoctap.Nambatdau };
            SqlParameter pr5 = new SqlParameter("@Namketthuc", SqlDbType.Date) { Value = Quatrinhhoctap.Namketthuc };

            pr[0] = CreatePrID(Quatrinhhoctap.MaHT);
            pr[1] = pr1;
            pr[2] = pr2;
            pr[3] = pr3;
            pr[4] = pr4;
            pr[5] = pr5;

            return pr;
        }

        private static SqlParameter CreatePrID(string maQuatrinhhoctap)
        {
            SqlParameter pr = new SqlParameter("@MaHT", SqlDbType.Char, 5) { Value = maQuatrinhhoctap };
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
