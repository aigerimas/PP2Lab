using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a37
{
	class Program
	{
		

		static void Main(string[] args)
		{
			Complex c1 = new Complex(1, 4);
			Complex c2 = new Complex(1, 2);
			Complex result = c1 + c2;
			
			
			Console.WriteLine(result);
			Console.ReadKey();
		}
	}
}
