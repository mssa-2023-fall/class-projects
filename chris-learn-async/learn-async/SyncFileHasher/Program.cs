using SmartFiles;

var testFilePath = "C:\\Users\\crodr\\source\\repos\\class-projects\\SampleText\\12370.txt";
var testFile = new SmartFile(testFilePath);
Console.WriteLine(testFile.HashString);
var AllFiles = Directory.GetFiles("C:\\Users\\crodr\\source\\repos\\class-projects\\SampleText\\");
//write a for each statement to iterate through files 1 at a time to construict SmartFile and print out its hash

int maxFileNameLength = AllFiles.Max(x => x.Length);
foreach (var fileName in AllFiles)
{
    var _temp = new SmartFile(fileName);
    Console.WriteLine($"{_temp.File.Name, -30} - {_temp.HashString}");
}