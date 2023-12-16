using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doanc_.BUS
{
    internal class productbus
    {
        Ketnoi db = new Ketnoi();


        public DataTable timkiemtheoid(string id )
        {
            DataTable dt = new DataTable();
            string sql = "select name , price from product where product_id ='"+id+"'";
            dt = db.Execute(sql);
            return dt;
        }
        public int laysoluongsptheosize(string size_id)
        {

            DataTable dt = new DataTable();
            string sql = "select soluong from soluong where size_id ='" + size_id + "'";
            dt = db.Execute(sql);
            return int.Parse(dt.Rows[0].ToString());
        }
        public void themsizesp(string product_id , int size)
        {
            string sql =" Insert Into size Values ('"+product_id+"'"+size+"')";
            db.ExecuteNonQuery(sql);
        }
        public void themsoluongsp(int size , int sl)
        {
            string sql = " Insert Into size Values ('" + size + "'" + sl+ "')";
            db.ExecuteNonQuery(sql);
        }
        public void updatesoluongsp( int size_id , int sl )
        {
            string sql = "Update soluong SET soluong = '" + sl + "' where size_id ='" + size_id + "'";
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
        public DataTable danhsachgiay1()
        {
            DataTable dt = new DataTable();
            string sql = "select product_id , name , type  from product ";
            dt = db.Execute(sql);
            return dt;
        }
        public DataTable timkiemtheocate(int id) {
            DataTable dt = new DataTable();
            string sql = "select name , price  from product where id_category=' "+id+"'";
            dt = db.Execute(sql);
            return dt;
        }
    }
}
