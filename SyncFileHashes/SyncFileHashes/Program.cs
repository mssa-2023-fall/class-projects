using SmartFiles;
using System.Diagnostics;

var testFilePath = "C:\\Source\\Repos\\class-projects\\SampleText\\G-Acts.txt";
var testFile = new SmartFile(testFilePath);


//iterate through all files, compute hashes one at a time. Synchronously
var directory = Directory.GetFiles("C:\\Source\\Repos\\class-projects\\SampleText");

//1. Create stopwatch class and start it
//2. create 100 loop using for loop
// 3. in each loop commpute all file hashes sync
// 4. out of the 100 loop, stop the stop watchc
// 5. print out the elapsed time from stop watch
Stopwatch sw = Stopwatch.StartNew();
for (int i = 0; i < 100; i++)
{
	foreach (var fileName in directory)
	{
		//
		var _temp = new SmartFile(fileName);
		Console.WriteLine($"{_temp.File.Name,-30} - {_temp.GetHashString()}");
	}
}
sw.Stop();
Console.WriteLine($"Elapsed Time with Sync calls:{sw.ElapsedMilliseconds} ms");