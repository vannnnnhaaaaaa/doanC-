using doanc_.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doanc_.BUS
{
    internal class Bill
    {
        Ketnoi db = new Ketnoi();
        DataTable dt;
        public DataTable laychitiethoadon(int id)
        {
            dt = new DataTable();
            string sql = "select pd.name , b.size_id from product as pd , bill_details as b where pd.product_id = b.product_id and b.bill_id =" + id + "";
            dt = db.Execute(sql);
            return dt;
        }
        public DataTable laydanhsachhoadon()
        {
            string sql = "select bill_id, us.display_name as ten_nhan_vien, b.total as tong_tien , b.total_promo as tien_phai_tra  , ct.name  as ten_khach_hang FROM users as us , Bill as b ,customer as ct  where us.user_id = b.user_id  and ct.id_customer = b.customer_id ";
            dt = db.Execute(sql);
            return dt;
        }
        public DataTable laydanhsachhoadontheongay(string date)
        {
            string sql = "select bill_id, us.display_name as ten_nhan_vien, b.total as tong_tien , b.total_promo as tien_phai_tra  , ct.name  as ten_khach_hang FROM users as us , Bill as b ,customer as ct  where us.user_id = b.user_id  and ct.id_customer = b.customer_id and date='" + date + "'";
            dt = db.Execute(sql);
            return dt;
        }
        public DataTable traveidbillhientai()
        {
            dt = new DataTable();
            string sql = "SELECT MAX(bill_id) FROM Bill";
            dt= db.Execute(sql);
            return dt;
        }
        public void taochitiethoadon (int bill_id , string product_id , int size_id)
        {
            string sql = "insert into bill_details values (" + bill_id + ",'" + product_id + "'," + size_id + ")";
            db.ExecuteNonQuery(sql);
        }
        public void taohoadoncocode (int user_id ,int customer_id , string date , float total , float total_promo ,string code)
        {
        
            string sql = "insert into Bill values('" + user_id + "','" + customer_id + "','" + date + "'," + total + "," + total_promo + ",'" +code+ "')";
            db.ExecuteNonQuery(sql);
        }
        
        public void taohoadonkocode(int user_id, int customer_id, string date, float total, float total_promo)
        {
            string sql = "insert into Bill values('" + user_id + "','" + customer_id + "','" + date + "'," + total + "," + total_promo + ", null)";

            db.ExecuteNonQuery(sql);
        }


    }
}
