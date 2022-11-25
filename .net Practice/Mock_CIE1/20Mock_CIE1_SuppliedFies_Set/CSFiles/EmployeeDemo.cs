using System;

namespace MockTest
{
	class Employee
	{
		private int id;
		private string name, email, country;

		public void setData()
		{
			Console.Write("Enter ID: ");
			this.id = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter Name: ");
			this.name = Console.ReadLine();
			Console.Write("Enter Email: ");
			this.email = Console.ReadLine();
			Console.Write("Enter Country: ");
			this.country = Console.ReadLine();
		}
		public void display()
		{
			Console.WriteLine("ID: {0}", this.id);
			Console.WriteLine("Name: {0}", this.name);
			Console.WriteLine("Email: {0}", this.email);
			Console.WriteLine("Country: {0}", this.country);
		}
		
	}
	class EmployeeDemo
	{
		public static void Main(string[] args)
		{
			Employee e = new Employee();
			e.setData();
			e.display();
			
				
		}
		
	}
}
		