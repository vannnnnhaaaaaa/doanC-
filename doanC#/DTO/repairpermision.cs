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
    public partial class repairpermision : Form
    {
        public repairpermision()
        {
            InitializeComponent();
        }

        private void lbUser_Click(object sender, EventArgs e)
        {

        }

        private void repairpermision_Load(object sender, EventArgs e)
        {
            Loaddata(); 
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void id_Click(object sender, EventArgs e)
        {

        }

        private void txtid_Click(object sender, EventArgs e)
        {

        }
        private void Loaddata()
        {
            txtname.Text = frmRole.name;
            txtid .Text = frmRole.id;

            Userbus us = new Userbus();
            int n = int.Parse(txtid.Text);

            int bill = int.Parse(us.layquyenhan(n).Rows[0][0].ToString());
            int product = int.Parse(us.layquyenhan(n).Rows[0][1].ToString());
            int recieved = int.Parse(us.layquyenhan(n).Rows[0][2].ToString());
            int promo = int.Parse(us.layquyenhan(n).Rows[0][3].ToString());

            if (bill == 1)
            {
                cbxuathoadon.Checked = true;
            }
            if (product == 1)
            {
                cbquanlysanpham.Checked = true;
            }
            if (promo == 1)
            {
                cbtaokhuyenmai.Checked = true;
            }
            if (recieved == 1)
            {
                cbnhaphang.Checked = true;
            }

        }
        private void btxacnhan_Click(object sender, EventArgs e)
        {
            int checkbill = 0;
            int checkpromo = 0;
            int checkproduct = 0;
            int checkreceived = 0;
            Userbus us = new Userbus();
            if (cbxuathoadon.Checked == true)
            {
                checkbill = 1;
            }
            if (cbquanlysanpham.Checked == true)
            {
                checkproduct = 1;
            }
            if (cbtaokhuyenmai.Checked == true)
            {
                checkreceived = 1;
            }
            if (cbnhaphang.Checked == true) { 
                checkreceived = 1;
            }
            us.suaquyenhan(int.Parse(txtid.Text) ,checkbill,checkpromo ,checkreceived, checkproduct);
        }
    }
}
