using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake1
{
	class Wall
	{
		public List<Point> body;
		public char sign;
		public ConsoleColor Color;
		public int level;
	

		public int Level { get; internal set; }

		public Wall()
		{
			Color = ConsoleColor.Red;
			sign = '#';
			body = new List<Point>();
			LoadLevel();


		}
		public void LoadLevel()
		{
			body.Clear();

			string filePath = string.Format(@"C:\Users\User\Desktop\level.txt");
			FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
			StreamReader sr = new StreamReader(fs);

			string line = "";
			int i = 0;
			int row = 0;
			while (i < 20)
			{
				line = sr.ReadLine();
				for (int col = 0; col < line.Length; col++)
				{
					if (line[col] == '#')
					{
						body.Add(new Point(col, row));
					}
				}
				
				i++;
				row++;
			}
			fs.Close();
		}

		

		public void Draw()
		{
			Console.ForegroundColor =Color;
			foreach (Point p in body)
			{
				Console.SetCursorPosition(p.x, p.y);
				Console.Write(sign);


			}
		}
	}
}