
using SmartFiles;
using System.Diagnostics;
// See https://aka.ms/new-console-template for more information

var testfilePath = "C:\\Users\\aleja_a1mv85h\\source\\repos\\class-projects\\SampleText\\12370.txt";
var testfile = new SmartFile(testfilePath);
Console.Write(testfile.HashString);
var AllFiles = Directory.GetFiles("C:\\Users\\aleja_a1mv85h\\source\\repos\\class-projects\\SampleText\\");

//write a for each statement to iterate through files 1 at the a time construct SmartFile and print out its hash.

//1. Create a Stopwatch and start it.
//2. Create 100 loops using for loop
//3. in each loop compute all file hashes synchroniously
//4. out of the 100 loops, stop the stopwatch 
//5. print out the elapsed time from the stop watch
Stopwatch watch = Stopwatch.StartNew();
for(int i = 0; i < 100; i++)
{
    
    foreach (var fileName in AllFiles)
    {
        var _temp = new SmartFile(fileName);
        Console.Write($"{_temp.File.Name,-30} - {_temp.GetHashString()}");
    }
}
watch.Stop();
Console.WriteLine($"Elapsed time this Sync calls:{watch.ElapsedMilliseconds}ms");

watch.Restart();




