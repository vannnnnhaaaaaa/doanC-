﻿using System;
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
    public partial class frmthongke : Form
    {
        public frmthongke()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public void AddControls(Form f)
        {
            pnchinh.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;

            pnchinh.Controls.Add(f);
            f.Show();
        }
        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {
            
            
        }

        private void frmthongke_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel4_Click(object sender, EventArgs e)
        {
            AddControls(new Thongkesanpham());
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {   
        }

        private void guna2Panel3_Click(object sender, EventArgs e)
        {
            AddControls(new thongkekhachhang());
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_MouseClick(object sender, MouseEventArgs e)
        {
            AddControls(new thongkekhuyenmai());
        }
    }
}
