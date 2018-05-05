using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fit
{
	class Program
	{
		static void Main(string[] args)
		{
			DirectoryInfo dir = new DirectoryInfo(@"");
			FileInfo[] f = dir.GetFiles();
			foreach(FileInfo a in f)
			{
				StreamReader sr = new StreamReader(a.FullName);
				string s = sr.ReadToEnd();
				for(int i = 0; i < s.Length; i++)
				{
					if (s[i] == 'K' && s[i + 1] == 'B' && s[i + 2] == 'T' && s[i + 3] == 'U')
					{
						Console.WriteLine(a.Name);
					}
				}
			}
			/*DirectoryInfo dir = new DirectoryInfo(@"C:\Users\User\Desktop\mid");
			FileInfo[] f = dir.GetFiles();
			foreach(FileInfo a in f)
			{
				StreamReader sr = new StreamReader(a.FullName);
				string s = sr.ReadToEnd();
				for(int i=0; i<s.Length; i++)
				{
					if(s[i]=='K'&&s[i+1]=='B'&& s[i+2]=='T'&& s[i + 3] == 'U')
					{
						Console.WriteLine(a.Name);
					}
				}
			}*/
			Console.ReadKey();
		}
	}
}
