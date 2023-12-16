using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doanc_.BUS
{

   
    internal class category
    {
        Ketnoi db = new Ketnoi();   

        public void themcategory(string name)
        {
            string sql = "Insert Into category Values ('" + name +"')";
            db.ExecuteNonQuery(sql);
        }
        public DataTable laydanhsachcate()
        {
            DataTable dt = new DataTable();
            string sql = "select name from category";
            dt = db.Execute(sql);
            return dt;
        }
    }
}
