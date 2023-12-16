using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doanc_.BUS
{
    internal class customer
    {
        Ketnoi db = new Ketnoi();
        public void updatetotal (float total , int id)
        {
            string sql = "Update customer SET total_pay=" + total + "where id_customer =" + id + "";
            db.ExecuteNonQuery(sql);
        }
        public void updatepoint (int diem , int id)
        {
            string sql = "Update customer SET point=" + diem + "where id_customer =" + id + "";
             db.ExecuteNonQuery(sql);
        }
        public float travetongtiendamua(int id)
        {
            DataTable dt = new DataTable();

            string sql = "select total_pay from customer where id_customer ="+id+"";
            dt = db.Execute(sql);
            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    return float.Parse(dr[0].ToString());
                }

            }
           catch {
                return 0;
            }
            return 0;
        }


        public DataTable travetopmuahang()
        {
            DataTable dt = new DataTable ();
            string sql = "SELECT TOP 10 [total_pay] , [name]\r\nFROM [customer]\r\nORDER BY [total_pay] DESC;\r\n";
            dt = db.Execute(sql);
            return dt;


        }
        public int travetongdiem(int id)
        {
            DataTable dt = new DataTable();

            string sql = "select point from customer where id_customer =" + id + "";
            dt = db.Execute(sql);
            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    return int.Parse(dr[0].ToString());
                }

            }
            catch
            {
                return 0;
            }
            return 0;
        }

        public DataTable laydanhsachkhachhang()
        {
            DataTable dt = new DataTable();
            string sql = "select *from customer";
            dt = db.Execute(sql);
            return dt;
        }
        public void themkhachhang(string ten, string sdt, string email)
        {
            string sql = "Insert Into customer(name,phone,email) Values ('" + ten+ "','" + sdt + "','" + email + "')";
            db.ExecuteNonQuery(sql);
        }
        public DataTable timkiemkhachhang (string sdt)
        {
            DataTable dt = new DataTable();
            string sql = "select name , point , id_customer from customer where phone = '"+sdt+"'" ;
            dt = db.Execute(sql);
            return dt;
        }
        public void suathongtinkhachhang (string ma ,string ten, string sdt, string email)
        {
            String sql = "Update customer SET name ='" + ten + "',phone ='" + sdt + "',email='" + email +  "' where (id_customer ='" + ma + "')";
            db.ExecuteNonQuery(sql);
        }
    }
}
