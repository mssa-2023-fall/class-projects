using System;
using System.Collections.Immutable;
using System.Globalization;
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");
//int age = 50;
Console.WriteLine($"{int.MaxValue},{int.MinValue}");
Console.WriteLine($"{ushort.MaxValue}, {ushort.MinValue}");

Console.WriteLine($" float: {float.MinValue} , {float.MaxValue}");
Console.WriteLine($" double: {double.MaxValue}, {double.MinValue}");

Console.WriteLine($" decimal: {decimal.MaxValue}, {decimal.MinValue}");


//Strings
string s = "Hello \"World\"";
string s2 = "Hello \"World\"";
//RETURNS TRUE
Console.WriteLine(s ==  s2);
//RETURNS FALSE

Demo d1 = new Demo() { x = 10 };
Demo d2 = new Demo() { x = 10 };

d1.A();
Console.WriteLine(d1 == d2);
Console.WriteLine();


StringDemo();

/*
bool x = default;
int y = default;
DateTime d = default;
d.AddDays(-100);
Console.WriteLine(x);

*/

//Enum
if (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday)
{
    Console.WriteLine("Today is Tuesday");
}




Console.ReadLine();

//Demonstration of the stack working through its (LAST IN, FIRST OUT) basis.
//(In order) A calls B, B calls C, C calls B, B calls A, output.



/*
//Interfaces
InterfaceDemo();
void InterfaceDemo()
{
    Person[] ppl = {
        new Person { Age = 30, Name = "Bob" }, 
        new Person { Age = 20, Name = "Alice" }, 
        new Person { Age = 22, Name = "Jorge" } }; 
    Array.Sort(IComparable(ppl));
}

Array IComparable(Person[] ppl)
{
    throw new NotImplementedException();
}
*/
void StringDemo()
{
    string testString = "abc";
    Console.WriteLine(testString);
    string newString = String.Concat(testString, "123");
    Console.WriteLine(newString);
    String.Concat(testString, "123");
    Console.WriteLine(testString);
    testString.Concat("xyz");
    Console.WriteLine(testString);

    //
    string message1;

    //initialize to null
    string message2 = null;

    //Initialize as an empty string
    string message3 = System.String.Empty;

    //A property has no FOOTBALL ().... A METHOD has a FOOTBALL ()
    //RUNTIME ERROR Console.WriteLine(message2.Length);
    //COMPILETIME ERROR Console.WriteLine(message1.Length);
    //SHOULD GIVE A 0 Console.WriteLine(message3.Length);

    string oldPath = "c:\\Program Files\\Microsoft Visual Studio 8.0";
    //@ Symbol is used to avoid BACKSLASHING and specifically for file paths.
    string newPath = @"c:\Program Files\Microsoft Visual Studio 8.0";

    //var is called "Compiler inferred Type" If you hover over VAR the system will tell you what type it thinks your variable is.
    var temp = "I'm still a strongly-typed System.String!";
    //Using var for calling a new object in a class is PERFECT EXAMPLE (   var x = new Car();   )

    //const. Used to avoid other developers from changing IMPORTANT VARIABLES
    //Reduces MEMORY LOAD. A good optimizer
    const string message4 = "You cannot change me again";

    Console.WriteLine();
    char[] letters = { 'A', 'B', 'C', };
    Demo[] bunchOfDemos = { new Demo { x = 10 }, new Demo { x = 100 }, new Demo { x = 1000 } }; // { } is called an ARRAY INITIALIZER
    string alphabet = new string(letters);

    var ImTooLazy = alphabet.ToArray();
    Console.WriteLine(ImTooLazy);
    Console.WriteLine();
    //TOPLE...Initializes a bunch of variables without having to define individual lines.
    var jh = (firstname: "Jupiter", lastname: "Hammon", born: 1711, published: 1761);

    Console.WriteLine($"{jh.firstname} {jh.lastname} was that dude"); Console.WriteLine($"{jh.firstname} was born in the year {jh.born}");
    Console.WriteLine($"Will be over {Math.Round((2018d - jh.born) / 100d) * 100d} years old");


    string s3 = "Visual C$ Express";
    Console.WriteLine(s3.Substring(7, 2));

    int index = s3.IndexOf("C");
    //index = 7
    string s5 = "Printing backwards";

    //PRINTING backwards. Index starts at 0 (i). i is less than the total length of s5. i 
    //I NEED MORE UNDERSTANDING ON THIS
    for (int i = 0; i < s5.Length; i++)
    {
        Console.Write(s5[s5.Length - i - 1]);
    }
    Console.WriteLine();
    string temptString = string.Empty;
    foreach (var aChar in s5.Reverse())
    {
        temptString += aChar;
    }

    DateTime independenceDay = Convert.ToDateTime("07/04/1976", new CultureInfo("en-GB"));
    DateTime myDob = new DateTime(1975, 7, 15);
    DateTime result = myDob.AddYears(20);
    DateTime result2 = myDob.AddYears(300);
    DateTime today = DateTime.Today;
    TimeSpan howOldAmIToday = today.Subtract(myDob);
    Console.WriteLine();
    Console.WriteLine($"I am {howOldAmIToday.TotalDays} days old.");
    Console.WriteLine();
    Console.WriteLine($"How old am I? {howOldAmIToday} <-");
    DateTime aBadDay = today.Add(howOldAmIToday);
    Console.WriteLine();
    Console.WriteLine($"{aBadDay:d} is a bad day.");

    //TROUBLESHOOTING DATETIME
    if (DateTime.TryParse("07/15/1975", /*OUT means a new variable*/ out DateTime myDob2))
    {
        Console.WriteLine("It is a valid STRING for DATETIME");
    }
    var culture1 = new CultureInfo("en-US");
    Console.WriteLine(result);

    /*
    Console.WriteLine($"{"Culture Name", -20} | Calendar ");
    foreach (CultureInfo item in CultureInfo.GetCultures(CultureTypes.AllCultures)
    {

    }
    */

    
}


class Demo
{
    public int x { get; set; }
    
    internal void A()
    {
        int i = 0;
        Console.WriteLine("This is A before calling B");
        B();
        Console.WriteLine("This is A after calling B");
    }

    internal void B()
    {
        int j = 0;
        Console.WriteLine("This is B before calling C");
        C();
        Console.WriteLine("This is B after calling C");
    }
    internal void C()
    {
        int k = 0;
        Console.WriteLine("This is C");
    }
}

class Person
{
    public int Age { get; set; }

    public string Name { get; set; }
}