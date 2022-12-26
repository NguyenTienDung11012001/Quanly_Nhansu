using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class QuatrinhhoctapDAL
    {
        public static DataTable selectQuatrinhhoctap()
        {
            return AllDAL.getData("Quatrinhhoctap_Select");
        }

        public static void insertQuatrinhhoctap(SqlParameter[] pr)
        {
            AllDAL.insert_update("Quatrinhhoctap_Insert", pr);
        }

        public static void updateQuatrinhhoctap(SqlParameter[] pr)
        {
            AllDAL.insert_update("Quatrinhhoctap_Update", pr);
        }

        public static void deleteQuatrinhhoctap(SqlParameter pr)
        {
            AllDAL.delete("Quatrinhhoctap_Delete", pr);
        }
    }
}
