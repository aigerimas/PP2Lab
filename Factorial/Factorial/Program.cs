using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
	class Program
	{
		public int arr(int num)
		{
			int result;

			if (num == 1)
			{
				return 1;
			}
			else {
				result = arr(num - 1) * num;
				return result;
			}
		
		}
		
		
		static void Main(string[] args)
		{
			/*string s = Console.ReadLine();
			int n = int.Parse(s);
			int result;
			if (n == 1)
			{
				return 1;
			}
			else
			{
				result = 
			}*/

			//Console.WriteLine(result);
			
		}
		
	}
	
}
