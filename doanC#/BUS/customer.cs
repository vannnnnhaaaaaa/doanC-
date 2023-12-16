using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doanc_.BUS
{
    internal class customer
    {
        Ketnoi db = new Ketnoi();
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
            string sql = "select name , point from customer where phone = '"+sdt+"'" ;
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
