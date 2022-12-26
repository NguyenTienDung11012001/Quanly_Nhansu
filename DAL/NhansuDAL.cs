using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhansuDAL
    {
        public static DataTable selectNhansu()
        {
            return AllDAL.getData("Nhansu_Select");
        }

        public static void insertNhansu(SqlParameter[] pr)
        {
            AllDAL.insert_update("Nhansu_Insert", pr);
        }

        public static void updateNhansu(SqlParameter[] pr)
        {
            AllDAL.insert_update("Nhansu_Update", pr);
        }

        public static void deleteNhansu(SqlParameter pr)
        {
            AllDAL.delete("Nhansu_Delete", pr);
        }
        //-------------Search-------------------
        public static DataTable timkiemmaNhansu(SqlParameter pr)
        {
            return AllDAL.search_statistical("Nhansu_Search_MaNhansu", pr);
        } 
        public static DataTable timkiemmaNhansu_Qtct(SqlParameter pr)
        {
            return AllDAL.search_statistical("Nhansu_Search_Qtct_MaNhansu", pr);
        }

        public static DataTable timkiemtenNhansu(SqlParameter pr)
        {
            return AllDAL.search_statistical("Nhansu_Search_TenNhansu", pr);
        } 
        public static DataTable timkiemtenNhansu_Qtct(SqlParameter pr)
        {
            return AllDAL.search_statistical("Nhansu_Search_Qtct_TenNhansu", pr);
        }

        public static DataTable thongkemaNhansu(SqlParameter pr)
        {
            return AllDAL.search_statistical("Nhansu_Stt_Qtct_MaNhansu", pr);
        }

        public static DataTable thongketenNhansu(SqlParameter pr)
        {
            return AllDAL.search_statistical("Nhansu_Stt_Qtct_TenNhansu", pr);
        }
        public static DataTable TimkiemNhansu_Tuoi_Lon(SqlParameter pr)
        {
            return AllDAL.search_statistical("Nhansu_Search_Tuoi_Lon", pr);
        }
        public static DataTable TimkiemNhansu_Tuoi_Nho(SqlParameter pr)
        {
            return AllDAL.search_statistical("Nhansu_Search_Tuoi_Nho", pr);
        }
        public static DataTable ThongKeNhansu_Tuoi_Lon(SqlParameter pr)
        {
            return AllDAL.search_statistical("Nhansu_Stt_Tuoi_Lon", pr);
        }
        public static DataTable ThongKeNhansu_Tuoi_Nho(SqlParameter pr)
        {
            return AllDAL.search_statistical("Nhansu_Stt_Tuoi_Nho", pr);
        }
    }
}
