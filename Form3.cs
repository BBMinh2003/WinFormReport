using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ReportTest
{
	public partial class Form3 : Form
	{
		SqlConnection con = new SqlConnection("Data Source=LAPTOP-7O28A2UH\\SQLEXPRESS;Initial Catalog=QLTrungTamDayHoc;Integrated Security=True");
		public Form3()
		{
			InitializeComponent();
		}

		private void Form3_Load(object sender, EventArgs e)
		{
			con.Open();
			SqlCommand cmd = new SqlCommand("WITH Top3Students AS" +
				"(SELECT DHS.MaLop, HV.*,DHS.Diem,DHS.XepLoai,ROW_NUMBER() OVER (PARTITION BY DHS.MaLop ORDER BY DHS.Diem DESC) AS RowNum" +
				" FROM DanhSachHocSinh_MonHoc DHS" +
				" INNER JOIN HocVien HV ON DHS.MaHocVien = HV.MaHocVien)" +
				"SELECT * FROM Top3Students WHERE RowNum <= 3;", con);
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);

			ReportDataSource danhsachhv = new ReportDataSource("DataSet1", dt);
			reportViewer1.LocalReport.ReportPath = "C:\\Users\\admin\\Documents\\Kỳ 5\\Lập trình trực quan\\C#\\ReportTest\\DanhSachTopHocVien.rdlc";
			reportViewer1.LocalReport.DataSources.Clear();
			reportViewer1.LocalReport.DataSources.Add(danhsachhv);
			reportViewer1.RefreshReport();
			con.Close();
			this.reportViewer1.RefreshReport();
        }
    }
}
