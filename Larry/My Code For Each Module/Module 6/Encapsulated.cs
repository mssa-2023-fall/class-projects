using System;
using ClassesAndStructs;

namespace Module_6
{
	public class Person
	{
		private DateTime birthDateAndTime;
		private string givenName;
		private string familyName;

		public Person()
		{
			this.birthDateAndTime = DateTime.Now;
		}
		//Turning PRIVATE variables to PUBLIC variables with get{;} and set{;}
		public DateTime BirthDateAndTime
		{
			get { return this.BirthDateAndTime; }
			set { this.BirthDateAndTime = value; }
		}
		//Turning PRIVATE variables to PUBLIC variables with get{;} and set{;}
		public string GivenName
		{
			get { return this.GivenName; }
			set { this.givenName = value; }
		}
		//Turning PRIVATE variables to PUBLIC variables with get{;} and set{;}
		public string FamilyName
		{
			get { return this.familyName; }
			set { this.familyName = value; }
		}
		//Creating a method that allows the Main to assign its own values to givenName and familyName
		public void SetNames(string givenName, string familyName)
		{
			this.givenName = givenName;
			this.familyName = familyName;
		}
		//Creating an Event
		public event EventHandler OnWake;
		public event EventHandler OnSleep;
		//Creating Event Methods for the Main method
		public void Wake()
		{
			OnWake?.Invoke(this, EventArgs.Empty);
		}
		public void Sleep()
		{
			OnSleep?.Invoke(this, EventArgs.Empty);
		}


	}
}
