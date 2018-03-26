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
		List<Label> stones = new List<Label>();
		bool game = true;

		private void button1_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.A:
					button1.Location = new Point(button1.Location.X - 20, button1.Location.Y);
					break;
				case Keys.D:
					button1.Location = new Point(button1.Location.X + 20, button1.Location.Y);
					break;
			}
		}

		private void button1_KeyPress(object sender, KeyPressEventArgs e)
	    {

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			label1.Text = "Score: " + score;
			for (int i = 0; i < stones.Count; i++)
			{
				stones[i].Location = new Point(stones[i].Location.X, stones[i].Location.Y + 10);
				if (stones[i].Location.Y > Height)
				{
					stones[i].Location = new Point(random.Next(1, 380), 0);
					score++;
				}
				if ((stones[i].Location.X >= button1.Location.X && stones[i].Location.X <= button1.Location.X + button1.Width) && stones[i].Location.Y > button1.Location.Y)
				{
					timer1.Stop();
					stones.Clear();
					MessageBox.Show("GAME OVER");
				}


			}
			if (game)
			{
				Label s = new Label();
				s.Size = new Size(20, 20);
				s.Text = "O";
				int r = new Random().Next(0, Width);
				s.Location = new Point(r, 0);
				stones.Add(s);
				Controls.Add(s);
			}
			
		}
	}
}
