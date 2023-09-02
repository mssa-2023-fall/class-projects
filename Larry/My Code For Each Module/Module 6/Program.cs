using Module_6;
using Structs;
using System;
using System.Runtime.CompilerServices;

namespace ClassesAndStructs
{
    class Program
    {
        static void Main(string[] args)
        {

            //Calling an INSTANCE of a CLASS
            InstantiatedClass myInformation = new InstantiatedClass();
            myInformation.firstName = "Larry";

            // Calling a STATIC CLASS
            Console.WriteLine("Calling a STATIC Class: ");
            Console.WriteLine(StaticClass.StaticStuff("Location: Located in Static Class Module 6 ", "| Type: Type is a Static Class"));
            Console.ReadLine();

            // Calling a STRUCT
            Box amazonPackage = new Box();
            amazonPackage.height = 20.00F;
            amazonPackage.width = 40.00F;
            amazonPackage.companyName = "Amazon";

            // Simplifying the STRUCT variables
            var packageHeight = amazonPackage.height;
            var packageWidth = amazonPackage.width;
            var packageName = amazonPackage.companyName;

            // STRUCT LAB
            Course cs101 = new Course("cs101", 6, "Computer Science", "Mr. Smith");
            Course cs102 = new Course();
            cs102.title = "cs102";
            cs102.creditHours = 6;
            cs102.program = "Computer Science";
            cs102.instructor = "Mrs. Jones";

            // Instantiating a Encapsulated(PRIVATE) class 
            privateEncapsulation encap = new privateEncapsulation();
            var encapTitle = encap.Title = "CS103";
            var encapCredit = encap.CreditHours = 5;
            var encapProgram = encap.Program = "Computer Networks";
            var encapInstructor = encap.Instructor = "Mrs. Gomez";

            //Console Output (Featuring STRUCTS, ENCAPSULATION)
            Console.WriteLine("Calling an ENCAPSULATION Class: ");
            Console.WriteLine(encapTitle);
            Console.WriteLine(encapProgram);
            Console.WriteLine(encapInstructor);
            Console.WriteLine(encapCredit);
            Console.WriteLine();
            Console.WriteLine("Calling a simple INSTANTIATED Class: ");
            Console.WriteLine($"firstName: First name in this instantiated class is {myInformation.firstName}");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Calling a STRUCT: ");
            Console.WriteLine("{0}, {1}, {2}, {3}", cs101.title, cs101.creditHours, cs101.program, cs101.instructor);
            Console.WriteLine("{0}, {1}, {2}, {3}", cs102.title, cs102.creditHours, cs102.program, cs102.instructor);
            Console.WriteLine();
            Console.WriteLine("Calling a ToUpper method: ");
            Console.WriteLine(cs101.GetTitle());
            Console.WriteLine(cs102.GetTitle());
            Console.WriteLine();
            Console.WriteLine("More STRUCTS");
            Console.WriteLine($"The Amazon box is {packageHeight} feet tall and {packageWidth} feet wide.");
            Console.ReadLine();

        }
    }
}   
        
        
        
        
        
        
        
        
        
        
        
        
        


//Structs
/*
Names People = new Names();
            People.firstName = "Larry";
            People.middleName = "Sinoe";
            People.lastName = "Neris";
            People.suffix = "Mr";

            Console.WriteLine($"{People.firstName} , {People.lastName} , {People.middleName} , {People.suffix} ");
            Console.ReadLine();

        }
        public struct Names
        {
            public string firstName, middleName, lastName, suffix;
        }

*/