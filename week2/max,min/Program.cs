using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a39
{
	class Program
	{
		  static void Main(string[] args)
		{
			FileStream fs = new FileStream(@"C:\Users\User\Desktop\input.txt", FileMode.Open, FileAccess.Read);
			StreamReader sr = new StreamReader(fs);

			string s = sr.ReadLine();
			
			string[] arr = s.Split(' '); 
			int maxi = int.Parse(arr[0]); 
			int mini = int.Parse(arr[0]); 
			for (int i = 1; i <arr.Length; i++)
			{

				if (int.Parse(arr[i]) > maxi)
				{
					maxi = int.Parse(arr[i]);
				}
				if (int.Parse(arr[i]) < mini)
					mini = int.Parse(arr[i]);
			}
			sr.Close();
			fs.Close();
			Console.WriteLine(maxi);
			Console.WriteLine(mini);
				Console.ReadKey();
			        

			}
		}
	}

