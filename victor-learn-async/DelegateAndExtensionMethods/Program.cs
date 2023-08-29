


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
            .Filter((sf)=> sf.File.Length>300*1024)
            .ProcessList((aFile) => Console.WriteLine($"{aFile.File.FullName} has {aFile.File.Length} bytes of data"));
        //ProcessList(bigFiles, (aFile) => Console.WriteLine($"{aFile.File.FullName} has {aFile.File.Length} bytes of data"));

        // static void ProcessList(List<SmartFile> inputList, Action<SmartFile> actionToPerform)
        // we will be using this method to replace the repetitious foreach loop below

        allSmartFiles.Filter(
            (sf)=> {
                string initialLetter = sf.File.Name.Substring(0, 1);
                return int.TryParse(initialLetter, out int x);
                }
            )
            .ProcessList((aFile) => Console.WriteLine($"{aFile.File.FullName} has initial letter that is a number"));
        //ProcessList(filesWithNumericStart, (aFile) => Console.WriteLine($"{aFile.File.FullName} has initial letter that is a number"));


        StreamReader sr = allSmartFiles[0].File.OpenText();
        List<string> lines = new List<string>(sr.ReadToEnd().Split(new char[] { '\n' }));

        lines.Filter<string>(l => l.Length > 20).ProcessList((aLine) => Console.WriteLine(aLine));
    }

    private static void ProcessList<T>(List<T> inputList, Action<T> actionToPerform)
    {
        foreach (var item in inputList)
        { actionToPerform.Invoke(item); }
    }

    /// <summary>
    /// this makes multiple versions of Filter method obsolete
    /// We use a Func<T1,T2> as contract so the caller will provide a method implementation that accepts T1 and return T2
    /// </summary>
    /// <param name="inputList">this is a List of SmartFile</param>
    /// <param name="predicate">this is a Func<SmartFile,bool></param>
    /// <returns></returns>
    static List<SmartFile> FilterFiles(List<SmartFile> inputList, Func<SmartFile, bool> predicate)
    {
        List<SmartFile> result = new List<SmartFile>();
        foreach (var file in inputList)
        {
            if (predicate.Invoke(file)) { result.Add(file); }
        }
        return result;
    }

    //Step 1: Add <T> to the end of method name to indicate this is a "Generic" method
    //Step 2: replace all reference to List<SmartFile> to List<T>
    static List<T> Filter<T>(List<T> inputList, Func<T, bool> predicate)
    {
        List<T> result = new List<T>();
        foreach (var file in inputList)
        {
            if (predicate.Invoke(file)) { result.Add(file); }
        }
        return result;
    }
}

