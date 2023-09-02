using System;

namespace Module_7
{
    //BASE CLASS with ENCAPSULATION (get; set;)
    public class StableIsotope
    {
        private string? name;
        private int protons;
        private int neutrons;
        private int electrons;

        public string Name { get { return this.name; } set { this.name = value; } }
        public int Protons { get { return this.protons; } set { this.protons = value; } }
        public int Neutrons { get { return this.neutrons; } set { this.neutrons = value; } }
        public int Electrons { get { return this.electrons; } set { this.electrons = value; } }

        public string Report()
        {
           return this.name + " is an isotope that has protons x" + this.protons + ", this neutrons x" + this.neutrons + " and electrons x" + this.electrons + ".";
        }
    }
}