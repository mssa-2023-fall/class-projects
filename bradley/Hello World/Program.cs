using System.Security.Cryptography;

Console.WriteLine("Hello, World!");

Console.WriteLine($"int: {int.MinValue},{int.MaxValue}");
Console.WriteLine($"ushort: {ushort.MinValue},{ushort.MaxValue}");

Console.WriteLine($"float: {float.MinValue},{float.MaxValue}");
Console.WriteLine($"double: {double.MinValue},{double.MaxValue}");

Console.WriteLine($"decimal: {decimal.MinValue},{decimal.MaxValue}");


string s1 = "Hello \"World\"";
string s2 = "Hello \"World\"";
Demo d1 = new Demo() { x = 10 };
Demo d2 = new Demo() { x = 10 };

d1.A();
Console.WriteLine(s1 == s2);
Console.WriteLine(d1 == d2);

StringDemo();

for(int i = 1; i<100; i++)
{
    var result = (i % 2 == 0) ? "even" : "odd";
    Console.WriteLine($" {i} + {result}");
}
void StringDemo()
{
    string testString = "abc";
    Console.WriteLine(testString);
    String.Concat(testString, "123");
    Console.WriteLine(testString);
    testString.Concat("xyz");
    Console.WriteLine(testString);
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


