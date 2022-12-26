using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TuoiDAL
    {
        public static DataTable TimkiemNam(SqlParameter pr)
        {
           return AllDAL.search_statistical("Tuoi_Search_Nam", pr);
        }
        public static DataTable TimkiemKhoang(SqlParameter[] pr)
        {
            return AllDAL.search_statistical_2("Tuoi_Search_Khoang", pr);
        }
        public static DataTable ThongKe_Tuoi_Nam(SqlParameter pr)
        {
            return AllDAL.search_statistical("Tuoi_Stt_Nam", pr);
        }

        public static DataTable ThongKe_Tuoi_Khoang(SqlParameter[] pr)
        {
            return AllDAL.search_statistical_2("Tuoi_Stt_Khoang", pr);
        }
    }
}
