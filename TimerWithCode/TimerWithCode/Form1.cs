using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerWithCode
{
	public partial class Form1 : Form
	{
		Label l;
		Timer t;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			Button btn = new Button();
			btn.Text = "Start";
			btn.Size = new Size(300, 200);
			btn.Font = new Font(FontFamily.GenericMonospace, 20, FontStyle.Bold);
			btn.Location = new Point(50, 10);
			btn.Click += Form1_Click;

			l = new Label();
			l.Font = new Font(FontFamily.GenericMonospace, 30, FontStyle.Italic);
			l.Text = "empty";
			l.Location = new Point(50, 200);
			l.Height = 70;
			l.Width = 300;

			t = new Timer();
			t.Interval = 1000;
			t.Tick += timer1_Tick;

			Controls.Add(btn);
			Controls.Add(l);
		}

		private void Form1_Click(object sender, EventArgs e)
		{
			t.Start();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			l.Text = DateTime.Now.ToLongTimeString();
		}
	}
}
