using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace endterm3
{
	public partial class Form1 : Form
	{
		Graphics g;
		GraphicsPath path;
		Pen pen;
		Point prev;
		Bitmap btm;
		public Form1()
		{
			InitializeComponent();
			InitializeComponent();
			pen = new Pen(Color.Red, 3);
			path = new GraphicsPath();

			btm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
			pictureBox1.Image = btm;
			g = Graphics.FromImage(btm);
			g.Clear(Color.White);
		}
	}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
		{

		}

		private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
		{

		}
	}
}
