
using SmartFiles;




internal class Program
{
    private static void Main(string[] args)
    {
        var AllFiles = Directory.GetFiles("C:\\Users\\aleja_a1mv85h\\source\\repos\\class-projects\\SampleText\\");

        List<SmartFile> allSmartFiles = new List<SmartFile>();

        foreach (var fileName in AllFiles)
        {
            allSmartFiles.Add(new SmartFile(fileName));
        }
        List<SmartFile> bigFiles = Filter(allSmartFiles,(sf)=>sf.File.Length>300*1024);
        foreach (var bigFile in bigFiles)
        {
            Console.WriteLine($"{bigFile.File.FullName} has {bigFile.File.Length} bytes of data");
        }
        List<SmartFile> filesWithNumbersStart = Filter(allSmartFiles,
            (sf) => { string initialLetter = sf.File.Name.Substring(0, 1);
                return int.TryParse(initialLetter, out int x);
            }
            );
        foreach (var bigFile in bigFiles)
        {
            Console.WriteLine($"{bigFile.File.FullName} has initial letter that is a number");
        }
    }
   /*  static List<SmartFile> FilterFileSize(List<SmartFile> inputList)

        List<SmartFile> result = new List<SmartFile>();
      foreach (var file in inputList)
      {
          if (file.File.Length>200*1024) { result.Add(file); }  
       }
      return result;
    
     }*/

    <summary>
        this makes multiple version of Filter method obsolete
        we use Fun


    /*static List<SmartFile> FilterFiles(List<SmartFile> inputList, Func<SmartFile,bool> predicate)
    {
        List<SmartFile> result = new List<SmartFile>();
        foreach (var file in inputList)
        {
            if (predicate.Invoke(file)) { result.Add(file); }
        }
        return result;
    }*/
    //Step 1: Add<T> to the end of method name to indicate this is a generic method
    //Step 2: replace all references to List<SmartFile> to List<T>
    static List<T> Filter<T>(List<T> inputList, Func<T, bool> predicate)
    {
        List<T> result = new List<T>();
        foreach (var file in inputList)
        {
            if(predicate.Invoke(file)) { result.Add(file); }
        }
        return result;
    }
  /*     static List<SmartFile> FilterFilesByInitialLetter(List<SmartFile> inputList)
       {
            List<SmartFile> result = new List<SmartFile>();
            foreach (var file in inputList)
            {
                if (int.TryParse(file.File.Name.Substring(0, 1), out int x)) { result.Add(file); }
            }
            return result;
        }*/
}