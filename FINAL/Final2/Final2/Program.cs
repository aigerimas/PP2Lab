using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final2
{
	class Program
	{
		static void Main(string[] args)
		{
			FileStream fs = new FileStream(@"C:\Users\User\Desktop\prime.txt", FileMode.Open, FileAccess.Read);
			StreamReader sr = new StreamReader(fs);

			//string s = Console.ReadLine();
			string ss = sr.ReadToEnd();
			int bb = int.Parse(ss);
			for (int j = 2; j < Math.Sqrt(bb); j++) ;
			if ( bb % j  == 0)
			{
				cnt++;
			}
			if(cnt >=i){
				Console.WriteLine(a[i].FullName);
				sr.Close();
				fs.Close();
			}

			Console.ReadKey();
		}
	}
}
