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
    public partial class thongkekhuyenmai : Form
    {
        public thongkekhuyenmai()
        {
            InitializeComponent();
        }

        private void thongkekhuyenmai_Load(object sender, EventArgs e)
        {
            chsp.ChartAreas["ChartArea1"].AxisX.Title = "Mã code ";
            chsp.ChartAreas["ChartArea1"].AxisY.Title = "Số Lượng Sử Dụng";
            promotion pm = new promotion();
            DataTable dt = pm.thongke();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                chsp.Series["Soluong"].Points.AddXY(dt.Rows[i]["code"], dt.Rows[i]["code_count"]);
            }
        }
    }
}
