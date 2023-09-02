using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_6
{
    public class InstantiatedClass
    {
        public string firstName;
        public string lastName;
    }
    // Class for the course Lab
    public class ClassCourse
    {
        //modify-able variables within the class "public"
        public string lTitle;
        public int lCreditHours;
        public string lProgram;
        public string lInstructor;
        //Allowing new instances of the class to be created
        public ClassCourse(string lTitle, int lCreditHours, string lProgram, string lInstructor)
        {
            this.lTitle = lTitle;
            this.lCreditHours = lCreditHours;
            this.lProgram = lProgram;
            this.lInstructor = lInstructor;
        }
        //A method that capitalizes a string placed inside the parameters
        public string GetTitle()
        {
            return lTitle.ToUpper();
        }
    }
    //ENCAPSULATION
    public class privateEncapsulation
    {
        //creating variables that are private and cannot be accessed outside of this class
        private string _title;
        private int _creditHours;
        private string _program;
        private string _instructor;
        //Setting the new values that CAN be seen outside the class. PRIVATE / GET / SET are synonomous
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }
        //Setting the new INTERGER values of this class between 3 or 6 because thats how college credits work
        public int CreditHours
        {
            get { return this._creditHours; }
            set
            {
                if (value >= 3 || value <= 6)
                {
                    this._creditHours = value;
                }
            }
        }
        public string Program
        {
            get { return this._program; }
            set { this._program = value; }
        }
        public string Instructor
        {
            get { return this._instructor; }
            set { this._instructor = value; }
        }

    }
}

