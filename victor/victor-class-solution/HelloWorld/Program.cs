// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//int age = 50;
Console.WriteLine($"int: {int.MaxValue},{int.MinValue}");
Console.WriteLine($"ushort: {ushort.MaxValue},{ushort.MinValue}");

Console.WriteLine($"float: {float.MaxValue},{float.MinValue}");
Console.WriteLine($"double: {double.MaxValue},{double.MinValue}");

Console.WriteLine($"decimal: {decimal.MaxValue},{decimal.MinValue}");

string s1 = "Hello \"World\"";
string s2 = "Hello \"World\"";
string s3 = s2 + ".";

Demo d1 = new Demo() { x=10 };
Demo d2 = new Demo() { x=10 };

d1.A();
Console.WriteLine(s1==s2);
Console.WriteLine(d1==d2);

StringDemo();

void StringDemo()
{
    string testString = "abc";
    Console.WriteLine(testString);
    string newString = String.Concat(testString, "123");
    Console.WriteLine(newString);
    var newString2 = new String(testString.Concat("xyz").ToArray());
    Console.WriteLine(newString2);

    string message1;

    // Initialize to null.
    string message2 = null;

    // Initialize as an empty string.
    // Use the Empty constant instead of the literal "".
    string message3 = System.String.Empty;
    //Console.WriteLine(message1.Length);//this is compile time error
    //Console.WriteLine(message2.Length);//this is runtime exception
    Console.WriteLine(message3.Length); // return 0 length string

    string oldPath = "c:\\Program Files\\Microsoft Visual Studio 8.0";
    string newPath = @"c:\Program Files\Microsoft Visual Studio 9.0";
    var temp = "I'm still a strongly-typed System.String!";
    // var is called "Compiler Inferred Type"

    const string message4 = "You can't get rid of me!";

    char[] letters = { 'A', 'B', 'C' };
    Demo[] bunchOfDemos = { 
        new Demo { x=10 }, 
        new Demo { x=100 }, 
        new Demo { x=1000 } // this {} is called object initializer
    };// { } is called array initializer
    string alphabet = new string(letters);
    char[] ImTooLazy = alphabet.ToArray();
    Console.WriteLine(alphabet[0]);

    string columns = "Column 1\tColumn 2\tColumn 3";
    //Output: Column 1        Column 2        Column 3

    string rows = "Row 1\r\nRow 2\r\nRow 3";
    /* Output:
        Row 1
        Row 2
        Row 3
    */

    string title = "\"The \u00C6olean Harp\", by Samuel Taylor Coleridge";
    Console.WriteLine(title);


    string singleLine = """Friends say "hello" as they pass by.""";
    Console.WriteLine(singleLine);
    
    string multiLine = """
    "Hello World!" is typically the first program someone writes.
    """;

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

    string rawStringLiteralDelimiter = """"
    Raw string literals are delimited 
    by a string of at least three double quotes,
    like this: """
    """";

    var jh = (firstName: "Jupiter", lastName: "Hammon", born: 1711, published: 1761);//tuple

    Console.WriteLine($"{jh.firstName} {jh.lastName} was an African American poet born in {jh.born}.");
    Console.WriteLine($"He was first published in {jh.published} at the age of {jh.published - jh.born}.");
    Console.WriteLine($"He'd be over {Math.Round((2018d - jh.born) / 100d) * 100d} years old today.");
    
    int X = 2;
    int Y = 3;

    var pointMessage = $$"""The point {{{X}}, {{Y}}} is {{Math.Sqrt(X * X + Y * Y)}} from the origin.""";

    Console.WriteLine(pointMessage);

    var pw = (firstName: "Phillis", lastName: "Wheatley", born: 1753, published: 1773);
    Console.WriteLine("{0} {1} was an African American poet born in {2}.", pw.firstName, pw.lastName, pw.born);
    Console.WriteLine("She was first published in {0} at the age of {1}.", pw.published, pw.published - pw.born);
    Console.WriteLine("She'd be over {0} years old today.", Math.Round((2018d - pw.born) / 100d) * 100d);

    Console.WriteLine(string.Format("{0} {1}", X, Y));// the old formatted string
    Console.WriteLine($"{X} {Y}"); // the new interpolation

    string s3 = "Visual C# Express";
    System.Console.WriteLine(s3.Substring(7, 2));
    // Output: "C#"

    System.Console.WriteLine(s3.Replace("C#", "Basic"));
    // Output: "Visual Basic Express"

    // Index values are zero-based
    int index = s3.IndexOf("C");
    // index = 7


    string s5 = "Printing backwards";

    for (int i = 0; i < s5.Length; i++)
    {
        System.Console.Write(s5[s5.Length - i - 1]);
    }

    foreach (var aChar in s5.Reverse())
    {
        Console.Write(aChar);
    }
}

class Demo {
    public int x { get; set; }
    internal void A() {
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