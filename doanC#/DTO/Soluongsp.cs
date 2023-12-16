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
    public partial class Soluongsp : Form
    {
        public Soluongsp()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtsoluong.Text.Equals(""))
            {
                MessageBox.Show("vui long nhap so luong san pham can nhap");
                return;
            }
            else
            {
                this.Close();
            }
            
        }

        private void Soluongsp_Load(object sender, EventArgs e)
        {

            txtsoluong.Focus();
            

        }
        public int travesoluong()
        {
            if (txtsoluong.Text.Equals(""))
            {
                return 0;
            }
            if (int.Parse(txtsoluong.Text) >0)
            {
                return int.Parse(txtsoluong.Text);
            }
            return 0;
        }
        public int travesize()
        {
            return int.Parse( cbsize.Text);
        }
    }
}
