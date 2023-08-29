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

        List<SmartFile> bigFiles = Filter<SmartFile>(allSmartFiles, (sf) => sf.File.Length > 300 * 1024);
        ProcessList(bigFiles, (aFile) => Console.WriteLine($"{aFile.File.FullName} has {aFile.File.Length} bytes of data"));
        // static void ProcessList(List<SmartFile> inputList, Action<SmartFile> actionToPerform)
        // we will be using this method to replace the repetitious foreach loop below

        List<SmartFile> filesWithNumericStart = Filter<SmartFile>(allSmartFiles,
            (sf) => {
                string initialLetter = sf.File.Name.Substring(0, 1);
                return int.TryParse(initialLetter, out int x);
            }
            );
        ProcessList(bigFiles, (aFile) => Console.WriteLine($"{aFile.File.FullName} has initial letter that is a number"));

        StreamReader sr = filesWithNumericStart[0].File.OpenText();
        List<string> lines = new List<string>(sr.ReadToEnd().Split(new char[] { '\n' }));
        var resultLines = Filter<string>(lines, l => l.Length > 20);
        ProcessList(resultLines, (aLine) => Console.WriteLine());
    }

    private static void ProcessList<T>(List<T> inputList, Action<T> actionToPerform)
    {
        foreach (var item in inputList)
        { actionToPerform.Invoke(item); }
    }




    //makes multiple versions of filter methods obsolute
    //use a Func<T1, T2> as a contract so that the caller will provide a method implementation that accepts T1 and returns T2
    //input list is a list of smartfiles
    //predicate is a Func<SmartFile>,bool>
    static List<SmartFile> FilterFiles(List<SmartFile> inputList, Func<SmartFile, bool> predicate)
    {
        List<SmartFile> result = new List<SmartFile>();
        foreach (var file in inputList)
        {
            if (predicate.Invoke(file)) { result.Add(file); }
        }
        return result;
    }
    

    //add <T> to the end of the method name, this indicates that this is a generic method
    //replace all references to List<SmartFile> to List<T>
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