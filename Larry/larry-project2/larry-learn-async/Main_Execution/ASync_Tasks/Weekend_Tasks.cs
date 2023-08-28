using Smart_File;
using System;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace ASync_Await
{
    public class WeekendTasks
    {
        SmartFile task1 = new SmartFile(fileName: "Filename");
        

        public async Task<string> GetHashStringAsync()
        {
            string base64HashString = string.Empty;
            var fileStrem = task1.File.OpenRead();
            byte[] fileBytes = new byte[fileStrem.Length];
            Task readBytesFromFile = fileStrem.ReadAsync(fileBytes, 0, (int)fileStrem.Length);
            ///other things I can do while the ReadAsync is performed
            Console.WriteLine($"Reading bytes from {task1.File.Name}");
            await readBytesFromFile;


            //now we are going to wrap a sync method into task because SHA1 does not provide its own async method
            var hasher = SHA1.Create();

            var computerHashTask = Task.Run<byte[]>( () => hasher.ComputeHash(fileBytes));
            ///this uses Task.Run<T> to turn sync method ComputeHash into an awaitable task
            ///notice the Func<byte>[]> that is needed because the Task.Run<T> 
            ///Where T= byte[] states our Func Delegate Lamda must return byte[]
            
            ///this is where we can do something while the task is carried out
            Console.WriteLine($"computing {task1.File.Name} hash value from byte[]");
            byte[] hashBytes = await computerHashTask;
            base64HashString = Convert.ToBase64String(hashBytes);
            return base64HashString;

        }
        public string GetHashString()
        {
            return GetHashStringAsync().Result;
        }
    }
}