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
    public partial class thongkekhachhang : Form
    {
        public thongkekhachhang()
        {
            InitializeComponent();
        }

        private void thongkekhachhang_Load(object sender, EventArgs e)
        {
            cbkh.ChartAreas["ChartArea1"].AxisX.Title = "Tên Khách Hàng ";
            cbkh.ChartAreas["ChartArea1"].AxisY.Title = "Tổng tiền đã mua ";
            customer ct = new customer();
            DataTable dt = ct.travetopmuahang();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbkh.Series["name"].Points.AddXY(dt.Rows[i]["name"], dt.Rows[i]["total_pay"]);
            }
        }
    }
}
