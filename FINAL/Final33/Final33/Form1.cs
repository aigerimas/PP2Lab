using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final33
{
	public partial class Form1 : Form
	{
		int x;
		int y;
		int kx = -1;
		int ky = -1;
		public Form1()
		{
			InitializeComponent();

		}
		private void Form1_Load(object sender, EventArgs e)
		{
			for (int i = 0; i < 3; i++) {
				for (int j = 0; j < 3; j++)
				{
					Button b = new Button();
					b.Click += but_click;
					b.Location = new Point(x, y);
					b.Size = new Size(50, 50);
					b.BackColor = Color.Gray;
					b.Name = (i * 3 + j).ToString();
					Controls.Add(b);
					x += 55;
				}
		}
	}

		private void but_click(object sender, EventArgs e)
		{
			Button b = sender as Button;
			kx = int.Parse(b.Name) / 10;
			ky = int.Parse(b.Name) % 10;
			foreach(Button s in Controls)
			{
				if (int.Parse(s.Name) / 2 == kx || int.Parse(s.Name) % 3 == ky)
				{
					s.BackColor = Color.Red;
				}
				else
				{
					s.BackColor = Color.Gray;

				}
				}

			}

		
	}



	
	}

