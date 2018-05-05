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

namespace Paint
{
	public partial class Form1 : Form
	{ enum Tool { Pens,Line, Rectangle,Circle,Triangle,Right_triangle,Erase,Fill}
			
		Graphics g;
		GraphicsPath path;
		Pen pen;
		Point prev;
		Bitmap btm;
		Tool tools;
		Queue<Point> q;
		Color Color1, Color2;
		

		public Form1()
		{
			InitializeComponent();
			pen = new Pen(Color.Red, 3);
			path = new GraphicsPath();

			btm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
			pictureBox1.Image = btm;
			tools = Tool.Pens;
			//numericUpDown1.Value = 2;
		
			q = new Queue<Point>();

			

			//Creat graphics from bitmap
			g = Graphics.FromImage(btm);
			g.Clear(Color.White);
			button1.BackColor = pen.Color;
		}

		
      

		private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			prev = e.Location;
			if (tools == Tool.Fill && btm.GetPixel(e.X, e.Y).ToArgb() != button1.BackColor.ToArgb())
			{
				q.Enqueue(e.Location);
				Color1 = btm.GetPixel(e.X, e.Y);
				Color2 = button1.BackColor;
				while (q.Count > 0)
				{
					int x = q.First().X;
					int y = q.First().Y;
					Fill(x, y + 1);
					Fill(x, y - 1);
					Fill(x - 1, y);
					Fill(x + 1, y);
					q.Dequeue();

				}
				Refresh();
			
		}
	}
		void Fill(int x, int y)
		{
			if (x >= btm.Width)
				return;
			if (x < 0)
				return;
			if (y >= btm.Height)
				return;
			if (y < 0)
				return;
			if (btm.GetPixel(x, y) != Color1)
				return;

			btm.SetPixel(x, y, Color2);
			q.Enqueue(new Point(x, y));
		}

		private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
		{
			// Remove all previous shapes in Graphicspath
			path.Reset();
			Point cur = e.Location;

			// check for mouse left button clicked

			if (e.Button == MouseButtons.Left)
			{
				switch (tools)
				{
					case Tool.Pens:
						g.DrawLine(pen, prev, cur);
						prev = cur;
						break;
					case Tool.Line:
						path.AddLine(prev, cur);
						break;
					case Tool.Rectangle:
						int x = Math.Min(prev.X, cur.X);
						int y = Math.Min(prev.Y, cur.Y);
						int a = Math.Abs(prev.X - cur.X);
						int b = Math.Abs(prev.Y - cur.Y);

						path.AddRectangle(new Rectangle(x, y, a, b));
						break;
					
					case Tool.Circle:
						int xxx = Math.Min(prev.X, cur.X);
						int yyy = Math.Min(prev.Y, cur.Y);
						int aaa = Math.Abs(prev.X - cur.X);
						int bbb = Math.Abs(prev.Y - cur.Y);
						path.AddEllipse(new Rectangle(xxx, yyy, aaa, bbb));
						break;
					case Tool.Triangle:
						Point[] p = new Point[3];
						p[0] = prev;
						p[1] = cur;
						p[2] = new Point(prev.X, cur.Y);
						path.AddPolygon(p);
						break;
					case Tool.Right_triangle:
						Point[] pp = new Point[3];
						pp[0]= new Point((prev.X + cur.X)/2,prev.Y);
						pp[1] = cur;
						pp[2] = new Point(prev.X, cur.Y);
						path.AddPolygon(pp);
						break;
					case Tool.Erase:
						cur = e.Location;
						g.DrawLine(new Pen(Color.White, pen.Width), prev, cur);
						prev = cur;
						break;
						


				}
				
				

				

				//reddraw picturbox
				pictureBox1.Refresh();
			}
		}

		private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
		{
			if (path != null)
			{
				g.DrawPath(pen, path);
			}
		}

		private void pictureBox1_Paint(object sender, PaintEventArgs e)
		{
			e.Graphics.DrawPath(pen, path);
		}
		private void colorDialog_Click(object sender, EventArgs e)
		{
			if (colorDialog1.ShowDialog() == DialogResult.OK)
			{
				button1.BackColor = colorDialog1.Color;
				pen.Color = colorDialog1.Color;
			}
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (comboBox1.SelectedIndex)
			{
				case 0: pen.Width = 2; break;
				case 1: pen.Width = 4; break;
				case 2: pen.Width = 6; break;
				case 3: pen.Width = 8; break;
				case 4: pen.Width = 10; break;
				case 5: pen.Width = 12; break;
			}
		}
		private void color_button_Click(object sender, EventArgs e)
		{
			Button btn = sender as Button;
			pen.Color = btn.BackColor;
			button1.BackColor = btn.BackColor;
		}
		private void toolStripMenuItem4_Click(object sender, EventArgs e) // save
		{

		}

		/*private void toolStripMenuItem5_Click(object sender, EventArgs e) // save as
		{
			saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.* | (*.jpg*)|*.jpg| (*.png*)|*png";

			ImageFormat format = ImageFormat.Png;
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				string ext = System.IO.Path.GetExtension(saveFileDialog1.FileName);
				MessageBox.Show(ext);
				switch (ext)
				{
					case ".jpg":
						format = ImageFormat.Jpeg;
						break;
					case ".bmp":
						format = ImageFormat.Bmp;
						break;
					case ".png":
						format = ImageFormat.Png;
						break;
				}
				btm.Save(saveFileDialog1.FileName, format);
			}
		}
		private void toolStripMenuItem3_Click(object sender, EventArgs e) // open
		{
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				btm = new Bitmap(openFileDialog1.FileName);
				pictureBox1.Image = btm;
				g = Graphics.FromImage(btm);

			}
		}*/

		private void Tool_clicked(object sender,EventArgs e)
		{
			Button btn = sender as Button;
			switch (btn.Text)
			{
				case "Pens":
					tools = Tool.Pens;
					break;
				case "Line":
					tools = Tool.Line;
					break;
				case "Rectagle":
					tools = Tool.Rectangle;
					break;
				case "Circle":
					tools = Tool.Circle;
					break;
				
				case "Triangle":
					tools = Tool.Triangle;
					break;
				case "Right_triangle":
					tools = Tool.Right_triangle;
					break;
				case "Erase":
					tools = Tool.Erase;
					break;
				case "Fill":
					tools = Tool.Fill;
					break;
				
			}
		}
	/*	private void Color_Click(object sender,EventArgs e)
		{
			colorDialog1.Color = button1.BackColor;
			if (colorDialog1.ShowDialog() == DialogResult.OK)
			{
				button1.BackColor = colorDialog1.Color;
				pen = new Pen(colorDialog1.Color, float.Parse(numericUpDown1.Value.ToString()));
			}
				}
		        private void openToolStripMenuItem_Click(object sender,EventArgs e)
		{
			if(openFileDialog1.ShownDialog()== DialogResult.OK)
			{
				openFileDialog1.OpenFile();
				btm = new Bitmap(openFileDialog1.FileName);
				pictureBox1.Image = btm;
			}
			private void closeToolStripMenuItem_Click(object sender, EventArgs e)
			{
				Close();
			}

			private void saveToolStripMenuItem_Click(object sender, EventArgs e)
			{
				//Bitmap Image(.bmp)| *.bmp |
				saveFileDialog1.Filter = "Png Image (.png)|*.png ";

				if (saveFileDialog1.ShowDialog() == DialogResult.OK)
				{
					string filename = saveFileDialog1.FileName;

					btm.Save(filename);

				}

			}

			private void numericUpDown1_ValueChanged(object sender, EventArgs e)
			{
				pen = new Pen(colorDialog1.Color, float.Parse((numericUpDown1.Value).ToString()));
			}
		}*/
          		
	}
}
