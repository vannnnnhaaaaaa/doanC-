﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doanc_.BUS
{
    internal class promotion
    {
        Ketnoi db = new Ketnoi();

        public DataTable laydanhsachsukien()
        {
            DataTable dt = new DataTable();
            string sql = "select promotion_id from promotion ";
            dt = db.Execute(sql);
            return dt;

        }
        public DataTable layphantramvadieukien(string code )
        {
            string sql = "select percent_decrease , condition from promotion_details where code ='"+code+"'";
            DataTable dt = new DataTable();
            dt = db.Execute(sql);
            return dt;
        }
        public DataTable laydatatheoid (string id)
        {

            DataTable dt = new DataTable();
            string sql = "select * from promotion where promotion_id = '" +id+"'";
            
            dt = db.Execute(sql);
            return dt;
        }
        public void themevent(string id , string name , string bd , string kt)
        {
            string sql = "Insert Into promotion Values ('" + id + "','" + name + "','" + bd +  "','"+kt+"')";
            db.ExecuteNonQuery(sql);
        }
        public DataTable thongke()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT code, COUNT(*) as code_count\r\nFROM Bill\r\nWHERE code IS NOT NULL\r\nGROUP BY code";
            dt = db.Execute(sql);
            return dt;
        }
             
        /*public DataTable ktrarole()
        {
            sql = "select * from permisions";
            DataTable dt = db.Execute(sql);
            return dt;
        }
        public DataTable laydanhsachdangnhap()
        {
            sql = "select username , password from  users ";
            DataTable dt = db.Execute(sql);
            return dt;
        }*/
    }
}
