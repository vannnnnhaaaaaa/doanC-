namespace doanc_.DTO
{
    partial class Ucproduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbanh = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtten = new System.Windows.Forms.Label();
            this.txtgia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbanh)).BeginInit();
            this.SuspendLayout();
            // 
            // pbanh
            // 
            this.pbanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbanh.Image = global::doanc_.Properties.Resources.sneakers__1_;
            this.pbanh.ImageRotate = 0F;
            this.pbanh.Location = new System.Drawing.Point(0, 0);
            this.pbanh.Name = "pbanh";
            this.pbanh.Size = new System.Drawing.Size(161, 124);
            this.pbanh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbanh.TabIndex = 0;
            this.pbanh.TabStop = false;
            this.pbanh.Click += new System.EventHandler(this.pbanh_Click);
            // 
            // txtten
            // 
            this.txtten.AutoSize = true;
            this.txtten.Location = new System.Drawing.Point(14, 144);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(44, 16);
            this.txtten.TabIndex = 1;
            this.txtten.Text = "label1";
            // 
            // txtgia
            // 
            this.txtgia.AutoSize = true;
            this.txtgia.Location = new System.Drawing.Point(89, 144);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(44, 16);
            this.txtgia.TabIndex = 2;
            this.txtgia.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "$";
            // 
            // Ucproduct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtgia);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.pbanh);
            this.Name = "Ucproduct";
            this.Size = new System.Drawing.Size(161, 181);
            this.Load += new System.EventHandler(this.Ucproduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pbanh;
        private System.Windows.Forms.Label txtten;
        private System.Windows.Forms.Label txtgia;
        private System.Windows.Forms.Label label1;
    }
}
