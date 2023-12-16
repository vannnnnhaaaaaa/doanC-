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
    public partial class Addcategory : Form
    {
        public Addcategory()
        {
            InitializeComponent();
        }
        category ct = new category();
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            if (txtname.Text.Equals(""))
            {
                MessageBox.Show("vui long nhap ten category");
            }
            else
            {
                ct.themcategory(txtname.Text);
                MessageBox.Show("them thanh cong");
                txtname.Text = null;
            }
         
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                ct.themcategory(txtname.Text);
                MessageBox.Show("them thanh cong");
                txtname.Text = null;

            }
        }
    }
}
