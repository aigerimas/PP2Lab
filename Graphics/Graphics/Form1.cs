using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics1
{
	public partial class Form1 : Form
	{

		Graphics g;
		public Form1()
		{
			g = CreateGraphics();
			InitializeComponent();
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.DrawLine(Pens.Red, 200, 10, 200, 200);
			Point p1 = new Point(10, 10);
			Point p2 = new Point(100, 100);

			e.Graphics.DrawLine(Pens.Blue, p1, p2);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Pen p = new Pen(Color.Yellow, 5);

			Rectangle r = new Rectangle(150, 150, 100, 100);
			g.DrawRectangle(p, r);


			p = new Pen(Color.Violet, 7);
			g.DrawEllipse(p, r);


			Point[] arr = {
				new Point(10, 10),
				new Point(300, 50),
				new Point(150, 200),
				new Point(30, 200)
			};

			p = new Pen(Color.Pink, 5);
			g.DrawPolygon(p, arr);
		}
	}
}
