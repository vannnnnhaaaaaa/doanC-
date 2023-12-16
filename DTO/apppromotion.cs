using doanc_.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doanc_.DTO
{

    public partial class apppromotion : Form
    {
       
        public delegate void TruyenChoCha(float conlai);
        public TruyenChoCha truyendata;

        public static string promotioncode = null;
        public apppromotion()
        {
            InitializeComponent();
        }
        
        public void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                promotion pt = new promotion();
                DataTable dt = pt.layphantramvadieukien(txtname.Text);
                if (dt.Rows.Count > 0 )
                {
                   
                   foreach (DataRow dr in dt.Rows)
                    {
                        int dieukien = int.Parse(dr[1].ToString());
                       
                        if (frmbill.tong > dieukien)
                        {
                           
                            int phantramgiam = int.Parse(dr[0].ToString());
                            float giam = frmbill.tong*phantramgiam/100;
                            float conlai =frmbill.tong - giam;
                            frmbill.code = txtname.Text;
                            truyendata(conlai);
                            
                        }
                    }
                }
               
                this.Close();
               

            }
        }
    }
}
