// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;
using System.Globalization;
using System.IO.Pipes;
using System.Linq.Expressions;

string projectName = "ACME";

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

Console.WriteLine("View English output: \n c:\Exercise\{0}\data.txt", projectName);
Console.WriteLine("\n{0}: \nc:\\Exercise\\{1}\\ru-RU\\data.txt", russianMessage, projectName);

int fahrenheit = 94;
double celsius = (fahrenheit - 32d) * (5d / 9d);

Console.WriteLine("The temperature is {0} Celsius.", celsius);

Console.WriteLine("Hello, World!");
Console.WriteLine($"int: {int.MaxValue},{int.MinValue}");
Console.WriteLine($"ushort: {ushort.MaxValue},{ushort.MinValue}");

Console.WriteLine($"float: {float.MaxValue},{float.MinValue}");
Console.WriteLine($"double: {double.MaxValue},{double.MinValue}");

Console.WriteLine($"decimal: {decimal.MaxValue},{decimal.MinValue}");

string s1 = "Hello \"World\"";
string s2 = "Hello \"World\"";
Demo d1 = new Demo() { x = 10 };
Demo d2 = new Demo() { x = 10 };

d1.A();
Console.WriteLine(s1 == s2);
Console.WriteLine(d1 == d2);

static string GetIntBinaryString(int n)
{
    char[] b = new char[32];
    int pos = 31;
    int i = 0;

    while (i < 32)
    {
        if ((n & (1 << i)) != 0)
        {
            b[pos] = '1';
        }
        else
            {
                b[pos] = '0';
            }
            pos--;
            i++;
        }
        return new string(b);
    Console.WriteLine(b);

}
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();


//
//
//
var cr = (firstName: "Chris", lastName: "Rodriguez", age: 27, yearOfBirth: 1996);
Console.WriteLine("{0} {1} is {2} years old and was born in {3}.", cr.firstName, cr.lastName, cr.age, cr.yearOfBirth);
Console.WriteLine($"{cr.firstName} {cr.lastName} is {cr.age} years old and was born in {cr.yearOfBirth}.");
//
//
//
string s5 = "Printing backwards";
for (int i = 0; i < s5.Length; i++)
{
    System.Console.Write(s5[s5.Length - i - 1]);
}
Console.WriteLine();
foreach (var item in s5.Reverse())
{
    Console.Write(item);
}
//
//
//
Console.WriteLine();
DateTime birthDay = Convert.ToDateTime("04/20/1996 7:32:37 AM", new CultureInfo("en-US"));
Console.WriteLine(birthDay);
DateTime myDOB = new DateTime(2019, 7, 25);
Console.WriteLine($"{myDOB:D}");
//
//
//
OperatorDemo();
void OperatorDemo()
{
    for (int i = 1; i <= 100; i++)
    {
        var result = (i % 2 == 0) ? "even" : "odd";
        Console.WriteLine($"{i} - {result}");
    }
}
//
//
//
switch (DateTime.Now.DayOfWeek)
{
    case DayOfWeek.Sunday:
        break;
    case DayOfWeek.Saturday:
        {
            Console.WriteLine("Have a good weekend!!");
        }
        break;
    default:
        {
            Console.WriteLine("Get back to work nerd!");
        }
        break;
}
//
//
//

//
//
//
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


