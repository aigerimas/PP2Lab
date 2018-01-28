using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a24
{
	class Student
	{
		public string  firstName;
        public string secondName;
		public int age;
		public float gpa;

		public Student()
		{
			firstName = "Dana";
			secondName = "Kurmash";
			age = 18;
			gpa = 4;

		}
		public first(string firstName)
		{
			this.firstName = "Aigerim";
		}


		public override string ToString()
		{
			return firstName + " "+ secondName + " " + age + " " + gpa;
		}
	
		static void Main(string[] args)
		{
			Student s = new Student();
			s.firstName = "Dos";

		
			Console.WriteLine(s);
			Console.ReadKey();


		}
		
	}
}
