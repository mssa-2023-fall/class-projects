


using SmartFiles;

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

        List<SmartFile> bigFiles = Filter<SmartFile>(allSmartFiles,(sf)=> sf.File.Length>300*1024);
        
        ProcessList(bigFiles, (file) => Console.WriteLine(file.Name));
        // static void ProcessList(List<SmartFile> inputList, Action<SmartFile> actionToPerform)
        // we will be using this method to replace the repetitious foreach loop below
        foreach (var aFile in bigFiles)
        {
            Console.WriteLine($"{aFile.File.FullName} has {aFile.File.Length} bytes of data");
        }

        List<SmartFile> filesWithNumericStart = Filter<SmartFile>(allSmartFiles,
            (sf)=> {
                string initialLetter = sf.File.Name.Substring(0, 1);
                return int.TryParse(initialLetter, out int x);
                }
            );
        foreach (var aFile in filesWithNumericStart)
        {
            Console.WriteLine($"{aFile.File.FullName} has initial letter that is a number");
        }

        StreamReader sr = filesWithNumericStart[0].File.OpenText();
        List<string> lines = new List<string>(sr.ReadToEnd().Split(new char[] { '\n' }));
        var resultLines = Filter<string>(lines, l => l.Length > 20);
        foreach (var line in resultLines) { Console.WriteLine(line); }
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