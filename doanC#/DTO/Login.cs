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
    public partial class Login : Form
    {
        public static int Actor = 0;
        public static int is_product = 0;
        public static int is_promo = 0;
        public static int is_bill = 0;
        public static int is_recieved = 0;
        public Login()
        {
            InitializeComponent();
        }

        Userbus us = new Userbus();
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void ktrarole()
        {

        }
        
        public bool ktratkmk(string tk, string mk)
        {
            for (int i = 0; i < us.laydanhsachdangnhap().Rows.Count; i++)
            {
                if (us.laydanhsachdangnhap().Rows[i][0].Equals(tk) &&
                    us.laydanhsachdangnhap().Rows[i][1].Equals(mk))
                {
                    int n =   int.Parse( us.laydanhsachdangnhap().Rows[i][2].ToString());

                   
                    is_bill = int.Parse(us.layquyenhan(n).Rows[0][0].ToString());
                    is_product = int.Parse(us.layquyenhan(n).Rows[0][1].ToString());
                    is_recieved = int.Parse(us.layquyenhan(n).Rows[0][2].ToString());
                    is_promo = int.Parse(us.layquyenhan(n).Rows[0][3].ToString());
                    Actor = int.Parse(us.layquyenhan(n).Rows[0][4].ToString());


                    
                    return true;

                }
            }
            return false;
        }
       
        public void ktradangnhap(String tk, String mk)
        {
            if (tk == null)
            {
                MessageBox.Show("ko duoc de trong username");
            }
            else if (mk == null)
            {
                MessageBox.Show("ko duoc de trong password");
            }
            else if (ktratkmk(tk, mk) == true)
            {
               
                this.Hide();
                Frmmain main = new Frmmain();
                main.Show();
            }
            else
            {
                MessageBox.Show("dang nhap thong tin k chinh xac vui long ktra lai");

            }

        }
        private void guna2TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

                if (txtuser.Text.Length == 0 || txtpassword.Text.Length == 0)
                {
                    MessageBox.Show("phai nhap day du tai khoan mat khau ");
                    return;
                }
                ktradangnhap(txtuser.Text, txtpassword.Text);

            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtuser.Text.Length == 0 || txtpassword.Text.Length==0)
            {
                MessageBox.Show("phai nhap day du tai khoan mat khau ");
                return;
            }
            ktradangnhap(txtuser.Text, txtpassword.Text);
        }

        private void txtuser_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtuser_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                txtpassword.Focus();
            }
        }
    }
    }
