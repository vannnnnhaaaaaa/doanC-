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
using System.IO;

namespace doanc_.DTO
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }
        category ct = new category();
        brand bd = new brand();
        public bool IsPictureBoxNull(PictureBox myPictureBox)
        {
            return myPictureBox == null || myPictureBox.Image == null;
        }
        private int ktrahople()
        {
            if (txtma.Text.Equals("") || txtgia.Text.Equals("") || txtten.Text.Equals("") || txtmota.Text.Equals("") ||IsPictureBoxNull(pbproduct)== true)
            {
                return 0;
            }


          return 1;
        }
        private void resetdata()
        {
            txtgia.Text = null;
            txtten.Text = null;
            txtma.Text = null;
            txtgia.Text = null;
            txtmota.Text = null;    
            pbproduct.Image = null;
        }

      
        private void btnexit_Click(object sender, EventArgs e)
        {
            if(ktrahople()== 1)
            {
                try
                {
                    productbus pd = new productbus();

                    pd.themgiay(txtma.Text, txtten.Text, cbcate.SelectedIndex+1, cbbrands.SelectedIndex+1, float.Parse(txtgia.Text), cbloai.Text, txtmota.Text);

                    pd.themanh(pbproduct, txtma.Text);
                    MessageBox.Show("them thanh cong ");
                    resetdata();
                }
                catch
                {
                    MessageBox.Show("id san pham da ton tai ");
                }
              

            }
            else
            {
                MessageBox.Show("vui long dien day du thong tin");
            }
        }
        private void loaddata()
        {
            cbbrands.DataSource = bd.laydanhsachbrands(); cbbrands.DisplayMember = "Name"; cbbrands.ValueMember = "Name";
            cbcate.DataSource = ct.laydanhsachcate();cbcate.DisplayMember = "name";cbcate.ValueMember = "Name";
        }
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtmota_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (ktrahople() == 1)
                {
                    MessageBox.Show("luu thanh cong ");

                    resetdata();

                }
                else
                {
                    MessageBox.Show("vui long dien day du thong tin");
                }
            }
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                pbproduct.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
