using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace doanc_.BUS
{
    internal class recieved
    {
        Ketnoi db = new Ketnoi();
        public void themvaophieunhap(int user_id)
        {
            DateTime currentTime = DateTime.Now;
            string sql = "insert into received values (" + user_id + ",'" + currentTime.ToString() + "')";
        }
        public void themvaochitietnhap(string product_id , int size , int quantity)
        {
            string sql = "insert into receivedproduct values ('" + product_id + "'," +traveidreceived() + "," + size + "," + quantity + ")";
            db.ExecuteNonQuery(sql);
        }
        public int traveidreceived()
        {
          DataTable dt = new DataTable();
            string sql = "SELECT MAX(received_id) FROM received";
            dt = db.Execute(sql);
       
            int n;
           
            foreach (DataRow dr in dt.Rows)
            {
                n = int.Parse(dr[0].ToString());
                return n;
            }
            return 0;

        }
    }
}
