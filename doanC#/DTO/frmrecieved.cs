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
    public partial class frmrecieved : Form
    {
        public frmrecieved()
        {
            InitializeComponent();
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void loaddata()
        {
            productbus pd = new productbus();
            dgvsanpham.DataSource = pd.danhsachgiay1();
        }
        private void frmrecieved_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void dgvsanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        int sl = 0;
        private void dgvsanpham_Click(object sender, EventArgs e)
        {
            int n = dgvsanpham.CurrentCell.RowIndex;

            Soluongsp sp = new Soluongsp();
            sp.ShowDialog();
            if (sp.travesoluong() > 0)
            {
                    ListViewItem lvi =
                    lvsp.Items.Add(dgvsanpham.Rows[n].Cells[0].Value.ToString() );
                    lvi.SubItems.Add(dgvsanpham.Rows[n].Cells[1].Value.ToString());
                    lvi.SubItems.Add(sp.travesoluong().ToString());
                    lvi.SubItems.Add(sp.travesize().ToString());
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (lvsp.Items.Count == 0)
            {
                MessageBox.Show("vui long chon san pham muon nhap hang");
            }
            else
            {
                productbus pb = new productbus();
                DialogResult dialog = MessageBox.Show("bạn có xác nhận muốn nhập lô hàng ?", "Thông báo", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                  
                    for (int i = 0; i < lvsp.Items.Count; i++)
                    {
                        int sl = pb.laysoluongsptheosize(lvsp.Items[i].SubItems[3].Text);
                        
                        try
                        {
                           

                            pb.themsizesp(lvsp.Items[i].SubItems[0].Text, int.Parse(lvsp.Items[i].SubItems[3].Text));
                            
                            MessageBox.Show(sl + "");
                            //pb.updatesoluongsp(int.Parse(lvsp.Items[i].SubItems[3].Text, sl);

                        }
                       catch {
                           // pb.updatesoluongsp(int.Parse(lvsp.Items[i].SubItems[3].Text, sl);
                        }
                    }
                    
                   

                    MessageBox.Show("nhap hang thành công");
                    lvsp.Items.Clear();
                }
            }
           
        }
    }
}