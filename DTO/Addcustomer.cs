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
    public partial class Addcustomer : Form
    {
        public Addcustomer()
        {
            InitializeComponent();
        }
        private bool check()
        {
            if (txtemail.Text.Equals("") || txthovaten.Text.Equals("") || txtsdt.Text.Equals(""))
            {
                MessageBox.Show("vui long nhap day du thong tin");
                return false;
            }
            return true;
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (check())
            {
                customer ct = new customer();
                ct.themkhachhang(txthovaten.Text,txtsdt.Text,txtemail.Text);
                MessageBox.Show("them thanh cong");
                this.Close();

            }
            

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
