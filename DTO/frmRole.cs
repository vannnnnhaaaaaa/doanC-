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
    public partial class frmRole : Form
    {
        public static string name = null;
        public  static string id = null;
        
        public frmRole()
        {
            InitializeComponent();
        }

 

        private void guna2ImageButton5_Click_1(object sender, EventArgs e)
        {
            Adduser adduser = new Adduser();
            adduser.ShowDialog();

        }
        
        private void loaddata()
        {
            Userbus ub = new Userbus();
            DataTable dt = ub.laydanhsachuser();
            dgvusers.DataSource = dt;
        }
        private void frmRole_Load(object sender, EventArgs e)
        {
            loaddata();

            
        }

        private void btchinhsua_Click(object sender, EventArgs e)
        {

        }

        private void dgvusers_Click(object sender, EventArgs e)
        {
            if (dgvusers.SelectedRows.Count > 0)
            {
                int n = dgvusers.CurrentCell.RowIndex;

                btphanquyen.Enabled = true;
                btphanquyen.BackColor = Color.NavajoWhite;

                name = dgvusers.Rows[n].Cells[1].Value.ToString();
                id = dgvusers.Rows[n].Cells[0].Value.ToString();

            }
         

        }

        private void btphanquyen_Click(object sender, EventArgs e)
        {
            repairpermision rp = new repairpermision(); 
            rp.ShowDialog();


        }
    }
}
