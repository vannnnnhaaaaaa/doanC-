using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace doanc_.BUS
{
    internal class productbus
    {
        Ketnoi db = new Ketnoi();


        public DataTable laysizetheoidsp(string id)
        {
            DataTable dt = new DataTable(); 
            string sql = "select size_name from size where  product_id ='"+id+"' and quantity >0";
            dt = db.Execute(sql);
            return dt;

        }
        public DataTable laymasptutenvagia(string ten ,float gia)
        {
            DataTable dt = new DataTable();
            string sql = "SELECT [product_id] FROM[DoanC#duphong].[dbo].[product] where name = '"+ten+"'and price ="+gia+"";
            return dt;
        }
        public DataTable laydanhsachktra()
        {
            DataTable dt = new DataTable();
            string sql = "select product_id , size_name from size";
            dt = db.Execute(sql);
            return dt;

        }

        public DataTable layanhtheoid (string id)
        {
            DataTable dt = new DataTable ();
            string sql = "SELECT image FROM product_image where product_id ='"+id+"'";
            dt = db.Execute(sql);
            return dt;
    

        }
        public DataTable timkiemtheoid(string id )
        {
            DataTable dt = new DataTable();
            string sql = "select name , price  from product where product_id ='"+id+"'";
            dt = db.Execute(sql);
            return dt;
        }
        public DataTable laysoluongsptheospvasize(string product_id , int size)
        {

            DataTable dt = new DataTable();
            string sql = "select quantity from size where product_id ='"+product_id+"'AND size_name ="+size+"";
            dt = db.Execute(sql);
            return dt;
            
        }
        public void themsizesp(string product_id , int size, int sl)
        {
            string sql =" Insert Into size Values ('"+product_id+"',"+size+","+sl+")";
            db.ExecuteNonQuery(sql);
        }
  
        public void updatesoluongsp(string product_id,int size , int num )
        {
            string sql = "Update size  SET  quantity = '" + num + "' where product_id ='" +product_id+ "'and size_name=" +size+""  ;
            db.ExecuteNonQuery(sql);
        }
        public DataTable timkiemtheoidsp(string id)
        {
            DataTable dt = new DataTable();
            string sql = "select product_id ,name , price , type from product where product_id ='" + id + "'";
            dt = db.Execute(sql);
            return dt;
        }

        byte[] ImageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
        public void themanh (PictureBox b , string product_id)
        {   
            Ketnoi.conn.Open();
            byte[] a = ImageToByteArray(b.Image); 
           SqlCommand cmd =new SqlCommand( "Insert Into product_image Values(@hinhanh , @ma)",Ketnoi.conn);
            cmd.Parameters.Add("@ma", product_id);
            cmd.Parameters.Add("@hinhanh", a);

            cmd.ExecuteNonQuery();
            
        }
        public void themgiay(string ma , string ten , int id_cate , int id_brands , float gia , string loai , string mota )
        {
            string sql = "Insert Into product Values ('" + ma + "','" + ten + "','" + id_cate + "','" + mota + "','" +gia + "','"+ loai+ "','" +id_brands+"')";
            db.ExecuteNonQuery(sql);
           
        }
        public DataTable danhsachgiay()
        {
            DataTable dt = new DataTable();
            string sql = "select product_id , name ,price , type  from product ";
            dt = db.Execute(sql);
            return dt;
        }

        public int laysoluongtheoidvasize(string id , int size)
        {
            DataTable dt = new DataTable();

            string sql = "select quantity from size where product_id ='" + id + "'and size_name = "+size+"";
            dt = db.Execute(sql);
            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (int.Parse(dr[0].ToString()) == 0){
                        return 0;
                    }
                    return int.Parse(dr[0].ToString());
                }

            }
            catch
            {
                return 0;
            }
            return 0;
        }
        public void trudisoluong(string product_id , int size )
        {
            if (laysoluongtheoidvasize(product_id, size) == 0)
            {
                MessageBox.Show("san pham ko du");
                return; 
            }
            string sql = "Update size Set quantity = " + (laysoluongtheoidvasize(product_id,size) - 1) + "where product_id ='" + product_id + "'and size_name =" + size + "";
            db.ExecuteNonQuery(sql);
        }
    
        public DataTable thongkesanpham()
        {
            string sql = "SELECT product_id, COUNT(*) as product_count\r\nFROM bill_details\r\nGROUP BY product_id";
            DataTable dt = db.Execute(sql);
            return dt;
        }
        public DataTable soluongnhap()
        {
            DataTable dt = new DataTable();
            string sql = "select product_id , name ,price , type  from product ";
            dt = db.Execute(sql);
            return dt;
        }
        public DataTable danhsachgiay1()
        {
            DataTable dt = new DataTable();
            string sql = "select product_id , name , type  from product ";
            dt = db.Execute(sql);
            return dt;
        }
        public DataTable timkiemtheocate(int id) {
            DataTable dt = new DataTable();
            string sql = "select name , price ,product_id from product where id_category=' "+id+"'";
            dt = db.Execute(sql);
            return dt;
        }


    }
}
