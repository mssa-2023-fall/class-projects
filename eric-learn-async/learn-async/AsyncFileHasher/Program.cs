using System.Diagnostics;
using SmartFiles;

var allFiles = Directory.GetFiles("C:\\mssa-repos\\class-projects\\SampleText");
//1-create a List<Task> called listOfComputeHashTask, use default constructor to initialize

List<Task> listOfComputeHashTask = new();
//start the watch
Stopwatch sw = Stopwatch.StartNew();

//2-create 100 for loop
for (int i = 0; i < 100; i++)
{
    //3-in each for loop iter, create a foreach loop into AllFiles string[](each string represents a file path)
    foreach (string file in allFiles)
    {
        //4-Call the GetHashStringAsync() from the SmartFile instance we constructed from file path
        SmartFile temp = new SmartFile(file);
        Task.WhenAny(temp.GetHashStringAsync());
        //Task<string> task = temp.GetHashStringAsync();
        //listOfComputeHashTask.Add(task);
    }
}
Task.WhenAll(listOfComputeHashTask.ToArray());
sw.Stop();
Console.WriteLine($"Number of async calls {listOfComputeHashTask.Count} tasks");
Console.WriteLine(sw.ElapsedMilliseconds);



//5-add the Task to the List listOfComputeHashTask, do not await on it yet
//6-when all 100 loop finishes, call Task.WhenAll(List<Task>.ToArray)
//7-Stop and print elapsed time

//Create stopwatch class
