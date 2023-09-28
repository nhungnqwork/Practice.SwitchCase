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

namespace QuanLy_ToiPhamTheKy
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        private void FormReport_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLy_ToiPhamTheKy.Report1.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DataSet1";
            reportDataSource.Value = modify.Table("select * from NgayVeTbl");
            //reportDataSource.Value = modify.Table("select * from NgayVeTbl where MaSoKetAn >= 21090000");
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
