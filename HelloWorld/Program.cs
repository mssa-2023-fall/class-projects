// See https://aka.ms/new-console-template for more information
using System.Numerics;
using System.Security.Cryptography;

Console.WriteLine("Hello, World!");
//int age = 39;
//Variable types
//Values below can break down into 0 and 1
/*
int maxInt = int.MaxValue;
byte age = 39;
short s = -150;
int i = int.MaxValue;
long l = long.MaxValue;
//Unsigned uses all positive values



//Compiler takes key words and match against something map to the framework date type. 
//Are all the same. byute short int long. Percise. Store exactly where you put it.



float f1 = float.MaxValue; //uses division to approximate the value
double d1 = double.MaxValue; //Runs faster
decimal c1 = decimal.MaxValue; //precise. using financial. Need to tolerate the bandwidth
float f2 = .0321654987654987f;
Console.WriteLine(f2);
*/


//8421
//0000
//1100 = 12

//assign a mathematical division to each bit.
//Min.Max values for differnt types of numbers.
Console.WriteLine($"{byte.MaxValue},{byte.MinValue}");
Console.WriteLine($"{int.MaxValue},{int.MinValue}");
Console.WriteLine($"{ushort.MaxValue},{ushort.MinValue}");
Console.WriteLine($"{double.MaxValue},{double.MinValue}");
Console.WriteLine($"{decimal.MaxValue},{decimal.MinValue}");
Console.WriteLine($"{float.MaxValue},{float.MinValue}");
//value type

//reference type - Pointer for another location. 

string sti = "Hello \"World\"";
string s2 = "Hello \"World\"";
string s3 = s2 + ".";
Demo d12 = new Demo() { x = 10 };
Demo d2 = new Demo() { x = 10 };
Console.WriteLine(sti==s2);
Console.WriteLine(d12 == d2);

//stack based language. Stack popped off and returns to main.
// A>B>C C will finish and wil call to B and B will finish and call to A.
//Value type variable lists directly on the stack.
//Allocates a varible on stack and allocates the value on the heap. Reference on the heap.

StringDemo();

void StringDemo()
{   //string immutability
    string testString = "abc";
    Console.WriteLine(testString);
    string newString = String.Concat(testString, "123");
    Console.WriteLine(newString);
    string newString2 = String.Concat("xyz");
    Console.WriteLine(newString2);

    // Declare without initializing.
    string message1 = "";

    // Initialize to null.
    //string message2 = null;

    // Initialize as an empty string.
    // Use the Empty constant instead of the literal "".
    string message3 = System.String.Empty;

    //string oldPath = "c\\Program Files\\Microsoft Visual Studio 8.0";
   // string newPat = @"C:\Program Files\Microsoft Visual Studio 9.0";

    //var temp = "I'm still a strongly-typed System.String";
    //var is called "Compiler Inffered Type"
    var x = new Demo();

    Console.WriteLine(message1.Length); //Compiler errorr
    //Console.WriteLine(message2.Length); //this is runtime exception
    Console.WriteLine(message3.Length); //this will give us 0

    //const optimizes memory usage.
    //const string message4 = "You can't get rid of me!"; //Modern projects, cant bank on the only person uses code.
    //intent of the value is not to be changed.

    char[] letters = { 'a', 'b', 'c' };
    Demo[] bunchofDemos = { 
        new Demo { x = 100 }, // { } initialize properties of the array.
        new Demo { x = 100 }, 
        new Demo { x = 1000 } 
    }; // { } is called and array initializer
    string alphaBet = new string(letters);
    char[] ImTooLazy = alphaBet.ToArray();
    Console.WriteLine(alphaBet[0]);

    string f2 = "A string is more ";
    string f3 = "than the sum of its char.";

    //Concat shorthand
    f2 += f3;

    string columns = "Column 1\tColumn 2\tColumn 3";
    //Output: Column 1        Column 2        Column 3

    //string rows = "Row 1\r\nRow 2\r\nRow 3";
    /* Output:
        Row 1
        Row 2
        Row 3
    */

    string title = "\"The \u00C6olean Harp\", by Samuel Taylor Coleridge";
    Console.WriteLine(title);

    //Output: "The Æolean Harp", by Samuel Taylor Coleridge

    string singleLine = """
    "Friends say "hello" as they pass by.
    """;
    Console.WriteLine(singleLine);
    string multiLine = """
    "Hello World!" is typically the first program someone writes.
    """;
    Console.WriteLine(multiLine);
    string embeddedXML = """
       <element attr = "content">
           <body style="normal">
               Here is the main text
           </body>
           <footer>
               Excerpts from "An amazing story"
           </footer>
       </element >
       """;
    // The line "<element attr = "content">" starts in the first column.
    // All whitespace left of that column is removed from the string.

    string rawStringLiteralDelimiter = """"
    Raw string literals are delimited 
    by a string of at least three double quotes,
    like this: """
    """";

    
    var jh = (firstName: "Jupiter", lastName: "Hammon", born: 1711, published: 1761); //tupple data carring vessel.
    //string interpolation
    Console.WriteLine($"{jh.firstName} {jh.lastName} was an African American poet born in {jh.born}.");
    Console.WriteLine($"He was first published in {jh.published} at the age of {jh.published - jh.born}.");
    Console.WriteLine($"He'd be over {Math.Round((2018d - jh.born) / 100d) * 100d} years old today.");


    int X = 2;
    int Y = 3;

    var pointMessage = $$"""The point {{{X}}, {{Y}}} is {{Math.Sqrt(X * X + Y * Y)}} from the origin.""";

    Console.WriteLine(pointMessage);
    // Output:
    // The point {2, 3} is 3.605551275463989 from the origin.

    Console.WriteLine(string.Format("{0} {1}", X, Y);
    Console.Write($"{X}, {Y}");

    string chopString = "Visual C# Express";
    System.Console.WriteLine(chopString.Substring(7, 2));

    string s5 = "Printing backwards";

    for (int i = 0; i < s5.Length; i++)//most performance but hard to say on a managed system. Profile the two 
        //various types of iterations. for and foreach. 
    {
        System.Console.Write(s5[s5.Length - i - 1]);
    }
    foreach (var item in s5.Reverse())
    {
        Console.Write(item);
    }
    // Output: "sdrawkcab gnitnirP"

    //

}

d12.A();

class Demo
{
    public int x { get; set; }
    internal void A()
    {
        B();
    }

    internal void B()
    {
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

// string s = "hello"; internal object called a string pool.
// s on the stack
// s1 new version is created and the pointer is reassigned.
// s = "hello";
// S = s + "123";
//s1 = "hello345";
// Garbage collection will wippe and unused.
//class contains: Objects
    //
