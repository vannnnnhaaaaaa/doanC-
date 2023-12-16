namespace doanc_.DTO
{
    partial class Thongkesanpham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chsp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chsp)).BeginInit();
            this.SuspendLayout();
            // 
            // chsp
            // 
            chartArea1.Name = "ChartArea1";
            this.chsp.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chsp.Legends.Add(legend1);
            this.chsp.Location = new System.Drawing.Point(30, 41);
            this.chsp.Name = "chsp";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Soluong";
            this.chsp.Series.Add(series1);
            this.chsp.Size = new System.Drawing.Size(996, 499);
            this.chsp.TabIndex = 1;
            this.chsp.Text = "chart1";
            // 
            // Thongkesanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 591);
            this.Controls.Add(this.chsp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Thongkesanpham";
            this.Text = "Thongkesanpham";
            this.Load += new System.EventHandler(this.Thongkesanpham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chsp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chsp;
    }
}