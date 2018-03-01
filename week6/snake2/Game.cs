using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake2
{
	[Serializable]
	public class Game
	{
		public static Snake snake;
		public static Food food;
		public static Wall wall;
		public static bool GameOver;


		public static void SAVE()
		{
			snake.snakeSAVE();
			wall.wallSAVE();
			food.foodSAVE();

		}
		public static void RESUME()
		{
			snake.snakeRESUME();
			wall.wallRESUME();
			food.foodRESUME();
		}
		public static void Init()
		{
			GameOver = false;
			Console.CursorVisible = false;
			snake = new Snake();

			wall = new Wall();
			food = new Food();
		}
		public static void END()
		{
			Console.SetCursorPosition(57, 9);
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("GAME OVER");
			Console.SetCursorPosition(60, 11);
			Console.WriteLine("                ");
			Console.SetCursorPosition(60, 13);
			Console.ForegroundColor = ConsoleColor.Magenta;
			Console.WriteLine("                ");



		}

		public static void Process()
		{
			int a = food.score;
			int aa = wall.level;
			string ss = "LEVEL " + aa;
			string s = "YOUR SCORE: " + a;
			Console.SetCursorPosition(61, 3);
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine(ss);
			Console.SetCursorPosition(61, 5);
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine(s);
			Console.SetCursorPosition(61, 11);
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("R - resume game");
			Console.SetCursorPosition(61, 12);
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("N - new game");
			Console.SetCursorPosition(61, 13);
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("S - save game");
			Console.SetCursorPosition(61, 14);
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("Q - quit game");


		}

		public static void Draw()
		{
			//Console.Clear();
			snake.Draw();
			food.Draw();
			wall.Draw();
		}

	}
}
