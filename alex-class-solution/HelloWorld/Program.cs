// See https://aka.ms/new-console-template for more information
using System.Numerics;

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
string s2 = sti;
Demo d12 = new Demo() { x = 10 };
Demo d2 = new Demo() { x = 10 };
Console.WriteLine(sti==s2);
Console.WriteLine(d12 == d2);

//stack based language. Stack popped off and returns to main.
// A>B>C C will finish and wil call to B and B will finish and call to A.
//Value type variable lists directly on the stack.
//Allocates a varible on stack and allocates the value on the heap. Reference on the heap.

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
