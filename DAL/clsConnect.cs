using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class clsConnect
    {
        public static SqlConnection HamKetNoi()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLNhansu;Integrated Security=True");
            return conn;
        }
    }
}
