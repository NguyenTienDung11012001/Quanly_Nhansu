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
    public partial class frm_Baocao_Nhansu : Form
    {
        public frm_Baocao_Nhansu()
        {
            InitializeComponent();
        }
        public DataTable dt;

        private void frm_Baocao_Nhansu_Load(object sender, EventArgs e)
        {
            ReportDataSource reportDataSource = new ReportDataSource("DataSetNhansu", dt);
            rpvHienThi.LocalReport.DataSources.Add(reportDataSource);
            this.rpvHienThi.RefreshReport();
        }
    }
}
