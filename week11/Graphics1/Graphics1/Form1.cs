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
			InitializeComponent();
			g = CreateGraphics();

			
		}



		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			SolidBrush brush = new SolidBrush(Color.Blue);
			Rectangle r = new Rectangle(40, 40, 600, 400);
			e.Graphics.FillRectangle(brush, r);

			Pen p = new Pen(Color.Black, 5);
			e.Graphics.DrawRectangle(p, r);

			SolidBrush b = new SolidBrush(Color.Blue);
			g.FillRectangle(b, 40, 40, 600, 400);
			b = new SolidBrush(Color.White);
			g.FillEllipse(b, 100, 100, 25, 25);
			g.FillEllipse(b, 300, 300, 25, 25);
			g.FillEllipse(b, 100, 350, 25, 25);
			g.FillEllipse(b, 300, 100, 25, 25);
			g.FillEllipse(b, 600, 400, 25, 25);
			g.FillEllipse(b, 600, 180, 25, 25);
			g.FillEllipse(b, 500, 260, 25, 25);
			g.FillEllipse(b, 420, 150, 25, 25);


			Point[] arr = {
				new Point(400,240),
				new Point(370,250),
				new Point(370, 270),
				new Point(400, 280),
				new Point(430,270),
				new Point(430,250),
			};

			p = new Pen(Color.Yellow, 5);
			g.FillPolygon(Brushes.Yellow, arr);

			Point[] stt =
			{
				new Point(400,245),
				new Point(390, 260),
				new Point(395,260),
				new Point(395,270),
				new Point(405,270),
				new Point(405,260),
				new Point(410,260),

			};
			p = new Pen(Color.Green, 5);
			g.FillPolygon(Brushes.Green, stt);

			Point[] add =
			{
				new Point(200,100),
				new Point(250,150),
				new Point(150,150),
			};
			p = new Pen(Color.Red, 5);
			g.FillPolygon(Brushes.Red, add);

			Point[] a =
			{
				new Point(150, 125),
				new Point(250, 125),
				new Point(200, 175)
			};
			g.FillPolygon(Brushes.Red, a);






		}
	}
}
