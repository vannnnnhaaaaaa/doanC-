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
    public partial class Thongkesanpham : Form
    {
        public Thongkesanpham()
        {
            InitializeComponent();
        }

        private void Thongkesanpham_Load(object sender, EventArgs e)
        {
            chsp.ChartAreas["ChartArea1"].AxisX.Title = "Mã Sản Phẩm";
            chsp.ChartAreas["ChartArea1"].AxisY.Title = "Số Lượng Sản Phẩm Đã Bán";
            productbus pd = new productbus();
            DataTable dt = pd.thongkesanpham();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                chsp.Series["Soluong"].Points.AddXY(dt.Rows[i]["product_id"], dt.Rows[i]["product_count"]);
            }
        }

        private void chsp_Click(object sender, EventArgs e)
        {

        }
    }
}
