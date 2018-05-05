using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pow
{
	class Program
	{
		static void Main(string[] args)
		{

			string s = Console.ReadLine();
			int n = int.Parse(s);
			int k = 1;
			for (int i = 0; i < n; i++)
			{
				k *= 2;
            }
			Console.WriteLine(k);
            Console.ReadKey();
			/*string n = Console.ReadLine();
			int x = int.Parse(n);
			Console.WriteLine(Math.Pow(2, x));
			Console.ReadKey();*/
		}
	}
}
