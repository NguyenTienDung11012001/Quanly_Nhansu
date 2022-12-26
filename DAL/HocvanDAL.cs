using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HocvanDAL
    {
        public static DataTable selectHocvan()
        {
            return AllDAL.getData("Hocvan_Select");
        }

        public static void insertHocvan(SqlParameter[] pr)
        {
            AllDAL.insert_update("Hocvan_Insert", pr);
        }

        public static void updateHocvan(SqlParameter[] pr)
        {
            AllDAL.insert_update("Hocvan_Update", pr);
        }

        public static void deleteHocvan(SqlParameter pr)
        {
            AllDAL.delete("Hocvan_Delete", pr);
        }
        public static DataTable timkiemmaHocvan(SqlParameter pr)
        {
            return AllDAL.search_statistical("Hocvan_Search_MaHocvan", pr);
        }

        public static DataTable timkiemtenHocvan(SqlParameter pr)
        {
            return AllDAL.search_statistical("Hocvan_Search_TenHocvan", pr);
        }

        public static DataTable thongkemaHocvan(SqlParameter pr)
        {
            return AllDAL.search_statistical("Hocvan_Stt_MaHocvan", pr);
        }

        public static DataTable thongketenHocvan(SqlParameter pr)
        {
            return AllDAL.search_statistical("Hocvan_Stt_TenHocvan", pr);
        }
    }
}
