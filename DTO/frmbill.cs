using doanc_.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace doanc_.DTO
{
    public partial class frmbill : Form
    {
        public static String a;

        public static Image b = null;
        public static float c;
        public static string thamsoid = null;
        public static float tong;
        public float conlai;
        public static string code = "";
        public frmbill()
        {
            InitializeComponent();
        }

        brand bd = new brand();
        category ct = new category();
        public void loaddata()
        {
            txtid.Text = null;
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
            Addcustomer ad = new Addcustomer();
            ad.ShowDialog();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            customer ct = new customer();

            dt = ct.timkiemkhachhang(txtsdt.Text);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    lbtenkhachhang.Text = dr[0].ToString();
                    txtdiem.Text = dr[1].ToString();
                    txtidkhach.Text = dr[2].ToString();

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
            txtid.Text = null;
            Productpanel.Controls.Clear();
        }
        private void addusercontrol(UserControl us)
        {

            Productpanel.Controls.Add(us);
        }
        private void timkiemusercontrol(UserControl us)
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
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("khong tim thay san pham");
                    Productpanel.Controls.Clear();
                }
                DataTable dt1 = pd.layanhtheoid(txtid.Text);
                foreach (DataRow dr in dt.Rows)
                {
                    a = dr[0].ToString();
                    c = int.Parse(dr[1].ToString());


                }
                foreach (DataRow dr in dt1.Rows)
                {
                    byte[] data = dr[0] as byte[];

                    // Chuyển đổi byte[] thành Image
                    MemoryStream ms = new MemoryStream(data);
                    b = Image.FromStream(ms);
                    timkiemusercontrol(new Ucproduct());

                }

            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            timkiem();
            thamsoid = txtid.Text;

        }

        private void Productpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

                timkiem();
                thamsoid = txtid.Text;

            }
        }


        public void themspvaobill(string id, string ten, float gia, int size)
        {

            ListViewItem lvi =
            lvbill.Items.Add(id);
            lvi.SubItems.Add(ten + "");
            lvi.SubItems.Add(gia + "");
            lvi.SubItems.Add(size + "");
        }
        private void cbcate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void Productpanel_MouseClick(object sender, MouseEventArgs e)
        {

        }

        public void loadgiatiensauapma(float tiensaugiam)
        {

            txtconlai.Text = tiensaugiam.ToString();
            float n = tong - tiensaugiam;
            txtgiam.Text = n + "";
        }
        private void lvbill_MouseMove(object sender, MouseEventArgs e)
        {

            if (Ucproduct.thamsogia != 0 && bangsize.size != 0)
            {

                themspvaobill(txtid.Text, Ucproduct.thamsoten, Ucproduct.thamsogia, bangsize.size);

                tong = Ucproduct.thamsogia + float.Parse(txttong.Text);
                conlai = tong;
                txttong.Text = tong.ToString();
                txtconlai.Text = null;
                txtconlai.Text += conlai.ToString();
                txtid.Text = null;
                Ucproduct.thamsogia = 0;
                Ucproduct.thamsoten = null;
                bangsize.size = 0;
                Productpanel.Controls.Clear();
            }



        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

            apppromotion ap = new apppromotion();
            ap.truyendata = new apppromotion.TruyenChoCha(loadgiatiensauapma);
            ap.ShowDialog();




        }
        private bool check()
        {
            if (lbtenkhachhang.Text.Length == 0)
            {
                MessageBox.Show("vui long them ten khach hang");
                return false;
            }
            if (lvbill.Items.Count == 0)
            {
                MessageBox.Show("vui long them san pham ");
                return false;
            }
            return true;
        }
        private void resetdata()
        {
            txtconlai.Text = null; txttong.Text = null;
            txtgiam.Text = null;
            txtsdt.Text = null;
            txtid.Text = null;
            lvbill.Items.Clear();
            txtidkhach.Text = null;
            lbtenkhachhang.Text = null;
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            customer ct = new customer();




            if (check())
            {

                Bill b = new Bill();
                productbus pd = new productbus();
                DateTime currentTime = DateTime.Now;

                if (code.Equals(""))
                {

                    b.taohoadonkocode(Login.user_id, int.Parse(txtidkhach.Text), currentTime.ToString(), float.Parse(txttong.Text), float.Parse(txtconlai.Text));
                }
                else
                {

                    b.taohoadoncocode(Login.user_id, int.Parse(txtidkhach.Text), currentTime.ToString(), float.Parse(txttong.Text), float.Parse(txtconlai.Text), code);
                }

                // update lai totol 
          
                float total = ct.travetongtiendamua(int.Parse(txtidkhach.Text));
        
                total += float.Parse(txtconlai.Text);
        
                int diem = int.Parse(txtconlai.Text) / 10;
            
                if (txtdiem.Text.Equals(""))
                {
                    txtdiem.Text = "0";
                }
                int tam = diem+ int.Parse(txtdiem.Text);
                ;
                ct.updatetotal(total, int.Parse(txtidkhach.Text));
                
                ct.updatepoint(tam, int.Parse(txtidkhach.Text));
                code = "";
                try
                {
                    foreach (ListViewItem item in lvbill.Items)
                    {

                        b.taochitiethoadon(travebill_id(), item.SubItems[0].Text, int.Parse(item.SubItems[3].Text));
                        pd.trudisoluong(item.SubItems[0].Text, int.Parse(item.SubItems[3].Text));
                    }
                }
                catch
                {
                    MessageBox.Show("so luong san pham ko du");
                }
               




                tong = Ucproduct.thamsogia + float.Parse(txttong.Text);
                conlai = tong;
                txttong.Text = tong.ToString();
                txtconlai.Text = null;
                txtconlai.Text += conlai.ToString();
                txtid.Text = null;
                Ucproduct.thamsogia = 0;
                Ucproduct.thamsoten = null;
                bangsize.size = 0;

                MessageBox.Show("tao hoa don thanh cong");
                txtidkhach.Text = null;
                txtsdt.Text = null;
                lvbill.Items.Clear();
                Productpanel.Controls.Clear();
                txtgiam.Text = "0";
                txtconlai.Text = "0";
                txttong.Text = "0";
                lbtenkhachhang.Text = "";
                txtdiem.Text = "0";
            }
        }

        private void txtsdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                DataTable dt = new DataTable();
                customer ct = new customer();

                dt = ct.timkiemkhachhang(txtsdt.Text);
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        lbtenkhachhang.Text = dr[0].ToString();
                        txtdiem.Text = dr[1].ToString();
                        txtidkhach.Text = dr[2].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("khong tim thay thong tin khach hang");
                    lbtenkhachhang.Text = "ten khach hang ......";
                }
            }

        }
        private int travebill_id()
        {
            Bill b = new Bill();
            int n;
            DataTable dt = b.traveidbillhientai();
            foreach (DataRow dr in dt.Rows)
            {
                n = int.Parse(dr[0].ToString());
                return n;
            }
            return 0;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            lvbill.Items.Clear();

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("bạn có xác định muốn dùng điểm k ?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                if (txtdiem.Text.Equals("")) return;
                if(float.Parse(txtdiem.Text)<float.Parse(txtconlai.Text))
                {
                   
                    float tam = float.Parse(txtconlai.Text) - float.Parse(txtdiem.Text);
                    txtdiem.Text = "0";
                 
                    txtconlai.Text =  tam+"";
                }


                else
                {
             
                    float diem = float.Parse(txtdiem.Text) - float.Parse(txtconlai.Text);
                    txtdiem.Text = diem + "";
                    txtconlai.Text = "0";
                }
            }
        }
    }
}
