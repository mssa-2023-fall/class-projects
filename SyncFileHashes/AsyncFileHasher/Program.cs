using SmartFiles;
using System.Diagnostics;

var AllFiles = Directory.GetFiles("C:\\Source\\Repos\\class-projects\\SampleText\\");

List<Task> listofComputeHashTask = new List<Task>();
Stopwatch sw = Stopwatch.StartNew();

for(int i = 0; i < 100; i++)
{
	foreach(var item in AllFiles)
	{
		var _temp = new SmartFile(item);
		listofComputeHashTask.Add(_temp.GetHashStringAsync());
	}
}
await Task.WhenAll(listofComputeHashTask);
sw.Stop();
Console.WriteLine($"Elapsed Time with Sync calls:{sw.ElapsedMilliseconds} ms");