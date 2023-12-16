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
    public partial class frmPromotion : Form
    {
        public frmPromotion()
        {
            InitializeComponent();
        }
        Promotiondetails pd = new Promotiondetails();   
        private void loaddata()
        {
            cbevent.DataSource = pt.laydanhsachsukien(); cbevent.DisplayMember = "promotion_id"; cbevent.ValueMember = "promotion_id";
            cbevent.SelectedItem = null;

            dgvpromotion.DataSource = pd.lauydanhsachkhuyenmai();
        }
        promotion pt = new promotion();
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Addpromotion ad = new Addpromotion();   
           
            if(ad.ShowDialog() == DialogResult.Cancel)
            {
                loaddata();
            }
        }
        private bool ktrahople()
        {
            DateTime bd = dtpbd.Value;
            DateTime kt = dtpkt.Value;
            int compareResult = DateTime.Compare(bd, kt);

            if (txtid.Text.Equals("")|| txtname.Text.Equals("") )
            {
                MessageBox.Show("vui lòng nhập đầy đủ dữ liệu");
                return false;
               
            }
            if (compareResult >=0) {
                MessageBox.Show("ngay ket thuc phai lon hon ngay hien tai ");

                return false;
            }

            MessageBox.Show("thêm thành công");
          return true;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (ktrahople() ) {
                pt.themevent(txtid.Text , txtname.Text , dtpbd.Text, dtpkt.Text);
                loaddata();
            }
        }

        private void frmPromotion_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void cbevent_SelectionChangeCommitted(object sender, EventArgs e)
        {
           
            dgvpromotion.DataSource = pd.lauydanhsachkhuyenmaitheopm(cbevent.Text);
        }

        private void cbevent_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvpromotion.DataSource = pd.lauydanhsachkhuyenmaitheopm(cbevent.Text);
        }
    }
}
