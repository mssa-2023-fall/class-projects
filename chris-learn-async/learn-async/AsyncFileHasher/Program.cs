using SmartFiles;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

var AllFiles = Directory.GetFiles("C:\\Users\\crodr\\source\\repos\\class-projects\\SampleText\\");


//1-create a List<Task> called listOfComputeHashTank, use default constructor to initalize
//start the stopwatch
//2-create 100 iter for loop
//3-in each for loop iter create a foreach loop into AllFiles string[](each string represents a file path)
//4-Call the GetHashStringAsync() from the SmartFile instance we construct from file path
//5-add the Task to the ListOfComputeHashTank, do not await on it yet
//6- when all 100 loops finishes, call Task.WhenAll(List<Task>.ToArray)
//7- stop and print the elapsed time


List<Task> listOfComputeHashTask = new();

Stopwatch sw = Stopwatch.StartNew();
for (int i = 0; i < 100; i++)
{
    foreach (string filePath in AllFiles)
    {
        SmartFile file = new SmartFile(filePath);
        Task<string> hashTask = file.GetHashStringAsync();

        listOfComputeHashTask.Add(hashTask);
    }
}
await Task.WhenAll(listOfComputeHashTask);
sw.Stop();

Console.WriteLine($"Elapsed time with {listOfComputeHashTask.Count} async calls: {sw.ElapsedMilliseconds} ms");


