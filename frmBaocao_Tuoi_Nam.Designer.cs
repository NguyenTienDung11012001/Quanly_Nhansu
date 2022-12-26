namespace QLNhansu
{
    partial class frmBaocao_Tuoi_Nam
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
            this.rpvHienThi = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpvHienThi
            // 
            this.rpvHienThi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvHienThi.LocalReport.ReportEmbeddedResource = "QLNhansu.ReportTuoi_Nam.rdlc";
            this.rpvHienThi.Location = new System.Drawing.Point(0, 0);
            this.rpvHienThi.Name = "rpvHienThi";
            this.rpvHienThi.ServerReport.BearerToken = null;
            this.rpvHienThi.Size = new System.Drawing.Size(809, 586);
            this.rpvHienThi.TabIndex = 3;
            // 
            // frmBaocao_Tuoi_Nam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 586);
            this.Controls.Add(this.rpvHienThi);
            this.Name = "frmBaocao_Tuoi_Nam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBaocao_Tuoi_Nam";
            this.Load += new System.EventHandler(this.frmBaocao_Tuoi_Nam_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvHienThi;
    }
}