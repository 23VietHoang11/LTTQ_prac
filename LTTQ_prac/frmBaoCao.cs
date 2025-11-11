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

namespace LTTQ_prac
{
    public partial class frmBaoCao : Form
    {
        private DataTable _data;

        public frmBaoCao(DataTable data)
        {
            InitializeComponent();
            _data = data;
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            // Đường dẫn file .rdlc (phải tồn tại trong project)
            reportViewer1.LocalReport.ReportPath = "D:\\UTC-ITK64\\LTTQ\\LuyenTap\\LTTQ_prac\\LTTQ_prac\\Report.rdlc";

            // Xóa nguồn cũ (nếu có)
            reportViewer1.LocalReport.DataSources.Clear();

            // Thêm nguồn dữ liệu mới
            var source = new ReportDataSource("DataSet1", _data);
            reportViewer1.LocalReport.DataSources.Add(source);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
