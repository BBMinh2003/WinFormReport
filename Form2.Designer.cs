namespace ReportTest
{
	partial class Form2
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
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.button1 = new System.Windows.Forms.Button();
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(107, 16);
			this.label1.TabIndex = 9;
			this.label1.Text = "Chọn phòng học:";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(147, 44);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(185, 24);
			this.comboBox1.TabIndex = 8;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(352, 34);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(144, 42);
			this.button1.TabIndex = 7;
			this.button1.Text = "Xem danh sách lớp";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
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
			this.reportViewer1.TabIndex = 6;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1069, 555);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.reportViewer1);
			this.Name = "Form2";
			this.Text = "Form2";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button button1;
		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
	}
}