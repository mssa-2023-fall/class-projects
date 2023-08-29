// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
using Microsoft.VisualBasic;
using SmartFiles;

string testPath = "C:\\mssa-repos\\class-projects\\SampleText\\12378.txt";
var smartFile = new SmartFile(testPath);
Console.WriteLine(smartFile.HashString);

var allFiles = Directory.GetFiles("C:\\mssa-repos\\class-projects\\SampleText");

//Create stopwatch class
Stopwatch sw = Stopwatch.StartNew();
for (int i = 0; i < 100; i++)
{
    foreach (var fileName in allFiles)
    {
        var _temp = new SmartFile(fileName);
        Console.WriteLine($"{_temp.File.Name,-30} - {_temp.GetHashString()}");
    }
}
sw.Stop();
Console.WriteLine($"Elapsed time with sync calls: {sw.ElapsedMilliseconds}ms");
Console.ReadKey();
