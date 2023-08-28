// See https://aka.ms/new-console-template for more information
using SmartFiles;
using System.Collections.Concurrent;
using System.Diagnostics;

string[] AllFiles = Directory.GetFiles("C:\\Users\\Xavier\\Desktop\\MSSA NOTES\\Victor\\Github_Examples\\SampleText\\");
//1-create a List<Task> called listOfComputeHashTask, use default constructor to initialize
//start the stop watch...
//2-create 100 iter for loop
//3-in each for loop iter create a foreach loop into AllFiles string[](each string represents a file path)
//4- Call the GetHashStringAsync() from the SmartFile instance we construct from file path
//5- add the Task to the List listOfComputeHashTask, do not await on it yet
//6- when all 100 loops finishes, call Task.WhenAll(List<Task>)
//7- Stop and print elapsed time

ConcurrentBag<Task> listOfComputeHashTask = new();

Stopwatch sw = Stopwatch.StartNew();
Parallel.For(0, 100, (int i) => {
    Console.WriteLine($"Loop number {i} started");
    {
        foreach (string filePath in AllFiles) {
            SmartFile smartFile = new SmartFile(filePath);
            Task<string> aTask = smartFile.GetHashStringAsync();

            listOfComputeHashTask.Add(aTask);


            Console.WriteLine($"{smartFile.File.Name,-30} - {aTask.Result}");
        }
    }
});
await Task.WhenAll(listOfComputeHashTask);
sw.Stop();
Console.WriteLine($"Elapse Time with Sync calls:{sw.ElapsedMilliseconds} ms");
Console.WriteLine(listOfComputeHashTask.Count);
