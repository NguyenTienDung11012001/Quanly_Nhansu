using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AllDAL
    {
        public static DataTable getData(string storename)
        {
            SqlConnection conn = clsConnect.HamKetNoi();
            SqlCommand cmd = new SqlCommand(storename, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public static void delete(string storename, SqlParameter pr)
        {
            SqlConnection conn = clsConnect.HamKetNoi();
            SqlCommand cmd = new SqlCommand(storename, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(pr);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static void insert_update(string storename, SqlParameter[] pr)
        {
            SqlConnection conn = clsConnect.HamKetNoi();
            SqlCommand cmd = new SqlCommand(storename, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            foreach (SqlParameter para in pr)
                cmd.Parameters.Add(para);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static DataTable search_statistical(string storename, SqlParameter pr)
        {
            SqlConnection conn = clsConnect.HamKetNoi();
            SqlCommand cmd = new SqlCommand(storename, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(pr);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public static DataTable search_statistical_2(string storename, SqlParameter[] pr)
        {
            SqlConnection conn = clsConnect.HamKetNoi();
            SqlCommand cmd = new SqlCommand(storename, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            foreach (SqlParameter para in pr)
                cmd.Parameters.Add(para);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
    }
}
