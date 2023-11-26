using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportTest
{
	public partial class Loading : Form
	{
		Timer LoadingTimer = new Timer();

		public Loading()
		{
			InitializeComponent();

			LoadingTimer.Interval = 500;
			LoadingTimer.Tick += new EventHandler(LoadingCompleted);

			this.CenterToScreen();
			this.ControlBox = false;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		}

		private void LoadingCompleted(object sender, EventArgs e)
		{
			LoadingTimer.Stop();
			this.Hide();
			Form3 form = new Form3();
			form.ShowDialog(); 
			this.Close();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			panelSlide.Left += 2;
			if(panelSlide.Left > 300)
			{
				panelSlide.Left = -100;
			}
		}

		private void Loading_Load(object sender, EventArgs e)
		{
			panel1.Visible = false; panelSlide.Visible = false;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			panel1.Visible = true;
			panelSlide.Visible = true;
			timer1.Start();
			LoadingTimer.Start();
		}
	}
}
