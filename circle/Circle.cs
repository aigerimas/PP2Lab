using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a33
{
	class Circle
	{
		public double Radius;
		public double Area;
		public double Diameter;
		public double Circumference;
		public const double pi = 3.14;

		public Circle()
		{
			Radius = 3;

		}



		public void findArea()
		{

			Area = pi * Radius * Radius;
		}
		public void findDiameter()
		{
			Diameter = 2 * Radius;
		}
		public void findCircumference()
		{

			Circumference = 2 * pi * Radius;
		}
		public override string ToString()
		{
			return Area + " " + Diameter + " " + Circumference;

		}



	}


}

	

