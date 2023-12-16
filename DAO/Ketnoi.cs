using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace doanc_
{
    internal class Ketnoi
    {
        public static SqlConnection conn;
        SqlDataAdapter da;
        DataSet ds;
        String strcon = @"Data Source=DESKTOP-16GO2OC\VANHA;Initial Catalog=DoanC#duphong;Integrated Security=True";

        public Ketnoi()
        {
            connect();
        }
        public void connect ()
        {
            
            conn = new SqlConnection (strcon);  

        }
        public DataTable Execute(string sqlStr)
        {
            da = new SqlDataAdapter(sqlStr, strcon); 
            ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
        public void ExecuteNonQuery(string strSQL)
        {
            SqlCommand sqlcmd = new SqlCommand(strSQL, conn);
            conn.Open();
            sqlcmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
