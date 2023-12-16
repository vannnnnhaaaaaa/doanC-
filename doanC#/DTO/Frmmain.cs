using doanc_.BUS;
using Guna.UI2.WinForms;
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
    public partial class Frmmain : Form
    {
       
        
        public Frmmain()
        {
            InitializeComponent();
        }

        private void Frmmain_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        public void AddControls (Form f)
        {
            panelchinh.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;

            panelchinh.Controls.Add(f);
            f.Show();
        }
        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {     

            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddControls(new frmthongke());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            AddControls(new frmcustomer());
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            AddControls(new Bill());    
        }

        private void btnShoe_Click(object sender, EventArgs e)
        {
            AddControls(new frmProduct());
        }

        private void btnRole_Click(object sender, EventArgs e)
        {
           AddControls(new frmRole());
        }

      

     
        private void loaddata()
        {
            
            Userbus us = new Userbus();
            Login lg = new Login();


           

            if (Login.is_bill == 0) {
                btnBill.Enabled = false;
            
            }
            if (Login.is_product == 0)
            {
                btnShoe.Enabled = false;
            }
            if (Login.is_promo ==0)
            {
                btnPromotion.Enabled = false;
            }
            if (Login.is_recieved==0)
            {
                btnRecieved.Enabled = false;
            }
            if (Login.Actor==1)
            {
                btnRole.Enabled = false;
            }

      
            }
        private void btnPromotion_Click(object sender, EventArgs e)
        {
            AddControls(new frmPromotion());    
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
           AddControls(new Home());
        }

        private void btnRecieved_Click(object sender, EventArgs e)
        {
            AddControls(new frmrecieved());
        }

        private void panelchinh_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
