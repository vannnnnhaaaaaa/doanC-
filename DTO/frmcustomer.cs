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
    public partial class frmcustomer : Form
    {
        public frmcustomer()
        {
            InitializeComponent();
        }

        customer ct = new customer();

        private void loaddata()
        {
            
            dgvdskhachhang.DataSource = ct.laydanhsachkhachhang();
        }
        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public virtual void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetdata()
        {
            txtdiem.Text = null;
            txtemail.Text = null;
            txthovaten.Text = null;
            txtsdt.Text = null;
            txttongtien.Text = null;
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
           resetdata();
        }

        private bool kientrahople()
        {
            if (txthovaten.Text.Equals("") || txtemail.Text.Equals("") || txtsdt.Text.Equals(""))
            {
                return false;
            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (kientrahople()== true)
            {
                ct.themkhachhang(txthovaten.Text, txtsdt.Text, txtemail.Text);
                resetdata();
                loaddata();
            }
            else
            {
                MessageBox.Show("vui long dien day du thong tin");
            }
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string n = dgvdskhachhang.CurrentCell.RowIndex + 1 + " ";
            
            ct.suathongtinkhachhang( n,  txthovaten.Text, txtsdt.Text, txtemail.Text);
            MessageBox.Show("thay đổi thành công");
            resetdata();
            loaddata();
        }

        private void frmcustomer_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void dgvdskhachhang_Click(object sender, EventArgs e)
        {
            int n = dgvdskhachhang.CurrentCell.RowIndex ;
            txthovaten.Text = dgvdskhachhang.Rows[n].Cells[1].Value.ToString() ;
            txtsdt.Text = dgvdskhachhang.Rows[n].Cells[2].Value.ToString() ;
            txtemail.Text = dgvdskhachhang.Rows[n].Cells[3].Value.ToString();
            txttongtien.Text = dgvdskhachhang.Rows[n].Cells[4].Value.ToString();
            txtdiem.Text = dgvdskhachhang.Rows[n].Cells[5].Value.ToString();
        }
    }
}
