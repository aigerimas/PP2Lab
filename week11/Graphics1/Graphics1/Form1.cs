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
	    int xt = 400;
		int st = 400;
		int arx = 250;
		int ary = 150;
		int adx = 550;
		int ady = 150;
		int atx = 450;
		int aty = 350;
		int aix = 150;
		int aiy = 250;
		int ax = 430;
		int ay = 200;
		int b = 10;
		
		public Form1()
		{
			InitializeComponent();
			g = CreateGraphics();
			timer1.Start();
			timer2.Start();
			
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
				new Point(xt,240),
				new Point(xt-30,250),
				new Point(xt-30, 270),
				new Point(xt, 280),
				new Point(xt+30,270),
				new Point(xt+30,250),
			};

			p = new Pen(Color.Yellow, 5);
			g.FillPolygon(Brushes.Yellow, arr);

			Point[] stt =
			{
				new Point(st,245),
				new Point(st-10, 260),
				new Point(st-5,260),
				new Point(st-5,270),
				new Point(st+5,270),
				new Point(st+5,260),
				new Point(st+10,260),

			};
			p = new Pen(Color.Green, 5);
			g.FillPolygon(Brushes.Green, stt);

			Point[] art =
			{
				new Point(arx,ary),
				new Point(arx+10,ary+15),
				new Point(arx+25,ary+15),
				new Point(arx+15,ary+25),
				new Point(arx+25,ary+35),
				new Point(arx+10,ary+35),
				new Point(arx,ary+50),
				new Point(arx-10,ary+35),
				new Point(arx-25,ary+35),
				new Point(arx-15,ary+25),
				new Point(arx-25,ary+15),
				new Point(arx-10,ary+15),
			};
			g.FillPolygon(Brushes.Red, art);

			Point[] a =
			{
				new Point(adx,ady),
				new Point(adx+10,ady+15),
				new Point(adx+25,ady+15),
				new Point(adx+15,ady+25),
				new Point(adx+25,ady+35),
				new Point(adx+10,ady+35),
				new Point(adx,ady+50),
				new Point(adx-10,ady+35),
				new Point(adx-25,ady+35),
				new Point(adx-15,ady+25),
				new Point(adx-25,ady+15),
				new Point(adx-10,ady+15),

			};
			g.FillPolygon(Brushes.Red, a);

			Point[] att =
			{
				new Point(atx,aty),
				new Point(atx+10,aty+15),
				new Point(atx+25,aty+15),
				new Point(atx+15,aty+25),
				new Point(atx+25,aty+35),
				new Point(atx+10,aty+35),
				new Point(atx,aty+50),
				new Point(atx-10,aty+35),
				new Point(atx-25,aty+35),
				new Point(atx-15,aty+25),
				new Point(atx-25,aty+15), 
				new Point(atx-10,aty+15),
			};
			g.FillPolygon(Brushes.Red, att);

			Point[] ari =
			{
				new Point(aix,aiy),
				new Point(aix+10,aiy+15),
				new Point(aix+25,aiy+15),
				new Point(aix+15,aiy+25),
				new Point(aix+25,aiy+35),
				new Point(aix+10,aiy+35),
				new Point(aix,aiy+50),
				new Point(aix-10,aiy+35),
				new Point(aix-25,aiy+35),
				new Point(aix-15,aiy+25),
				new Point(aix-25,aiy+15),
				new Point(aix-10,aiy+15),
			};
			g.FillPolygon(Brushes.Red, ari);

			Point[] array =
			{
				new Point(ax,ay),
				new Point(ax+5,ay+10),
				new Point(ax+15,ay+15),
				new Point(ax+5,ay+20),
				new Point(ax,ay+30),
				new Point(ax-5,ay+20),
				new Point(ax-15,ay+15),
				new Point(ax-5,ay+10),
				};
			g.FillPolygon(Brushes.Green, array);

		}

		
					
			
		
			

				
			



            private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.A:
					xt -= 20;
					st -= 20;
              break;
				case Keys.D:
					xt += 20;
					st += 20;
					break;
			}
			
			Refresh();

			


		}

		private void timer2_Tick(object sender, EventArgs e)
		{
			if (b == 10)
				b = 7;
			else b = 10;
			Refresh();
		}

		

		private void timer1_Tick(object sender, EventArgs e)
		{
			ary += 10;
			if(ary + 10 > Height)
			{
				ary = new Random().Next(0, 50);
			}

			//Refresh();

			ady += 10;
			if(ady +10 > Height)
			{
				ady = new Random().Next(0, 50);
			}
			//Refresh();

			aty += 10;
			if(aty +10 > Height)
			{
				aty = new Random().Next(0, 50);
			}
			//Refresh();

			aiy +=10;
			if(aiy +10 >Height){
				aiy = new Random().Next(0, 50);
			}
			//Refresh();

			ay += 10;
			if(ay + 10 > Height)
			{
				ay = new Random().Next(0, 50);
			}
			Refresh();
		}
	}
}
