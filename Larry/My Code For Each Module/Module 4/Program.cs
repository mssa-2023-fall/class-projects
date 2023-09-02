using System;
using System.Collections;

namespace Module4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
                2.Create an array of floating point values to represent a series of grades.
                3.Add grades to the array.
                4.Read grades from the array.
            */
            float[] myGrades = { 10, 20, 30, 40, 6, 60, 60, 40 };
            Console.WriteLine(myGrades[2]);
            Console.ReadLine();
            /*
                 2. Implement the System.Collections.Stack class.
                 3. Push values onto the stack.
                 4. Pop values from the stack.
            */
            //Push
            Stack myStack = new Stack();
            myStack.Push("Yo");
            myStack.Push("Wow");
            myStack.Push("Bro");
            myStack.Push("Oh");
            //Pop
            myStack.Pop();
            myStack.Pop();
            //Peek should show "Oh" minus 2. Shows "Wow"
            Console.WriteLine(myStack.Peek());
            Console.Write("");
            Console.ReadLine();

            /*
            2.  Create a new .Net SortedList object called myCourses.
            3.  Add the following values to the myCourses list.
            Key         Value
            CS101       Introduction to Computer Science
            CS102       Data Structures and Algorithm Analysis
            CS201       Introduction to Databases
            CS301       Introduction to Object - Oriented Programming
            4.  Read values from the list.
            5.  Remove values from the list.
            */
            SortedList myCourses = new SortedList();
            myCourses.Add("CS101", "Introduction to Computer Science");
            myCourses.Add("CS102", "Data Structures and Algorithm Analysis");
            myCourses.Add("CS201", "Introduction to Databases");
            myCourses.Add("CS301", "Introduction to Object - Oriented Programming");
            Console.WriteLine(myCourses["CS101"]);
            myCourses.Remove("CS102");
            Console.WriteLine(myCourses["CS102"]);
            //Won't show CS102
            Console.ReadLine();
            

        }
        // static void populateList()
    }
}