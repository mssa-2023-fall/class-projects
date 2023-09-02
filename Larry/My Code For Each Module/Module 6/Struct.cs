using System;


namespace Structs
{
    public struct Box
    { 
    public string companyName;
    public float height;
    public float width;
    public float dimensions;
    }
    public struct Course
    {
        public string title;
        public int creditHours;
        public string program;
        public string instructor;

        public Course(string title, int credits, string program, string instructor)
        {
            this.title = title;
            this.creditHours = credits;
            this.program = program;
            this.instructor = instructor;
        }
        public string GetTitle()
        {
            return title.ToUpper();
        }
    }
}
