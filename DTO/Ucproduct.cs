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
    public partial class Ucproduct : UserControl
    {
        public static string thamsoten = null;
        public static float thamsogia = 0;
    
        public Ucproduct()
        {
            InitializeComponent();
        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void loaddata(Image b , string a,float c)
        {
            txtgia.Text = c +"";
            txtten.Text = a;
            pbanh.Image = b;
        }
        private void Ucproduct_Load(object sender, EventArgs e)
        {
            loaddata(frmbill.b , frmbill.a , frmbill.c);
           
        }
 
        private void pbanh_Click(object sender, EventArgs e)
        {
            bangsize s = new bangsize();    
            s.ShowDialog();

                thamsoten = txtten.Text;
                thamsogia = float.Parse(txtgia.Text);
                
          
          
        }
    }
}
