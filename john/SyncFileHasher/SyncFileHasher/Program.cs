using SmartFiles;
using System.Diagnostics;
// See https://aka.ms/new-console-template for more information

var testFilePath = "C:\\Repos\\class-projects\\SampleText\\12370.txt";
var testFile = new SmartFile(testFilePath);
Console.WriteLine(testFile.HashString);
var AllFiles = Directory.GetFiles("C:\\Repos\\class-projects\\SampleText\\");
//write a for each statement to iterate through files 1 at a time to construct SmartFile and print out its hash

//1. Create a StopWatch class and start it
//2. Create 100 Loop using for loop
//3. in each loop compute all file hashes syncronously
//4. out of the 100 loop, stop the stop watch
//5. print out the elapsed time from stop watch
Stopwatch sw = Stopwatch.StartNew();
for (int i = 0; i < 100; i++)
{
    foreach (var fileName in AllFiles)
    {
        var _temp = new SmartFile(fileName);
        Console.WriteLine($"{_temp.File.Name,-30} - {_temp.GetHashString()}");
    }
}

sw.Stop();
Console.WriteLine($"Elapse Time with Sync calls:{sw.ElapsedMilliseconds} ms");
