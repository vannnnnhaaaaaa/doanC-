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
using System.Xml.Linq;

namespace doanc_.DTO
{
    public partial class AddBrands : Form
    {
        public AddBrands()
        {
            InitializeComponent();
        }
        brand b = new brand();
        private void AddBrands_Load(object sender, EventArgs e)
        {

        }

        private void lbUser_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            if (txtname.Text.Equals(""))
            {
                MessageBox.Show("vui long nhap ten brands");
            }
            else
            {
                b.thembrands(txtname.Text);
                MessageBox.Show("them thanh cong");
                txtname.Text = null;
            }
          
        }

        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtname.Text.Equals(""))
                {
                    MessageBox.Show("vui long nhap ten brands");
                }
                else
                {
                    b.thembrands(txtname.Text);
                    MessageBox.Show("them thanh cong");
                    txtname.Text = null;
                }

            }
        }
    }
}
