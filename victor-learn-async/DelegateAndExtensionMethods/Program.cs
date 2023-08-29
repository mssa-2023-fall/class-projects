


using SmartFiles;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

internal class Program
{
    private static void Main(string[] args)
    {
        var AllFiles = Directory.GetFiles("C:\\Repos\\class-projects\\SampleText");

        List<SmartFile> allSmartFiles = new List<SmartFile>();

        foreach (var fileName in AllFiles)
        {
            allSmartFiles.Add(new SmartFile(fileName));
        }

        allSmartFiles
            .Filter((sf) => sf.File.Length > 300 * 1024)
            .ProcessList((aFile) => Console.WriteLine($"{aFile.File.FullName} has {aFile.File.Length} bytes of data"));

        allSmartFiles.Filter(
            (sf) =>
            {
                string initialLetter = sf.File.Name.Substring(0, 1);
                return int.TryParse(initialLetter, out int x);
            }
            )
            .ProcessList((aFile) => Console.WriteLine($"{aFile.File.FullName} has initial letter that is a number"));


        StreamReader sr = allSmartFiles[0].File.OpenText();
        List<string> lines = new List<string>(sr.ReadToEnd().Split(new char[] { '\n' }));

        lines.Filter<string>(l => l.Length > 20).ProcessList((aLine) => Console.WriteLine(aLine));
    }

}

