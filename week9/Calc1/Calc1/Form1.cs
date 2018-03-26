using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Calc1
{
	public partial class Form1 : Form
	{

		CalcBase calc = new CalcBase();
		TextBox display;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			display = new TextBox();
			display.Font = new Font(FontFamily.GenericMonospace, 25);
			display.Location = new Point(33, 5);
			display.Width = 290;
			display.TextAlign = HorizontalAlignment.Right;


			int cnt = 1;
			int dX = 93;
			int dY = 300;

			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					Button btn = new Button();
					btn.Text = cnt.ToString();
					btn.Size = new Size(50, 50);
					btn.Location = new Point(dX + j*60, dY + i*60);
					btn.Click += Numbers_Click;
					btn.BackColor = Color.Pink;
					btn.ForeColor = Color.Black;
					Controls.Add(btn);

					cnt++;
				}
			}

			Controls.Add(display);
		}

		private void Numbers_Click(object sender, EventArgs e)
		{
			Button btn = sender as Button;
			if (display.Text == "0" && btn.Text == "0")
				display.Text = "0";
			else
			{
				if (display.Text == "0" && btn.Text != ".")
				display.Text = "";
				display.Text += btn.Text;
			}
        }

		private void Operation_Click(object sender, EventArgs e)
		{
			Button btn = sender as Button;

			calc.firstNumber = double.Parse(display.Text);
			calc.operation = btn.Text;

			if (calc.operation == "+" || calc.operation == "-" || calc.operation == "*" || calc.operation == "÷" || calc.operation == "xʸ" || calc.operation == "x⅟ ʸ")
			{
				display.Text = "";
			}
			else
			{
				calc.oneNumber();
				display.Text = calc.firstNumber.ToString();
			}
		}

		private void result_Operation(object sender, EventArgs e)
		{
			if (calc.operation != "")
			{
				if (display.Text == "")
					calc.secondNumber = calc.firstNumber;
				else
				{
					if (display.Text != calc.result.ToString())
						calc.secondNumber = double.Parse(display.Text);
				}
				calc.calculate();
				display.Text = calc.result.ToString();
			calc.firstNumber = calc.result;
			}
		}
			
		
		private void Memory_click(object sender, EventArgs e)
		{
			Button btn = sender as Button;
			switch (btn.Text)
			{
				case "MS":
					calc.memory = double.Parse(display.Text);
					display.Text = calc.memory.ToString();
					break;
				case "MR":
					display.Text = calc.memory.ToString();
					break;
				case "MC":
					calc.memory = 0;
					display.Text = calc.memory.ToString();
					break;
				case "M+":
					calc.memory += double.Parse(display.Text);
					display.Text = calc.memory.ToString();
					break;
				case "M-":
					calc.memory -= double.Parse(display.Text);
					display.Text = calc.memory.ToString();
					break;
			}
		}
		private void znak_change(object sender, EventArgs e)
		{
            if(calc.znak == true)
			{
				display.Text = "-" + display.Text;
				calc.znak = false;
			}
			else if (calc.znak == false)
			{
				display.Text = display.Text.Replace("-", "");
				calc.znak = true;
			}
		}
		private void dot_Click(object sender,EventArgs e)
		{
			Button btn = sender as Button;
			if (display.Text.Contains('.') && btn.Text == ".")
			{

			}
			else
				display.Text += btn.Text;
		}

		private void Clear_Click(object sender, EventArgs e)
		{
			Button btn = sender as Button;
			switch (btn.Text)
			{
				case "←":

					if (display.Text.Length != 1)
						display.Text = display.Text.Remove(display.Text.Length - 1, 1);
					else display.Text = "0";

					break;
				case "C":
					display.Text = "0";
					calc.operation = "";
					break;
			}
		}
	}
}
