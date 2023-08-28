// See https://aka.ms/new-console-template for more information
using LeetCode;
using System.ComponentModel.DataAnnotations;
unchecked {
    int x = int.MaxValue + 1;
    Console.WriteLine(x);
}



IEnumerable<string> fileContent = File.ReadAllLines(@"C:\Users\victor\.gitconfig");

foreach (string aLine in fileContent) {
    Console.WriteLine(aLine);
}

IEnumerator<string> enumerator = fileContent.GetEnumerator();
while (enumerator.MoveNext())
{
    string aLine = enumerator.Current;
    Console.WriteLine(aLine);
}
string inputRandom = string.Join(" ",generateArray(10));
Console.WriteLine("Geoff" + Geoff(inputRandom)); 
static string HighAndLow(string numbers)
{
    string[] inputStrings = numbers.Split(" "); // split to string array
    int[] inputInts = Array.ConvertAll(inputStrings, s => int.Parse(s)); //convert string array to int array
    Array.Sort(inputInts); //why not just sort array
    return $"{inputInts[inputInts.Length - 1]} {inputInts[0]}";//pick the last and the first from the array
}

static string HighAndLow2(string numbers)
{
return $"{numbers.Split(" ").Select(c => int.Parse(c)).Max()} {numbers.Split(" ").Select(c => int.Parse(c)).Min()}";
}

static string[] generateArray(int count)
{
    Random random = new Random();
    string[] values = new string[count];

    for (int i = 0; i < count; ++i)
        values[i] = random.Next().ToString();

    return values;
}

static string Geoff(string numbers) {
    List<int> L = new List<int>();
    foreach (string x in numbers.Split(" ")) {
        L.Add(Convert.ToInt32(x));
    }
    Console.WriteLine($"{L.Max()} {L.Min()}");
    return $"{L.Max()} {L.Min()}";
}

static void Demo(ref int x) {
    x = x + 1;
}