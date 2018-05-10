using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final4
{
	public partial class Form1 : Form
	{
		Graphics g;
		
	
		public Form1()
		{
			InitializeComponent();
			g = CreateGraphics();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			/*SolidBrush brush = new SolidBrush(Color.Blue);
			Rectangle r = new Rectangle(40.40,600, 600);
			e.Graphics.FillRectangle(brush, r);

			Point[] arr =
			{
				g.FillPolygon(Brushes.Red ,art);
			}*/
		}

		private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
		{
			g.FillEllipse(Brushes.Purple, e.Location.X - 20, e.Location.Y - 20, 40, 40);

		}

		private void button1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
		{

		}
	}
}
