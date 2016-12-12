using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace FreshLiveDAL
{
    class SqlDBHelper
    {

        private static string strCon = ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString;


        public static DataTable GetDataTable(string strSql, params SqlParameter[] sqlParams)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            SqlCommand cmd = new SqlCommand(strSql, con);
            foreach (SqlParameter param in sqlParams)
            {
                cmd.Parameters.Add(param);
            }
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            adp.Fill(dt);
            con.Close();
            return dt;
        }


        public static bool ExecuteNonQuery(string strSql, params SqlParameter[] sqlParams)
        {
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            SqlCommand cmd = new SqlCommand(strSql, con);
            foreach (SqlParameter param in sqlParams)
            {
                cmd.Parameters.Add(param);
            }
            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result > 0;
        }
    }
}
