using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a34
{
	class Rectangle
	{
		public   int width;
		public int height;
		public int area;
		public int perimeter;
		
		public Rectangle()
		{
			width = 5;
			height = 4;
		}
		public Rectangle( int width, int height)
		{
			this.width = width;
			this.height = height;
		}
		public void findarea()
		{
			area = width * height;
		}
		public void findperimeter()
		{
			perimeter = (width + height) * 2;
		}
		public override string ToString()
		{
			return area + " " + perimeter;
		}

	}
	
	
	
}
