using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doanc_.BUS
{
    internal class Promotiondetails
    {
        Ketnoi db = new Ketnoi();
        public void thempromotion(string promotion_id,string code , int dieukien , int phantramgiam)
        {
            string sql = "Insert Into promotion_details Values ('" + code + "'," + dieukien+ ","  + phantramgiam+ ",'" +promotion_id+ "')";
            db.ExecuteNonQuery(sql);

        }
        public DataTable lauydanhsachkhuyenmai()
        {
            DataTable dt = new DataTable();
            string sql = "select * from promotion_details ";
            dt = db.Execute(sql);
            return dt;
        }
        public DataTable lauydanhsachkhuyenmaitheopm(string id )
        {
            DataTable dt = new DataTable();
            string sql = "select * from promotion_details where promotion_id = '"+id+"'";
            dt = db.Execute(sql);
            return dt;
        }

    }   
}
