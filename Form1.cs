using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ReportTest
{
	public partial class Form1 : Form
	{
		SqlConnection con = new SqlConnection("Data Source=LAPTOP-7O28A2UH\\SQLEXPRESS;Initial Catalog=QLTrungTamDayHoc;Integrated Security=True");
		public Form1()
		{
			InitializeComponent();
			this.CenterToScreen();
		}
		private void Form1_Load(object sender, EventArgs e)
		{
			LoadTenLop();
			Activate();
		}
		private void LoadTenLop()
		{
			con.Open();
			string query = "SELECT TenLop FROM LopHoc";
			SqlCommand command = new SqlCommand(query, con);

			using (SqlDataReader reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					string tenLop = reader.GetString(0);
					comboBox1.Items.Add(tenLop);
				}
			}
			con.Close();

			this.reportViewer1.RefreshReport();
		}
		private Boolean checkComboBox()
		{
			if (comboBox1.SelectedIndex < 0) return false;
			return true;
		}
		private void button1_Click(object sender, EventArgs e)
		{
			if (checkComboBox())
			{
				con.Open();
				SqlCommand cmd = new SqlCommand("SELECT * FROM HocVien " +
					"JOIN DanhSachHocSinh_MonHoc ON HocVien.MaHocVien = DanhSachHocSinh_MonHoc.MaHocVien " +
					"JOIN LopHoc ON DanhSachHocSinh_MonHoc.MaLop = LopHoc.MaLop " +
					"WHERE LopHoc.TenLop = N'" + comboBox1.Text + "';", con);
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);

				ReportDataSource danhsachdiem = new ReportDataSource("DataSet4", dt);
				reportViewer1.LocalReport.ReportPath = "C:\\Users\\admin\\Documents\\Kỳ 5\\Lập trình trực quan\\C#\\ReportTest\\BaoCaoDiem.rdlc";
				reportViewer1.LocalReport.DataSources.Clear();
				reportViewer1.LocalReport.DataSources.Add(danhsachdiem);
				reportViewer1.RefreshReport();
				con.Close();
			}
			else MessageBox.Show("Hãy chọn tên lớp");
			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (checkComboBox())
			{
				con.Open();
				SqlCommand cmd = new SqlCommand("select * from LopHoc" +
					" inner join MonHoc on LopHoc.MaMon = MonHoc.MaMon " +
					"where LopHoc.TenLop = N'" + comboBox1.Text + "';", con);
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);

				ReportDataSource doanhthu = new ReportDataSource("DataSet2", dt);
				reportViewer1.LocalReport.ReportPath = "C:\\Users\\admin\\Documents\\Kỳ 5\\Lập trình trực quan\\C#\\ReportTest\\BaoCaoDoanhThu.rdlc";
				reportViewer1.LocalReport.DataSources.Clear();
				reportViewer1.LocalReport.DataSources.Add(doanhthu);
				reportViewer1.RefreshReport();
				con.Close();
			}
			else MessageBox.Show("Hãy chọn tên lớp");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (checkComboBox())
			{
				con.Open();
				SqlCommand cmd = new SqlCommand("SELECT top 3 * FROM HocVien " +
					"JOIN DanhSachHocSinh_MonHoc ON HocVien.MaHocVien = DanhSachHocSinh_MonHoc.MaHocVien " +
					"JOIN LopHoc ON DanhSachHocSinh_MonHoc.MaLop = LopHoc.MaLop " +
					"WHERE LopHoc.TenLop = N'" + comboBox1.Text + "'" +
					"ORDER BY Diem desc;", con);
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);

				ReportDataSource top3 = new ReportDataSource("DataSet1", dt);
				reportViewer1.LocalReport.ReportPath = "C:\\Users\\admin\\Documents\\Kỳ 5\\Lập trình trực quan\\C#\\ReportTest\\BaoCaoTop3.rdlc";
				reportViewer1.LocalReport.DataSources.Clear();
				reportViewer1.LocalReport.DataSources.Add(top3);
				reportViewer1.RefreshReport();
				con.Close();
			}
			else MessageBox.Show("Hãy chọn tên lớp");
		}
	}
}
