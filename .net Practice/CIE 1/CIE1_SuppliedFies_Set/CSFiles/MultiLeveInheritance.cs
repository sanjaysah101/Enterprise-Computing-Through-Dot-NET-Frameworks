using System;

namespace MockTest
{
	class Student
	{
		public int Roll_No { get; set; }
		public string Name { get; set; }
	}

	class Test : Student
	{
		
		public int Mark_1 { get; set; }
		public int Mark_2 { get; set; }
	}
	class Result : Test
	{
		public int Total()
		{
			return base.Mark_1 + base.Mark_2;
		}
	}

	class Demo
	{
		public static void Main(string[] args)
		{
			Result student = new Result();
			student.Name = "Sanjay";
			student.Roll_No = 41;
			student.Mark_1 = 90;
			student.Mark_2 = 80;

			Console.WriteLine(student.Total());

		}
	}
}
		