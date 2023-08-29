// See https://aka.ms/new-console-template for more information
using System.Collections.Concurrent;
using System.Diagnostics;
using SmartFiles;


string[] AllFile = Directory.GetFiles("C:\\Users\\aleja_a1mv85h\\source\\repos\\class-projects\\SampleText");
Console.WriteLine(AllFile.Length);
//1.create a list task called listofComputeHash, use the default constructor to initialize
ConcurrentBag<Task> listofComputeHash = new ();
Stopwatch sw = Stopwatch.StartNew();
//2.create 100 item for loop
for (int i = 0; i < 100; i++)
{
    foreach (var filePath in AllFile)
    {
        //3.in each loop item create a foreach loop into allFiles string[](each string represents a file path)
        ////4.call the GetHashStringAsyn() from the smartfile instacnce we construct from file path
        //5.add the Task to the List listof ComputeHashTask, do not await on it yet
        
        
        SmartFile smartFile = new SmartFile(filePath);
        Task<string> aTask = smartFile.GetHashStringAsync();
        listofComputeHash.Add(aTask);
    }
}
//6.wehn all 100 loops finishes, call Task.WhenAll(List<Task>.ToArray)
await Task.WhenAll(listofComputeHash);
//7.stop and print elapsed time
sw.Stop();
Console.WriteLine($"Elapsed time wtih {listofComputeHash.Count} Async: {sw.ElapsedMilliseconds}");