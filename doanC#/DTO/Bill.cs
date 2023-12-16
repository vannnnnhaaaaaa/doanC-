using doanc_.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doanc_.DTO
{
    public partial class Bill : Form
    {
        public static String a;
        
        public static Image b = null;
        public static float c;
        public Bill()
        {
            InitializeComponent();
        }

        brand bd = new brand();
        category ct = new category();   
        public void loaddata()
        {
            
            cbbrands.DataSource = bd.laydanhsachbrands(); cbbrands.DisplayMember = "Name"; cbbrands.ValueMember = "Name";
            cbcate.DataSource = ct.laydanhsachcate(); cbcate.DisplayMember = "name"; cbcate.ValueMember = "Name";
            cbbrands.SelectedItem = null;
            cbcate.SelectedItem = null;
            txtid.Text = null;
            if (Ucproduct.thamsogia != 0)
            {
                themspvaobill(Ucproduct.thamsoten, Ucproduct.thamsogia);
                Ucproduct.thamsogia = 0;
            }
        }
        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            ListBill lb = new ListBill();
            lb.ShowDialog();
        }

        private void ucproduct2_Load(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Addcustomer ad  = new Addcustomer();    
            ad.ShowDialog();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            customer ct = new customer();

            dt=  ct.timkiemkhachhang(txtsdt.Text);
            if (dt.Rows.Count > 0)
            {
               foreach (DataRow dr in dt.Rows)
                {
                    lbtenkhachhang.Text = dr[0].ToString();
                    txtdiem.Text = dr[1].ToString();
                }
            }
            else
            {
                MessageBox.Show("khong tim thay thong tin khach hang");
                lbtenkhachhang.Text = "ten khach hang ......";
            }
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            cbbrands.SelectedItem = null;
            cbcate.SelectedItem = null;
            txtid.Text = null;
        }
        private void addusercontrol(UserControl us)
        {
            
            Productpanel.Controls.Clear();
            Productpanel.Controls.Add(us);

        }


        private void timkiem()
        {
            productbus pd = new productbus();
            if (!txtid.Text.Equals(""))
            {
                DataTable dt = pd.timkiemtheoid(txtid.Text);
                foreach (DataRow dr in dt.Rows)
                {
                    a = dr[0].ToString();
                    c= int.Parse(dr[1].ToString());
                    addusercontrol(new Ucproduct());
 
                }


            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            timkiem();
           
            
        }

        private void Productpanel_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

                timkiem();
            }
        }
        public  void themspvaobill (string ten , float gia)
        {

            ListViewItem lvi =
            lvbill.Items.Add(ten);
            lvi.SubItems.Add(gia+"");
            
        }
        private void cbcate_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n = cbcate.SelectedIndex;
            
            if (n>=0)
            {
               
                productbus pd = new productbus();
                DataTable dt = pd.timkiemtheocate(n+1);

                foreach (DataRow dr in dt.Rows)
                {
                    a = dr[0].ToString();
                    c = int.Parse(dr[1].ToString());
                    addusercontrol(new Ucproduct());
                   

                }
                
            }
          

        }

      

        private void Productpanel_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void lvbill_MouseMove(object sender, MouseEventArgs e)
        {

            if (Ucproduct.thamsogia != 0)
            {
                themspvaobill(Ucproduct.thamsoten, Ucproduct.thamsogia);
               

                float tong = Ucproduct.thamsogia + float.Parse(txttong.Text);

                txttong.Text = tong+"";
               Ucproduct.thamsogia = 0;
               
            }
           
           

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            apppromotion ap = new apppromotion();
            ap.ShowDialog();
        }
    }
}
