using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tank
{
	public partial class Form1 : Form
	{
		bool K;
		Graphics g;
		Pen p = new Pen(Color.Red, 2);
		int x = 50;
		int y = 50;
		int w = 20;
		int h = 20;
		int a;
		int b;

		public Form1()
		{
			InitializeComponent();
			timer1.Start();
			g = CreateGraphics();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			g.DrawRectangle(p, x, y, w, h);
			g.DrawLine(p, x + w, (y + h / 2), x + w + 15, (y + h / 2));
			if (K)
			{
				a = a + 2;
				g.DrawLine(p, a + x + w + 15, y + h / 2, a + x + w + 20, y + h / 2);
			}

		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Space)
			{
				K = true;
			}
			if (e.KeyCode == Keys.W)
			{

			}

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			Refresh();
		}
	}
}
