using doanc_.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace doanc_.BUS
{
    internal class Userbus
    {
       
        String sql;

       Ketnoi db = new Ketnoi();    
      
        public DataTable laydanhsachdangnhap()
        {
            sql = "select username , password , user_id from users";
            DataTable dt = db.Execute(sql);
            return dt;
        }

        public DataTable layquyenhan(int id)
        {
            sql = "select is_bill , is_product ,is_received , is_promo ,role_id from permisions where user_id =' " + id+"'";
            DataTable dt = db.Execute(sql);

            return dt;
        }
        public DataTable laydanhsachuser()
        {
            DataTable dt = new DataTable();
            string sql = "select user_id, display_name , email , phone , username , password from users";
            dt = db.Execute(sql);
            return dt;

        }
        public void themuser(string name , string email , string phone , string username  , string pass , int role)
        {
            string sql = "Insert Into users  Values ('" + name+ "','" + email + "','" + phone + "','" + username + "','" + pass + "','" + role + "')";
            db.ExecuteNonQuery(sql);
        }
        public void suaquyenhan(int id,int bill , int promo, int received , int product)
        {
            String sql = "Update permisions SET is_bill ='" + bill+ "', is_product ='" + product+ "',is_received ='" + received + "',is_promo ='"+promo + "' where permisions_id ='" + id + "'";
            db.ExecuteNonQuery(sql);
        }

      
        
    }
}
