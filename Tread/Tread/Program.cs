﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tread
{
	class Program
	{
		public static void Traffic()
		{
			FileStream fs = new FileStream(@"C:\Users\User\Desktop\traffic.txt", FileMode.Open, FileAccess.Read);
			StreamReader sr = new StreamReader(fs);
			string s = sr.ReadToEnd();
			while (true)
			{
				for(int i =0; i < 3; i++)
				{
					if (i == 0)
					{
						Console.Clear();
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine(s);
						Console.ForegroundColor = ConsoleColor.Black;
						Console.WriteLine(s);
						Console.ForegroundColor = ConsoleColor.Black;
						Console.WriteLine(s);

						Thread.Sleep(1000);
					}
					if (i == 1)
					{
						Console.Clear();
						Console.ForegroundColor = ConsoleColor.Black;
						Console.WriteLine(s);
						Console.ForegroundColor = ConsoleColor.Yellow;
						Console.WriteLine(s);
						Console.ForegroundColor = ConsoleColor.Black;
						Console.WriteLine(s);

						Thread.Sleep(1000);

					}
					if (i == 2)
					{
						Console.ForegroundColor = ConsoleColor.Black;
						Console.WriteLine(s);
						Console.ForegroundColor = ConsoleColor.Black;
						Console.WriteLine(s);
						Console.ForegroundColor = ConsoleColor.Green;
						Console.WriteLine(s);

						Thread.Sleep(1000);

					}
				}
				Console.Clear();
			}
		}

		static void Main(string[] args)
		{
			Console.CursorVisible = false;
			Thread t = new Thread(Traffic);

			t.Start();
			Console.ReadKey();
		}
		
	}
}
