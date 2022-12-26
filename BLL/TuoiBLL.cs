using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using System.Security.Cryptography;

namespace BLL
{
    public class TuoiBLL
    { 
        public static DataTable TimkiemKhoang(int tu, int den)
        {
            SqlParameter[] pr = new SqlParameter[2];
            SqlParameter pr0 = new SqlParameter("@Tu", SqlDbType.Int) { Value = tu };
            SqlParameter pr1 = new SqlParameter("@Den", SqlDbType.Int) { Value = den };

            pr[0] = pr0;
            pr[1] = pr1;

            return TuoiDAL.TimkiemKhoang(pr);
        }
        public static DataTable TimkiemNam(int nam)
        {
            SqlParameter pr = new SqlParameter();
            pr = new SqlParameter("@Nam", SqlDbType.Int) { Value = nam };

            return TuoiDAL.TimkiemNam(pr);
        }
        public static void ThongKe_Tuoi_Nam(DataGridView dgv, int nam)
        {
            SqlParameter pr = new SqlParameter();
            pr = new SqlParameter("@Nam", SqlDbType.Int) { Value = nam };

            dgv.DataSource = TuoiDAL.ThongKe_Tuoi_Nam(pr);
        }
        public static void ThongKe_Tuoi_Khoang(DataGridView dgv, int tu, int den)
        {
            SqlParameter[] pr = new SqlParameter[2];
            SqlParameter pr0 = new SqlParameter("@Tu", SqlDbType.Int) { Value = tu };
            SqlParameter pr1 = new SqlParameter("@Den", SqlDbType.Int) { Value = den };

            pr[0] = pr0;
            pr[1] = pr1;

            dgv.DataSource = TuoiDAL.ThongKe_Tuoi_Khoang(pr);
        }

    }
}
