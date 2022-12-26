using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChucvuDAL
    {
        public static DataTable selectChucvu()
        {
            return AllDAL.getData("Chucvu_Select");
        }

        public static void insertChucvu(SqlParameter[] pr)
        {
            AllDAL.insert_update("Chucvu_Insert", pr);
        }

        public static void updateChucvu(SqlParameter[] pr)
        {
            AllDAL.insert_update("Chucvu_Update", pr);
        }

        public static void deleteChucvu(SqlParameter pr)
        {
            AllDAL.delete("Chucvu_Delete", pr);
        }
    }
}
