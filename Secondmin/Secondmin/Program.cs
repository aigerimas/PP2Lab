using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secondmin
{
	class Program
	{
		static void Main(string[] args)
		{
			FileStream fs = new FileStream(@"C:\Users\User\Desktop\min num.txt", FileMode.Open, FileAccess.Read);
			StreamReader sr = new StreamReader(fs);
			string s = Console.ReadLine();
			string[] ss = s.Split(' ');
			List<int> k = new List<int>();
			for (int i = 0; i < ss.Length; i++)
			{
				k.Add(int.Parse(ss[i]));
			}
			int mini1 = k[0];
			for (int i = 0; i < k.Count; i++)
			{
				if (k[i] <= mini1)
				{
					mini1 = k[i];
				}
			}
			Console.WriteLine(mini1);
			int mini2 = k[0];
			for(int i =0; i < k.Count; i++)
			{
				if (k[i] == mini1)
					continue;
				if (k[i] < mini2)
				{
					mini2 = k[i];
				}

			}
			Console.WriteLine(mini2);
			Console.ReadKey();

		}
	}
}
