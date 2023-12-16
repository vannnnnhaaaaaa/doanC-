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
    public partial class bangsize : Form
    {
        public bangsize()
        {
            InitializeComponent();
        }
        public static int size = 0;
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void loaddata()

        {
            productbus pd = new productbus();
            cbsize.DataSource = pd.laysizetheoidsp(frmbill.thamsoid); cbsize.DisplayMember = "size_name"; cbsize.ValueMember = "size_name";
            cbsize.SelectedItem = 0;
        }
        private bool checl()
        {
            if (cbsize.SelectedIndex == -1) {
                MessageBox.Show("chon size");
                if (txtsoluong.Text.Equals("0"))
                {
                    MessageBox.Show("san pham da het");
                    return false;
                }
               
                return false;
              
            }
            return true;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(checl())
            {
                size = int.Parse(cbsize.Text);
                this.Close();
            }
        }

        private void bangsize_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void cbsize_SelectedIndexChanged(object sender, EventArgs e)
        {
            productbus pd = new productbus();
   
            int size =int.Parse(cbsize.Text);
          
            int soluong = pd.laysoluongtheoidvasize(frmbill.thamsoid, size);
          
            txtsoluong.Text = soluong.ToString();

        }
    }
}
