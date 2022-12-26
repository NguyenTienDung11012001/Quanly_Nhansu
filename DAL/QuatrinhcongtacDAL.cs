using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class QuatrinhcongtacDAL
    {
        public static DataTable selectQuatrinhcongtac()
        {
            return AllDAL.getData("Quatrinhcongtac_Select");
        }

        public static void insertQuatrinhcongtac(SqlParameter[] pr)
        {
            AllDAL.insert_update("Quatrinhcongtac_Insert", pr);
        }

        public static void updateQuatrinhcongtac(SqlParameter[] pr)
        {
            AllDAL.insert_update("Quatrinhcongtac_Update", pr);
        }

        public static void deleteQuatrinhcongtac(SqlParameter pr)
        {
            AllDAL.delete("Quatrinhcongtac_Delete", pr);
        }
    }
}
