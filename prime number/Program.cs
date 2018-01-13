using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a23
{
	class Program
	{
		static void Main(string[] args)
		{
			string line = Console.ReadLine();
			string[] arr = line.Split(' ');// Разделяем строки
			int z = arr.Length;// z это количество элементов
			for(int i=0; i<z; ++i)// for пробегается по всем элементам
			{
				int q = int.Parse(arr[i]);// Переводим из string в int
				if (Isprime(q))// Проверяем простое ли число
				{
					Console.WriteLine(q);
				}
			}

			Console.ReadKey();
			
		}
		static bool Isprime(int b)
		{
			for(int n = 2; n<= Math.Sqrt(b); n++) //Функция на проверку простого числа
			{
				if (b % n == 0)
				{
					return false;
				}
			}
			return true;

		}
	}
}
