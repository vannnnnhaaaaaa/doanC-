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
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }
        productbus pd = new productbus();
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Addcategory ad = new Addcategory();
            ad.ShowDialog();
        }

        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {
            AddBrands ad = new AddBrands();
            ad.ShowDialog();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            AddProduct ad = new AddProduct();
            ad.ShowDialog();
        }

        private void loaddata()
        {
            DataTable dt = pd.danhsachgiay();
            dgvsp.DataSource = dt;

        }
        private void frmProduct_Load(object sender, EventArgs e)
        {

            loaddata();
        }

        private void guna2TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtid.Text.Equals(""))
                {
                    MessageBox.Show("vui long nhap id san pham");
                }
                else
                {
                    DataTable dt = pd.timkiemtheoidsp(txtid.Text);
                    if (dt.Rows.Count > 0)
                    {
                        dgvsp.DataSource = dt;
                    }
                    else
                    {
                        MessageBox.Show("khong tim thay thong tin san pham ");
                    }
                   
                   
                }

            }
        }
    }
}