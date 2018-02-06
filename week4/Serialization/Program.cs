using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
	class Program
	{
		static void f1()
		{
			FileStream fs = new FileStream(@"data.ser", FileMode.Create, FileAccess.Write);
			Complex c1 = new Complex(1,4);
			
			BinaryFormatter bf = new BinaryFormatter();
			try
			{
				bf.Serialize(fs, c1);
				
			}
			catch(Exception e)
			{
				Console.WriteLine(e.Message);
			}
			finally
			{
				fs.Close();

			}
			Console.WriteLine("done");
		}
		static void f2()
		{
			FileStream fs = new FileStream(@"data.ser", FileMode.Open, FileAccess.Read);
			BinaryFormatter bf = new BinaryFormatter();

			try
			{
				Complex c = bf.Deserialize(fs) as Complex;
				Console.WriteLine(c);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			finally
			{
				fs.Close();
			}
		}
		static void Main(string[] args)
		{
			f1();
			f2();
			Console.ReadKey();
		}
	}
}
