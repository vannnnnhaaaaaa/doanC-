namespace doanc_.DTO
{
    partial class thongkekhuyenmai
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chsp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chsp)).BeginInit();
            this.SuspendLayout();
            // 
            // chsp
            // 
            chartArea2.Name = "ChartArea1";
            this.chsp.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chsp.Legends.Add(legend2);
            this.chsp.Location = new System.Drawing.Point(21, 46);
            this.chsp.Name = "chsp";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Soluong";
            this.chsp.Series.Add(series2);
            this.chsp.Size = new System.Drawing.Size(996, 499);
            this.chsp.TabIndex = 2;
            this.chsp.Text = "chart1";
            // 
            // thongkekhuyenmai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 591);
            this.Controls.Add(this.chsp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "thongkekhuyenmai";
            this.Text = "thongkekhuyenmai";
            this.Load += new System.EventHandler(this.thongkekhuyenmai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chsp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chsp;
    }
}