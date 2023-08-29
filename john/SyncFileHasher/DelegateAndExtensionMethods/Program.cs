using SmartFiles;

internal class Program
{
    private static void Main(string[] args)
    {
        var AllFiles = Directory.GetFiles("C:\\Users\\John\\source\\repos\\class-projects\\SampleText");

        List<SmartFile> allSmartFiles = new List<SmartFile>();
        foreach (var fileName in AllFiles)
        {
            allSmartFiles.Add(new SmartFile(fileName));
        }

        List<SmartFile> bigFiles = FilterFiles(allSmartFiles, (sf) => sf.File.Length > 200 * 1024);
        foreach(var bigFile in bigFiles)
        {
            Console.WriteLine($"{bigFile.File.FullName} has {bigFile.File.Length} bytes of data");
        }
        List<SmartFile> filterWithNumericStart = FilterFiles(allSmartFiles, (sf)=> { string initialLetter = sf.File.Name.Substring(0, 1);
            return int.TryParse(initialLetter, out int x);

        });
        foreach (var bigFile in bigFiles)
        {
            Console.WriteLine($"{bigFile.File.FullName} has initial letter that is a number");
        }
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
            if (predicate.Invoke(file))
            {
                result.Add(file);
            }
        }
        return result;
    }

    //add <T> to the end of the method name, this indicates that this is a generic method
    //replace all references to List<SmartFile> to List<T>
    static List<SmartFile> Filter<T>(List<SmartFile> inputList, Func<SmartFile, bool> predicate)
    {
        List<SmartFile> result = new List<SmartFile>();

        foreach (var file in inputList)
        {
            if (predicate.Invoke(file))
            {
                result.Add(file);
            }
        }
        return result;
    }
    /*
    static List<SmartFile> FilterFilesBySize(List<SmartFile> inputList)
    {
        List<SmartFile> result = new List<SmartFile>();
        foreach(var file in inputList)
        {
            if(file.File.Length > 200 * 1024) 
            {
                result.Add(file);
            }
        }
        return result;
    }
    */
    /*
    static List<SmartFile> FilterFilesByInitialLetter(List<SmartFile> inputList)
    {
        List<SmartFile> result = new List<SmartFile>();
        
        foreach (var file in inputList)
        {
            if (int.TryParse(file.File.Name.Substring(0, 1), out int x))
            {
                result.Add(file);
            }
        }
        return result;
    }
    */

}