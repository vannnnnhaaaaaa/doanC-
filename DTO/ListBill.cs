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
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;
namespace doanc_.DTO
{
    public partial class ListBill : Form
    {
        public ListBill()
        {
            InitializeComponent();
        }

        private void ListBill_Load(object sender, EventArgs e)
        {
            Bill b = new Bill();
          
            dgvbill.DataSource = b.laydanhsachhoadon(); ;
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void xuatexcel(DataGridView g , string duongdan , string tepTan)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 15;
            for (int i = 1;i<g.Columns.Count+1;i++) {
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
            }
            for (int i=0;i<g.Rows.Count;i++)
            {
                for(int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value !=null)
                    {
                        obj.Cells[i+2,j+1] = g.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongdan +tepTan+".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            xuatexcel(dgvbill, @"C:\Users\admin\source\repos\doanC#", "XuatfileExcel");
            MessageBox.Show("xuat file thanh cong");
        }
    }
}
