using System;


namespace a13
{
	class Circle
	{
		public double Radius;
		public void Rad()
		{
			Console.WriteLine("Enter Radius:");
			Radius = Convert.ToDouble(Console.ReadLine());
		}
		public void Area()
		{
			const double pi = 3.14;
			double area = pi * Radius * Radius;
			Console.WriteLine("Radius:{0},Area{1}", Radius, area);

			
		}
		public void Diameter()
		{
			double diameter = 2 * Radius;
			Console.WriteLine("Diameter:{0}", diameter);
			

		}
		public void Circumference()
		{
			const double pi = 3.14;
			double circumference = 2 * pi * Radius;
			Console.WriteLine("circumference{0}", circumference);
			

		}
	}
	class MainClass
	{
		public static void Main(string[] args)
		{
			Circle x = new Circle();
			x.Rad();
			x.Area();
			x.Diameter();
			x.Circumference();
			
			Console.ReadKey();
		}
	}
}
