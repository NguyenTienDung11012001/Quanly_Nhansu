using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNhansu
{
    public partial class frmBaocao_Tuoi_Khoang : Form
    {
        public frmBaocao_Tuoi_Khoang()
        {
            InitializeComponent();
        }

        public DataTable dt;
        private void frmBaocao_Tuoi_Khoang_Load(object sender, EventArgs e)
        { 
            ReportDataSource reportDataSource = new ReportDataSource("DataSetTuoi_Khoang", dt);
            rpvHienThi.LocalReport.DataSources.Add(reportDataSource);
            this.rpvHienThi.RefreshReport();
        }
    }
}
