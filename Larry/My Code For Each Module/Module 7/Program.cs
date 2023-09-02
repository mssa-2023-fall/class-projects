using System;
using System.Security.Cryptography.X509Certificates;
using Module_7;

namespace Module7
{
    class Program
    {
        static void Main(string[] args)
        {
            //POLYMORPHISM
            int atomicMass;

            StableIsotope sodium = new StableIsotope();
            sodium.Protons = 11;
            sodium.Neutrons = 12;
            sodium.Electrons = sodium.Protons;
            atomicMass = sodium.Protons + sodium.Neutrons;

            sodium.Name = "Sodium" + atomicMass;

            RadioactiveIsotope tritium = new RadioactiveIsotope();
            tritium.Protons = 1;
            tritium.Neutrons = 2;
            tritium.Electrons = 1;
            atomicMass = tritium.Protons + tritium.Neutrons;
            tritium.Name = "Hydrogen " + atomicMass;

            AlphaDecayIsotope uranium = new AlphaDecayIsotope();
            uranium.Protons = 92;
            uranium.Neutrons = 146;
            uranium.Electrons = 92;
            uranium.Name = "Uranium 238";

            BetaDecayIsotope carbon = new BetaDecayIsotope();
            carbon.Protons = 6;
            carbon.Neutrons = 8;
            carbon.Electrons = 6;
            carbon.Name = "Carbon14";

            GammaDecayIsotope potassium = new GammaDecayIsotope();
            potassium.Protons = 19;
            potassium.Neutrons = 21;
            potassium.Electrons = 19;
            potassium.Name = "Potassium40";


            /* //ABSTRACT CLASS being INSTANTIATED through a DERIVED class
            
            var MacDill = new DevClass();
            //Class with a constructor that has a string parameter

            videoGames gameInformation = new videoGames("");
            gameInformation.gameName = "Fallout";

            //Do classes NEED constructors? Class with no constructor

            Books jk_Rowling = new Books();
            jk_Rowling.name = "Harry Potter";
            string myFavoriteBook = jk_Rowling.name;
            */


            //PluralSight CONSTRUCTOR

            // Employee employee1 = new Employee("Gill",42,10);
            //  employee1.name = "Gill";
            //employee1.employeeName = "Gill";
            //employee1.employeeAge = 42;
            //employee1.hours = 10;

            //PLURALSIGHT OUTPUT
            //  Console.WriteLine(employee1.name);
            //   Console.WriteLine("Above is the name");
            //  Console.ReadLine();

            //PERSONAL PROJECT OUTPUT
            //  Console.WriteLine(myFavoriteBook);


            //PERCIPIO OUTPUT
            Console.WriteLine("Output for values of the sodium INSTANCE and it's MEMBERS: ");
            Console.WriteLine();
            Console.WriteLine("{0},{1},{2}", sodium.Protons ,sodium.Neutrons, sodium.Electrons);
            Console.WriteLine(sodium.Report());
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Invoking the Report method of the tritium INSTANCE-------");
            Console.WriteLine();
            Console.WriteLine(tritium.Report());
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Invoking the Decay method of the tritium INSTANCE---------");
            Console.WriteLine();
            Console.WriteLine(tritium.Decay());
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("ALPHA BETA GAMMA ------------");
            Console.WriteLine(uranium.Report());
            Console.WriteLine(uranium.Decay());
            Console.WriteLine("-------------");
            Console.WriteLine(carbon.Report());
            Console.WriteLine("--------------");
            Console.WriteLine(carbon.Decay());
            Console.WriteLine("------------");
            Console.WriteLine();
            Console.WriteLine(potassium.Report());
            Console.WriteLine(potassium.Decay());
            Console.WriteLine("-----------------------------");
            Console.ReadLine();
        }
    }
}