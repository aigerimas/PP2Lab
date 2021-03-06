﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Far
{
	class Program
	{


		static void showState(DirectoryInfo cur, int pos)
		{
			FileSystemInfo[] infos = cur.GetFileSystemInfos();
			for (int i = 0; i < infos.Length; i++)
			{
				if (pos == i)
					Console.BackgroundColor = ConsoleColor.White;
				else
					Console.BackgroundColor = ConsoleColor.Black;
				Console.WriteLine(infos[i].Name);




			}
			
		}
		static void Main(string[] args)
		{
			Console.CursorVisible = false;
			int pos = 0;
			DirectoryInfo dir = new DirectoryInfo(@"C:\Users\User\Desktop\PP2Lab\circle");

			while (true)
			{
				Console.Clear();
				showState(dir, pos);
					ConsoleKeyInfo btn = Console.ReadKey();
				switch (btn.Key)
				{
					case ConsoleKey.UpArrow:
						pos--;
						if(pos<0)
							pos = dir.GetFileSystemInfos().Length -1;
						break;
					case ConsoleKey.DownArrow:
						pos++;
						if (pos >= dir.GetFileSystemInfos().Length)
							pos = 0;
						break;
						
					case ConsoleKey.Enter:
						FileSystemInfo f = dir.GetFileSystemInfos()[pos];
						if (f.GetType() == typeof(DirectoryInfo))
						{
							dir = new DirectoryInfo(f.FullName);
							pos = 0;
						}
						if (f.GetType() == typeof(FileInfo))
						{
							StreamReader sr = new StreamReader(dir.GetFileSystemInfos()[pos].FullName);
							string s = sr.ReadToEnd();
							Console.Clear();
							Console.BackgroundColor = ConsoleColor.Black;
							Console.ForegroundColor = ConsoleColor.White;
							Console.WriteLine(s);
							Console.ReadKey();
							sr.Close();
							
						}
						break;

					case ConsoleKey.Escape:
						FileSystemInfo ff = dir.GetFileSystemInfos()[pos];
						if (ff.GetType() == typeof(DirectoryInfo))
						{
							dir = dir.Parent;

						}
						if (ff.GetType() == typeof(FileInfo))
						{
							dir = new DirectoryInfo(Path.GetDirectoryName(ff.FullName));
							dir = dir.Parent;
							pos = 0;
						}
						break;

				}
			}
		
		}
	}
}
