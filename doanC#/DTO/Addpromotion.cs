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
using static System.Net.Mime.MediaTypeNames;

namespace doanc_.DTO
{
    public partial class Addpromotion : Form
    {
        public Addpromotion()
        {
            InitializeComponent();
        }
        promotion pt = new promotion();
        Promotiondetails pd = new Promotiondetails();
        private void loaddata()
        {
            cbpromotionid.DataSource = pt.laydanhsachsukien(); cbpromotionid.DisplayMember = "promotion_id"; cbpromotionid.ValueMember = "promotion_id";
            cbpromotionid.SelectedItem = null;
        }
        private void Addpromotion_Load(object sender, EventArgs e)
        {
            loaddata(); 
        }

        private void label9_Click(object sender, EventArgs e)
        {
            
            int giam = int.Parse(txtgiam.Text) -1 ; 

            if (giam > 0)
            {
                txtgiam.Text = giam.ToString();
            }
           
        }

        private void lbtang_Click(object sender, EventArgs e)
        {
            int tang = int.Parse(txtgiam.Text) + 1;
            if (tang < 99)
            {
                txtgiam.Text = tang.ToString();
            }
            
        }
        private void resetdata()
        {
            cbpromotionid.SelectedIndex = 0;
            txtcode.Text = null; 
            txtcondition.Text = null;
        }
        private void cbpromotionid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbpromotionid_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string n = cbpromotionid.Text;
            DataTable dt = pt.laydatatheoid(n);
           

            foreach (DataRow dr in dt.Rows)
            {
                txtname.Text = dr[1].ToString();
                txtstar.Text = dr[2].ToString();
                txtend.Text = dr[3].ToString();
            }


          

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (txtcode.Text.Equals("") || txtcondition.Text.Equals(""))
            {
                MessageBox.Show("vui long nhap day du thong tin ");
            }
            else

            {
              
                    int dk = int.Parse((string)txtcondition.Text);
                    int giam = int.Parse((string)txtgiam.Text);
                try
                {

                    pd.thempromotion(cbpromotionid.Text, txtcode.Text, dk, giam);
                    MessageBox.Show("them thanh cong");
                    resetdata();
                }
                catch
                {
                    MessageBox.Show("ma code da co");
                }
               
               
               
               
            }
        }
    }
}
