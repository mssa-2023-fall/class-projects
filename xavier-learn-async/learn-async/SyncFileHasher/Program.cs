using SmartFiles;
using System.Diagnostics;

string testFilePath = "C:\\Users\\Xavier\\Desktop\\MSSA NOTES\\Victor\\Github_Examples\\SampleText\\12370.txt";
string testDirectory = "C:\\Users\\Xavier\\Desktop\\MSSA NOTES\\Victor\\Github_Examples\\SampleText\\";

/*
SmartFile testFile = new SmartFile(testFilePath);

Console.WriteLine(testFile.HashString);
*/

var allFiles = Directory.GetFiles(testDirectory);

//write a for each statement to iterate through files 1 at a time to construct SmarFile
// and print out its hash

// create a stopwatch class and start it
// create 100 loop using for loop
// in each loop compute all file hashes synchronously
// out of the 100 loop, stop the stop watch
// print out the elapsed time

// create a stopwatch class and start it
Stopwatch sw = Stopwatch.StartNew();

// create 100 loop using for loop
for (int i = 0; i < 100; i++) {

    // in each loop compute all file hashes synchronously
    foreach (var dir in allFiles) {
        SmartFile thisFile = new SmartFile(dir);
        Console.WriteLine($"{thisFile.File.Name,-30} - {thisFile.HashString}");
    }

}
// out of the 100 loop, stop the stop watch
sw.Stop();

// print out the elapsed time
Console.WriteLine($"Elapsed sync time: {sw.ElapsedMilliseconds}");