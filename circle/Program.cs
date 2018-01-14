using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a33
{
	class Program
	{
		static void Main(string[] args)
		{
			Circle x = new Circle();


			x.findArea();
			x.findDiameter();
			x.findCircumference();
			Console.WriteLine(x);
			Console.ReadKey();
		}
	}
}
