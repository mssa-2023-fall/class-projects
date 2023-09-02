using System;
using System.Reflection.Metadata.Ecma335;

namespace Stuff
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Beginning Module 3 Lab: ");
            Console.ReadLine();
            //Begin
            //Create 2 functions that accept a string value but do not return value (void)
            var newInstructorName = SetInstructorName("Larry");
            var newCourseTitle = SetCourseTitle("Module 3");
            //If else
            /* if(newCourseTitle.Length <= 20)
            {
                Console.WriteLine("Course Title is less than or equal to 20");
            }
            else
            {
                Console.WriteLine("Successful");
            }
            */


            //Last read
            Console.ReadLine();
        }
        static void SetInstructorName(string instructorName)
        {
            Console.WriteLine($"{instructorName}");
        }
        static void SetCourseTitle(string courseTitle)
        {
            Console.WriteLine($"{courseTitle}");
            Console.WriteLine(ValidateCourseTitle(courseTitle));
        }
        static bool ValidateCourseTitle(string validateTitle)
        {
            return true;
        }
    }
}
