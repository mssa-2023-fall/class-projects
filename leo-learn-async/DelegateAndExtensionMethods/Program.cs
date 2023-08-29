


using System.Runtime.CompilerServices;
using SmartFiles;

internal static class ExtensionMethods 
{
    public static List<T> Filter<T>(this List<T> inputList, Func<T, bool> predicate) 
    { 
        List<T> result = new List<T>();
        foreach (var item in inputList) 
        { 
            if (predicate.Invoke(item)) { result.Add(item); }
        } 
        return result;
    } 
    public static void ProcessList<T>(this List<T> inputList, Action<T> actionToPerform) 
    { 
        foreach (var item in inputList) 
        {
            actionToPerform.Invoke(item);
        } 
    } 
}

internal class Program
{
    private static void Main(string[] args)
    {
        var AllFiles = Directory.GetFiles("C:\\MSSA projects\\class-projects\\SampleText\\");

        List<SmartFile> allSmartFiles = new List<SmartFile>();

        foreach (var fileName in AllFiles)
        {
            allSmartFiles.Add(new SmartFile(fileName));
        }

        allSmartFiles
            .Filter((sf) => sf.File.Length > 300 * 1024)
            .ProcessList((aFile) => Console.WirteLine($"{aFile.File.FullName} has {aFile.File.Length} bytes of data"));

        allSmartFiles
            .Filter((sf) =>
            {
                string initialLetter = sf.File.Name.Substring(0, 1);
                return int.TryParse(initialLetter, out int x);
            })
            .ProcessList((aFile) => Console.WriteLine($"{aFile.File.FullName} has initial letter that is a number"));




        //List<SmartFile> bigFiles = Filter<SmartFile>(allSmartFiles,(sf)=> sf.File.Length>300*1024);
        //ProcessList(bigFiles, (aFile) => Console.WriteLine($"{aFile.File.FullName} has {aFile.File.Length} bytes of data"));
        // static void ProcessList(List<SmartFile> inputList, Action<SmartFile> actionToPerform)
        // we will be using this method to replace the repetitious foreach loop below

            /*
            List<SmartFile> filesWithNumericStart = Filter<SmartFile>(allSmartFiles,
                (sf)=> {
                    string initialLetter = sf.File.Name.Substring(0, 1);
                    return int.TryParse(initialLetter, out int x);
                    }
                );
            ProcessList(bigFiles, (aFile) => Console.WriteLine($"{aFile.File.FullName} has initial letter that is a number"));

            StreamReader sr = filesWithNumericStart[0].File.OpenText();
            List<string> lines = new List<string>(sr.ReadToEnd().Split(new char[] { '\n' }));
            var resultLines = Filter<string>(lines, l => l.Length > 20);
            ProcessList(resultLines, (aLine) => Console.WriteLine());
            */
    }

    /*
    private static void ProcessList<T>(List<T> inputList, Action<T> actionToPerform)
    {
        foreach (var item in inputList)
        { actionToPerform.Invoke(item); }
    }
    */

    /// <summary>
    /// this makes multiple versions of Filter method obsolete
    /// We use a Func<T1,T2> as contract so the caller will provide a method implementation that accepts T1 and return T2
    /// </summary>
    /// <param name="inputList">this is a List of SmartFile</param>
    /// <param name="predicate">this is a Func<SmartFile,bool></param>
    /// <returns></returns>
    /*
    static List<SmartFile> FilterFiles(List<SmartFile> inputList, Func<SmartFile, bool> predicate)
    {
        List<SmartFile> result = new List<SmartFile>();
        foreach (var file in inputList)
        {
            if (predicate.Invoke(file)) { result.Add(file); }
        }
        return result;
    }
    */

    //Step 1: Add <T> to the end of method name to indicate this is a "Generic" method
    //Step 2: replace all reference to List<SmartFile> to List<T>
    /*
    static List<T> Filter<T>(List<T> inputList, Func<T, bool> predicate)
    {
        List<T> result = new List<T>();
        foreach (var file in inputList)
        {
            if (predicate.Invoke(file)) { result.Add(file); }
        }
        return result;
    }
    */
}