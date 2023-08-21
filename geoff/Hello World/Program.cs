// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int Max = int.MaxValue;
int Min = int.MinValue;
uint UMax = uint.MaxValue;
uint UMin = uint.MinValue;
ushort uShortMin = ushort.MinValue;
ushort uShortMax = ushort.MaxValue;

Console.WriteLine($"Int Min, Max:{Min}, {Max}\n" +
                  $"UInt Min, Max: {UMin}, {UMax}\n" +
                  $"ushort Min, Max: {uShortMin}, {uShortMax}");

string s1 = "Hey";
string s2 = "Hey";

Demo d1 = new Demo() { x = 10 };
Demo d2 = new Demo() { x = 10 };

Console.WriteLine(s1 == s2);
Console.WriteLine(d1.x == d2.x);
d2.A();

class Demo
{
    public int x { get; set; }
    internal void A()
    {
        int i = 0;
        Console.WriteLine("A before calling B");
        B();
        Console.WriteLine("A after calling B");
    }
    internal void B()
    {
        int k = 0;
        Console.WriteLine("B before calling C");
        C();
        Console.WriteLine("B after calling C");
    }
    internal void C()
    {
        int l = 0;
        Console.WriteLine("This is C");
    }
}