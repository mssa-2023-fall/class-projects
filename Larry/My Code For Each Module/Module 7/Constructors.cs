using System;
using System.Security.Cryptography.X509Certificates;


namespace Module_7
{/*
    public class videoGames
    {
        public string gameName;
              public videoGames(string gameName)
              {
              }
        
    }
    public class Books
    {
        public string name;
        public Books()
        {

        }

    } 
    */
    //PLURALSIGHT CLASS
    public class Employee
    {
        public string name;
        public int age;
        public int numberOfHoursWorked = 0;

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"Employee name: {name} - Age: {age} - Number of hours worked: {numberOfHoursWorked};");
        }

        public void Work(int hours, bool resetHours)
        {
            if (resetHours)
                numberOfHoursWorked = 0;

            numberOfHoursWorked += hours;
        }
        public Employee(string employeeName, int employeeAge, int hours)
        {

        }

    }
}

