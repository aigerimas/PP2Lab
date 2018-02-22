using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake1
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.CursorVisible = false;
			bool g = true;

			Snake snake = new Snake();
			Food food = new Food();
			Wall wall = new Wall();
			food.SetRandomPosition();
			while (g)
			{
				wall.LoadLevel();
				//Отображение текущего уровня и счета
				//food.Process(wall);
				snake.Draw();
				wall.Draw();
				food.Draw();
				ConsoleKeyInfo btn = Console.ReadKey();
				switch (btn.Key)
				{
					case ConsoleKey.UpArrow:
						snake.Move(0, -1);
						break;
					case ConsoleKey.DownArrow:
						snake.Move(0, 1);
						break;
					case ConsoleKey.LeftArrow:
						snake.Move(-1, 0);
						break;
					case ConsoleKey.RightArrow:
						snake.Move(1, 0);
						break;
					case ConsoleKey.Q:
						g = false;
						Console.Clear();
						break;
					case ConsoleKey.Enter:
						wall.level = 1;
						snake.body.Clear();
						
						snake = new Snake();

						Console.Clear();
						break;

				}


				snake.CanEat(food);
				if (snake.GameOver(wall))
				{
					g = false;
					Console.Clear();
					Console.WriteLine("GAMEOVER");
					Console.ReadKey();
				}

			}
		}
	}
}
