using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace endterm1
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

		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			



			
		}

		private void Form1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			Pen p = new Pen(Color.Yellow, 5);
			Rectangle r = new Rectangle(150, 150, 100, 100);
			g.DrawRectangle(p, r);
		}

		private void trackBar1_Scroll(object sender, EventArgs e)
		{

		}
	}
}
