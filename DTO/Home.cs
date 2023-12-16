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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            Bill b = new Bill();
            DataTable dt = new DataTable();
            dt = b.laydanhsachhoadon();
            dgvbill.DataSource = dt;
        }

        private void guna2VSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void dgvbill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void guna2DataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void dgvbill_Click(object sender, EventArgs e)
        {

            int n = dgvbill.CurrentCell.RowIndex;
            string id = dgvbill.Rows[n].Cells[0].Value.ToString();
            Bill b = new Bill();
           
            dgvchitiet.DataSource = b.laychitiethoadon(int.Parse(id));

        }
    }
}
