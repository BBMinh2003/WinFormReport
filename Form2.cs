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

namespace ReportTest
{
	public partial class Form2 : Form
	{
		SqlConnection con = new SqlConnection("Data Source=LAPTOP-7O28A2UH\\SQLEXPRESS;Initial Catalog=QLTrungTamDayHoc;Integrated Security=True");
		public Form2()
		{
			InitializeComponent();
			this.CenterToScreen();
		}
		private void Form2_Load(object sender, EventArgs e)
		{
			LoadPhongHoc();
		}
		private void LoadPhongHoc()
		{
			con.Open();
			string query = "SELECT MaPhong FROM LopHoc";
			SqlCommand command = new SqlCommand(query, con);

			using (SqlDataReader reader = command.ExecuteReader())
			{
				while (reader.Read())
				{
					string maPhong = reader.GetString(0);
					comboBox1.Items.Add(maPhong);
				}
			}
			con.Close();

			this.reportViewer1.RefreshReport();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			con.Open();
			SqlCommand cmd = new SqlCommand("select * from PhongHoc " +
				"inner join LopHoc on PhongHoc.MaPhong = LopHoc.MaPhong  " +
				"WHERE PhongHoc.MaPhong = N'" + comboBox1.Text + "';", con);
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);

			ReportDataSource danhsachlop = new ReportDataSource("DataSet1", dt);
			reportViewer1.LocalReport.ReportPath = "C:\\Users\\admin\\Documents\\Kỳ 5\\Lập trình trực quan\\C#\\ReportTest\\DanhSachPhong-Lop.rdlc";
			reportViewer1.LocalReport.DataSources.Clear();
			reportViewer1.LocalReport.DataSources.Add(danhsachlop);
			reportViewer1.RefreshReport();
			con.Close();
		}
	}
}
