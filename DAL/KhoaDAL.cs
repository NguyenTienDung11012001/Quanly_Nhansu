using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhoaDAL
    {
        public static DataTable selectKhoa()
        {
            return AllDAL.getData("Khoa_Select");
        }

        public static void insertKhoa(SqlParameter[] pr)
        {
            AllDAL.insert_update("Khoa_Insert", pr);
        }

        public static void updateKhoa(SqlParameter[] pr)
        {
            AllDAL.insert_update("Khoa_Update", pr);
        }

        public static void deleteKhoa(SqlParameter pr)
        {
            AllDAL.delete("Khoa_Delete", pr);
        }
    }
}
