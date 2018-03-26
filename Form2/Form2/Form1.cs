using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		

		private void Form1_Load(object sender, EventArgs e)
		{

			Width = 500;
			Height = 500;
			BackColor = Color.Blue;

			Button btn = new Button();
			btn.Text = "my button";
			btn.Size = new Size(200, 100);
			btn.Font = new Font(FontFamily.GenericSansSerif, 30, FontStyle.Bold);
			btn.Location = new Point(50, 50);
			btn.Click += button1_Click;
			btn.BackColor = Color.Red;
			btn.ForeColor = Color.White;

			Controls.Add(btn);


		}

		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("asd");
		}
	}
}
