using SmartFiles;
using System.Diagnostics;

var testFilePath = "C:\\Users\\crodr\\source\\repos\\class-projects\\SampleText\\12370.txt";
var testFile = new SmartFile(testFilePath);
Console.WriteLine(testFile.HashString);
var AllFiles = Directory.GetFiles("C:\\Users\\crodr\\source\\repos\\class-projects\\SampleText\\");
//write a for each statement to iterate through files 1 at a time to construict SmartFile and print out its hash

//1. Create StopWatch class and start it.
//2. Create 100 loop using for loop.
//3. In each loop compute all file hashes synchronously
//4. Out of the 100 loop, stop the stopwatch.
//5. Print out the elapsed time from stopwatch.

Stopwatch sw = Stopwatch.StartNew();
for (int i = 0; i < 100; i++)
{
    foreach (var fileName in AllFiles)
    {
        var _temp = new SmartFile(fileName);
        Console.WriteLine($"{_temp.File.Name,-30} - {_temp.HashString}");
    }
}
sw.Stop();
Console.WriteLine($"Elapsed time {sw.ElapsedMilliseconds}");