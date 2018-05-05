using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
	public partial class Form1 : Form
	{
		int score = 0;
	    Random random = new Random();
        public Form1()
		{
			InitializeComponent();
			timer1.Start();
		}
		
	

		private void button1_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.A:
					if (button1.Location.X - 20 > 0)
					{
						button1.Location = new Point(button1.Location.X - 20, button1.Location.Y);
					}
					break;
				case Keys.D:
					button1.Location = new Point(button1.Location.X + 20, button1.Location.Y);
					if (button1.Location.X >= Width)
					{
						button1.Location = new Point(0,button1.Location.Y);
					}
					break;
			}
		}

		private void button1_KeyPress(object sender, KeyPressEventArgs e)
	    {

		}
		
	
		private void timer1_Tick(object sender, EventArgs e)
		{
			label5.Text = "Score:" + score;
			Point p = label1.Location;
			p.Y += 20;

			if (p.Y > Height)
				p.Y = 0;
			label1.Location = p;

			Point p1 = label1.Location;
			if((p1.X>=button1.Location.X && p1.X<=button1.Location.X +button1.Width)&& p1.Y>button1.Location.Y && p1.Y<= button1.Location.Y + button1.Height)
			{
				timer1.Stop();
				MessageBox.Show("GAME OVER");
				if (p1.Y > Height)
				{
					p1.Y = 0;
					p1.Y = random.Next(500);
					score += 5;
				}
				p1.Y += 20;
				label1.Location = p1;
			}

			Point ar = label2.Location;
			ar.Y += 20;
             if (ar.Y > Height)
				ar.Y = 0;
			label2.Location = ar;


          Point p2 = label2.Location;
			if ((p2.X >= button1.Location.X && p2.X <= button1.Location.X + button1.Width) && p2.Y > button1.Location.Y && p2.Y <= button1.Location.Y + button1.Height)

			{
				timer1.Stop();
				MessageBox.Show("GAME OVER");
				if (p2.Y > Height)
				{
					p2.Y = 0;
					p2.X = random.Next(500);
					score += 5;
				}
				p2.Y += 20;
				label2.Location = p2;
			}

			Point at = label3.Location;
			at.Y += 20;
			if (at.Y > Height)
				at.Y = 0;
			label3.Location = at;

			Point p3 = label3.Location;
			if ((p3.X >= button1.Location.X && p3.X <= button1.Location.X + button1.Width) && p3.Y > button1.Location.Y && p3.Y <= button1.Location.Y + button1.Height)

			{
				timer1.Stop();
				MessageBox.Show("GAME OVER");
				if (p3.Y > Height)
				{
					p3.Y = 0;
					p3.X = random.Next(500);
					score += 5;
				}
				p3.Y += 20;
				label3.Location = p3;
			}

			Point arr = label4.Location;
			arr.Y += 20;
			if (arr.Y > Height)
				arr.Y = 0;
			label4.Location = arr;

			Point p4 = label4.Location;
			if ((p4.X >= button1.Location.X && p4.X <= button1.Location.X + button1.Width) && p4.Y > button1.Location.Y && p4.Y <= button1.Location.Y + button1.Height)

			{
				timer1.Stop();
				MessageBox.Show("GAME OVER");
				if (p4.Y > Height)
				{
					p4.Y = 0;
					p4.X = random.Next(500);
					score += 5;
				}
				p4.Y += 20;
				label4.Location = p4;
			}

			Point aa = label6.Location;
			aa.Y += 20;
			if (aa.Y > Height)
				aa.Y = 0;
			label6.Location= aa;

			Point p5 = label6.Location;
			if((p5.X>=button1.Location.X && p5.X<=button1.Location.X + button1.Width) && p5.Y> button1.Location.Y && p5.Y<=button1.Location.Y+ button1.Height)
			{
				timer1.Stop();
				MessageBox.Show("GAME OVER");
			}

			score++;



			
		}

		
	}
}
