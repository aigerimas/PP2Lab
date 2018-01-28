using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a41
{
	class Program
	{
		static public bool IsPrime(int x)
		{

			for( int i= 2; i <=Math.Sqrt(x); i++)
			{
				if (x % i == 0)
					return false;
			}
			return true;
		}
		static void Main(string[] args)
		{
			FileStream fs = new FileStream(@"C:\Users\User\Desktop\input1.txt", FileMode.Open, FileAccess.Read);
			StreamReader sr = new StreamReader(fs);


			int mini=-1, p = -1,  w = -1;
		
			string s = sr.ReadLine();
			string[] numbers = s.Split(' ');

			



			for (int i = 0; i < numbers.Length; i++)
			{
				
				if (IsPrime(int.Parse(numbers[i])) == true)
				{
					mini = int.Parse(numbers[i]);
					p = i;
					break;


				}
				
			}
			fs.Close();
			sr.Close();
			if (p != -1)
			{
				for(int i=p; i<numbers.Length; i++)
				{
					if (IsPrime(int.Parse(numbers[i])) == true && mini > int.Parse(numbers[i]))
					{
						mini = int.Parse(numbers[i]);
						w = i;
					}
				}
				
			}
			FileStream sf = new FileStream(@"C:\Users\User\Desktop\output.txt", FileMode.Open, FileAccess.Write);
			StreamWriter ws = new StreamWriter(sf);

			ws.WriteLine(numbers[w]);
			ws.Close();
			sf.Close();

			Console.ReadKey();


		}
		

		

			
			
		}
	}

