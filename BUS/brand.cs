using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doanc_.BUS
{
    internal class brand
    {
        Ketnoi db = new Ketnoi();
        public void thembrands(string name)
        {
            string sql = "Insert Into brands Values ('" + name + "')";
            db.ExecuteNonQuery(sql);
        }
        public DataTable laydanhsachbrands()
        {
            DataTable dt = new DataTable();
            string sql = "select name from brands";
            dt = db.Execute(sql);
            return dt;
        }
    }
}
