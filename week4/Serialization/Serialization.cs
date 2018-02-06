using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
	[Serializable]
	class Complex
	{
		public int a;
		public int b;
		public int GCD(int x, int y)
		{
			while (x != y)
			{
				if (x > y)
				{
					x = x - y;

				}
				else
				{
					y = y - x;
				}
			}
			return x;
		}
		public Complex()
		{

		}
		public Complex(int ax,int bx)
		{
			a = ax;
			b = bx;
		}
		public void Simp()
		{
			int z = GCD(this.a, this.b);
			this.a = this.a / z;
			this.b = this.b / z;
		}
		public static Complex operator +(Complex c1,Complex c2)
		{
			Complex m = new Complex();
			m.a = c1.a * c2.b + c2.a * c1.b;
			m.b = c1.b * c2.b;
			m.Simp();
			return m;

		}
		public override string ToString()
		{
			return a + "/" + b;
			
		}
	}
}
