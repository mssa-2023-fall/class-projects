using System.Diagnostics;
using SmartFiles;

var testFilePath = "C:\\MSSA projects\\class-projects\\SampleText\\12370.txt";
var testFile = new SmartFile(testFilePath);
Console.WriteLine(testFile.HashString);
var AllFiles = Directory.GetFiles("C:\\MSSA projects\\class-projects\\SampleText\\");
//write a for each statement to iterate through files 1 at a time to construict SmartFile and print out its hash
/*
int maxFileNameLength = AllFiles.Max(x => x.Length);
foreach (var fileName in AllFiles)
{
    var _temp = new SmartFile(fileName);
    Console.WriteLine($"{_temp.File.Name, -30} - {_temp.HashString}");
}
*/


//1. Create a WtopWatch Class and start it 
//2. Create 100 Loop using for loop
//3. In each loop compute all file hashes syncronosouly
//4. Out of the 100 loop, stop the stop watch
//5. print out the elapsed time from stop watch
Stopwatch sw = Stopwatch.StartNew();
for ( int i = 0; i < 100; i++)
{
    foreach( var filename in AllFiles)
    {
        var _temp = new SmartFile(filename);
        Console.WriteLine($"{_temp.File.Name,-30} - {_temp.HashString}");
    }
}
sw.Stop();
Console.WriteLine($"Elapse Time with Sync calls: {sw.ElapsedMilliseconds} ms");