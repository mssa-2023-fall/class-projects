using Smart_File;
using System;
using ASync_Await;
using File_Hasher;

namespace project2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            
            var testFilePath = @"C:\users\lol4l\source\repos\class-projects\SampleText\12370.txt";
            var testFile = new SmartFile(testFilePath);
            Console.WriteLine(testFile.HashString);
            var AllFiles = Directory.GetFiles(@"C:\users\lol4l\source\repos\class-projects\SampleText\");
            //write a foreach statement to iterate through files 1 at a time to construct SmartFile and print out its hash
            foreach(var fileName in AllFiles)
            {
                var _temp = new SmartFile(fileName);
                Console.WriteLine($"{_temp.File.Name,15} - {_temp.HashString}");
            }
        }
    }
}