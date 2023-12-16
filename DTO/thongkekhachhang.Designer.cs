namespace doanc_.DTO
{
    partial class thongkekhachhang
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
            this.cbkh = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.cbkh)).BeginInit();
            this.SuspendLayout();
            // 
            // cbkh
            // 
            chartArea1.Name = "ChartArea1";
            this.cbkh.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.cbkh.Legends.Add(legend1);
            this.cbkh.Location = new System.Drawing.Point(12, 12);
            this.cbkh.Name = "cbkh";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "name";
            this.cbkh.Series.Add(series1);
            this.cbkh.Size = new System.Drawing.Size(996, 499);
            this.cbkh.TabIndex = 0;
            this.cbkh.Text = "chart1";
            // 
            // thongkekhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 544);
            this.Controls.Add(this.cbkh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "thongkekhachhang";
            this.Text = "thongkekhachhang";
            this.Load += new System.EventHandler(this.thongkekhachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbkh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart cbkh;
    }
}