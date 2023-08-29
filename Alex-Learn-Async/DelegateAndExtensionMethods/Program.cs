
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

        List<SmartFile> bigFiles = Filter<SmartFile>(allSmartFiles,(sf)=>sf.File.Length>300*1024);
        PrintList(bigFiles, (afile) => Console.WriteLine($"{afile.File.FullName} has {afile.File.Length} bytes of data"));

            // static void PrintList(List<T> inputList, Action<T>

            List<SmartFile> filesWithNumbersStart = Filter<SmartFile>(allSmartFiles,
                (sf) =>
                {
                    string initialLetter = sf.File.Name.Substring(0, 1);
                    return int.TryParse(initialLetter, out int x);
                }
                );
            PrintList(bigFiles, (afile) => Console.WriteLine($"{afile.File.FullName} has initial letter that is a number."));

            StreamReader sr = filesWithNumbersStart[0].File.OpenText();
            List<string> lines = new List<string>(sr.ReadToEnd().Split(new char[] { '\n' }));

        lines.Where(l => l.Length > 20).OrderBy(l => l.Length).Select((l, i) => new {Length=l.Length, l });

            var resultLines = Filter<string>(lines, l => l.Length > 20);
            PrintList(resultLines, (afile) => Console.WriteLine());

        }

    private static void PrintList<T>(List<T> inputList, Action<T> actionToPerform)
    {
        foreach (var file in inputList)
        { actionToPerform.Invoke(file); }
    }

    static List<T> Filter<T>(List<T> inputList, Func<T, bool> predicate)
    {
        List<T> result = new List<T>();
        foreach (var file in inputList)
        {
            if (predicate.Invoke(file)) { result.Add(file); }
        }
        return result;
    }


    /*static List<SmartFile> FilterFileSize(List<SmartFile> inputList)

         List<SmartFile> result = new List<SmartFile>();
       foreach (var file in inputList)
       {
           if (file.File.Length>200*1024) { result.Add(file); }  
        }
       return result;

      }*/

    static List<SmartFile> FilterFiles(List<SmartFile> inputList, Func<SmartFile, bool> predicate)
    {
        List<SmartFile> result = new List<SmartFile>();
        foreach (var file in inputList)
        {
            if (predicate.Invoke(file)) { result.Add(file); }
        }
        return result;
    }
    //Step 1: Add<T> to the end of method name to indicate this is a generic method
    //Step 2: replace all references to List<SmartFile> to List<T>

    /*     static List<SmartFile> FilterFilesByInitialLetter(List<SmartFile> inputList)
         {
              List<SmartFile> result = new List<SmartFile>();
              foreach (var file in inputList)
              {
                  if (int.TryParse(file.File.Name.Substring(0, 1), out int x)) { result.Add(file); }
              }
              return result;
          }*/
    /*void methodName(params, params ParamArrayAttribute,)
        returntype methodName(param1, param2)
        // accept a SmartFIle and return a boolean
        bool SomeMethod(SmartFile file) { //logic}
        (SmartFile aFile)=> aFile.File.Length>100*/

}