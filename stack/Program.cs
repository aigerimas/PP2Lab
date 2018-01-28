using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a48
{
	class Program
	{
		static void Far(string path)
		{
			Stack<DirectoryInfo> s = new Stack<DirectoryInfo>();
			DirectoryInfo dir = new DirectoryInfo(path);
			s.Push(dir);
			foreach(FileInfo file in dir.GetFiles())
			{
				Console.WriteLine(file.Name);
			}
			while (s.Count > 0)
			{
				DirectoryInfo dirs = s.Pop();
				foreach(DirectoryInfo f in dirs.GetDirectories())
				{
					Console.WriteLine(" ");
					Console.WriteLine(f.Name);
					s.Push(f);

					foreach (FileInfo z in f.GetFiles())
					{
						Console.WriteLine(" ");
						Console.WriteLine(z.Name);
					}
				}
			}
		}
		static void Main(string[] args)
		{
			Far(@"C:\Users\User\Desktop\PP2Lab\week2\complex\bin");
			Console.ReadKey();
		}
	}
}
