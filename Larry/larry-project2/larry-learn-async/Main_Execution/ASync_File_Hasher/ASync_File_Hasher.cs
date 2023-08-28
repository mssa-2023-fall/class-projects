using SmartFiles;
using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace ASync_Await
{

    public class WeekendTasks
    {
        public string[] AllFiles = Directory.GetFiles(@"C:\Users\lol4l\source\repos\class-projects\Larry\larry-project2\larry-learn-async\SampleText\");


        public void WeekendTasks1()
        {
            //1-create a List<Task> called listOfComputeHashTask, use default constructor to initialize
            //start the stop watch...
            //2-create 100 iter for loop
            //3-in each for loop iter create a foreach loop into AllFiles string[](each string represents a file path)
            //4- Call the GetHashStringAsync() from the SmartFile instance we construct from file path
            //5- add the Task to the List listOfComputeHashTask, do not await on it yet
            //6- when all 100 loops finishes, call Task.WhenAll(List<Task>.ToArray)
            //7- Stop and print elapsed time


            for (int i = 0; i < 100; i++)
            {
                foreach (string filePath in AllFiles) 
                {

                }
            }

            Stopwatch sw = Stopwatch.StartNew();
        }

    }
}



