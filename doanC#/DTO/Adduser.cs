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
    public partial class Adduser : Form
    {
        public Adduser()
        {
            InitializeComponent();
        }
        Userbus ub = new Userbus();
        public int ktrathongtin()
        {
            if (txtname.Text.Equals("") || txtemail.Text.Equals("") || txtpass.Text.Equals("")||txtphone.Text.Equals("")|| txtusername.Text.Equals("") || txtpassconfirm.Text.Equals(""))
            {
                return 0;
                MessageBox.Show("vui long dien day du thong tin ");
            }
            if (!txtpass.Text.Equals(txtpassconfirm.Text))
            {
                return 1;
                MessageBox.Show("xac nhan mat khau ko chinh xac");
            }
           
            return 2;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(ktrathongtin() == 0)
            {
                MessageBox.Show("vui long dien day du thong tin ");
            }else if (ktrathongtin() == 1)
            {
                MessageBox.Show("xac nhan mat khau khong chinh xac");
            }
            else
            {
                MessageBox.Show("them thanh cong");
                ub.themuser(txtname.Text, txtemail.Text, txtphone.Text, txtusername.Text, txtpass.Text, 1);
            }
        }
    }
}
