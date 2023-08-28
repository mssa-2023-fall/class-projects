using SmartFiles;
using System.Diagnostics;

string testDirectory = "C:\\Users\\Xavier\\Desktop\\MSSA NOTES\\Victor\\Github_Examples\\SampleText\\";

string[] allFiles = Directory.GetFiles(testDirectory);

// 1 create a List<Task> called listOfComputeHashTask, use default constructor
// start stopwatch
// 2 create 100 iter for loop
// 3 in each for loop iter create a foreach loop into AllFiles string[](each string
// represents a file path)
// 4 call the GetHashStringAsync() from the SmartFile instance we construct from file path
// 5 add the task to the list listOfComputeHashTask, do not await on it yet
// 6 when all 100 loops finishes, call Task.WhenAll(List<Task>.ToArray)
// 7 stop and print elapsed time

List<Task> listOfComputeHashTask = new();

// create a stopwatch class and start it
Stopwatch sw = Stopwatch.StartNew();

// create 100 loop using for loop
for (int i = 0; i < 100; i++) {

    // in each loop compute all file hashes asynchronously
    foreach (var dir in allFiles) {
        SmartFile thisFile = new SmartFile(dir);
        Task<string> hashString = thisFile.GetHashStringAsync();
        listOfComputeHashTask.Add(hashString);
        Console.WriteLine($"{thisFile.File.Name,-30} hashed successfully");
    }

}

// make sure we join the tasks
await Task.WhenAll(listOfComputeHashTask.ToArray());

// out of the 100 loop, stop the stop watch
sw.Stop();

// print out the elapsed time
Console.WriteLine($"Elapsed async time: {sw.ElapsedMilliseconds}");