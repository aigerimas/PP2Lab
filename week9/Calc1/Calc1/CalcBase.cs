using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc1
{
	 public class CalcBase
	{
		public double firstNumber = 0, secondNumber = 0, result = 0, memory = 0;
		public string operation = "";
		public bool znak = true;
		

		public void calculate()
		{
			switch (operation)
			{
				case "+":
					result = firstNumber + secondNumber;
					break;
				case "-":
					result = firstNumber - secondNumber;
					break;
				case "*":
					result = firstNumber * secondNumber;
					break;
				case "÷":
					result = firstNumber / secondNumber;
					break;
				case "xʸ":
					result = Math.Pow(firstNumber, secondNumber);
					break;
				case "x^1/y":
					result = Math.Pow(firstNumber, 1 / secondNumber);     
					break;
			}
		}
		public void oneNumber()
		{
			switch (operation)
			{
				case "√":
					firstNumber = Math.Sqrt(firstNumber);
					break;
                case "%":
					firstNumber = firstNumber / 100;
					break;
				case "log":
					firstNumber = Math.Log10(firstNumber);
					break;
				case "Mod":
					firstNumber = Math.Abs(firstNumber);
					break;
				case "x³":
					firstNumber= firstNumber * firstNumber * firstNumber;
					break;
				case "x ²":
					firstNumber = firstNumber * firstNumber;
					break;
				case "10 ˣ ":
					firstNumber = Math.Pow(10, firstNumber);
					break;
				case "sin":
					firstNumber = Math.Sin(firstNumber * Math.PI / 180);
					break;
				case "cos":
					firstNumber = Math.Cos(firstNumber * Math.PI / 180);
					break;
				case "tan":
					firstNumber = Math.Tan(firstNumber * Math.PI / 180);
					break;
				case "e ˣ ":
					firstNumber = firstNumber * firstNumber;
					break;
				case "!":
					if (!firstNumber.ToString().Contains(',') || !firstNumber.ToString().Contains('-'))
					{
						for (int i = (int)firstNumber - 1; i > 1; i--)
						{
							firstNumber *= i;
						}

					}
					result = firstNumber;
					break;
			}
		}
		
	}
}
