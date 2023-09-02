using System;
using System.Buffers;
using System.Dynamic;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;
/* 
Create a new struct for restaurant positions (at least 5 positions)

Add in titles and approx wages

Add in various meal combo names and what is contained in the meal combo (at least 4 different meal combos...your choice)

Maybe include after dinner offerings..coffee, deserts (maybe 2-4 different types)

for extra fun...your choice

a performance/satisfaction scale?

string combo1 = "burger, fries, and your choice of drink.";
string combo2 = "burrito, chips and your choice of drink.";
string combo3 = "chicken caesar salad, with more veggies and your choice of drink.";
*/


namespace Restaurant
{
	
	public class People
	{
		private string owner {get; set;}
		private string manager {get; set;}
		private string chef {get; set;}
		private string register {get; set;}
		private string waiter {get; set;}

		private double owage {get; set;}
		private double mwage {get; set;}
		private double cwage {get; set;}
		private double rwage {get; set;}
		private double wwage {get; set;}

		//I want to create a method that returns the position + its wage

		public string oEmployee = "Owner";
		public string mEmployee = "Manager";
		public string cEmployee = "Chef";
		public string rEmployee = "Register";
		public string wEmployee = "Waiter";
		public class Employee : People
		{
			public string oEmployee { get {return this.owner;} set {this.owner = value;} }
			public string mEmployee { get {return this.manager;} set {this.manager = value;} }
			public string cEmployee { get {return this.chef;} set {this.chef = value;} }
			public string rEmployee { get {return this.register;} set {this.register = value;} }
			public string wEmployee { get {return this.waiter;} set {this.waiter = value;} }

			
		}
		public class Wages : People
		{
		public double oWage {get {return this.owage; } set {this.owage = value;} }
		public double mWage {get {return this.mwage; } set {this.mwage = value;} }
		public double cWage {get {return this.cwage;} set {this.cwage = value;} }
		public double rWage {get {return this.rwage;} set {this.rwage = value;} }
		public double wWage { get {return this.wwage;} set {this.wwage = value;} }
		

		}
	}
	
	public class Negotiating : People
	{
		Wages.Wages wage1 = new Wages.Wages();
		Employee OEmployee = new Employee();


		public void OwnerWage()
			{
				double wage1 = 120.42;
				string oEmployee = "Owner";
				Console.WriteLine($"{wage1} is how much the {oEmployee} earns per hour");
			}
		public void ManagerWage()
			{
				double wage1 = 80.23;
				string oEmployee = "Manager";
				Console.WriteLine($"{wage1} is how much the {oEmployee} earns per hour");
			}
		public void ChefWage()
			{
				double wage1 = 70.45;
				string oEmployee = "Chef";
				Console.WriteLine($"{wage1} is how much the {oEmployee} earns per hour");
			}
			public void RegisterWage()
			{
				double wage1 = 50.14;
				string oEmployee = "Register";
				Console.WriteLine($"{wage1} is how much the {oEmployee} earns per hour");
			}
			public void WaiterWage()
			{
				double wage1 = 30.25;
				string oEmployee = "Waiter";
				Console.WriteLine($"{wage1} is how much the {oEmployee} earns per hour");
			}
	}
	
    public class Combos
	{
		public void combo1()
		{
			Console.WriteLine("burger, fries, and your choice of drink.");
			return;
		}
		public void combo2()
		{
			Console.WriteLine("burrito, chips and your choice of drink.");
			return;
		}
		public void combo3()
		{
			Console.WriteLine("chicken caesar salad, with more veggies and your choice of drink.");
			return;
		}

	}
	
}





