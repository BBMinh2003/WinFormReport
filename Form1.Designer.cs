namespace ReportTest
{
	partial class Form1
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
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.button1 = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// reportViewer1
			// 
			this.reportViewer1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.reportViewer1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "ReportTest.Report1.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(0, 88);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(1069, 467);
			this.reportViewer1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(352, 25);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(108, 42);
			this.button1.TabIndex = 1;
			this.button1.Text = "Xem báo cáo điểm học viên";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(147, 35);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(185, 24);
			this.comboBox1.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(43, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Chọn lớp học:";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(480, 25);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(108, 42);
			this.button2.TabIndex = 4;
			this.button2.Text = "Xem doanh thu của lớp";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(604, 25);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(115, 42);
			this.button3.TabIndex = 5;
			this.button3.Text = "Xem top 3 học viên của lớp";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1069, 555);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.reportViewer1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
	}
}

