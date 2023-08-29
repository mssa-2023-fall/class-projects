using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SmartFiles
{
    public class SmartFile
    {
        private FileInfo _file;

        public FileInfo File { get { return _file; } }

        public string HashString { get => this.GetHashString(); }

        public byte[] HashBytes { get => Convert.FromBase64String(HashString); }

        public SmartFile (string fileName)
        {
            _file = new FileInfo (fileName);
        }

        //this method is async. it will wait and eventually return a Task of type <string>
        //sync method would just return a string
        public async Task<string> GetHashStringAsync()
        {
            string base64HashString = String.Empty; ;
            var fileStream = _file.OpenRead();
            byte[] fileBytes = new byte[fileStream.Length];
            var readBytes = fileStream.ReadAsync(fileBytes, 0, fileBytes.Length);
            //other things I can do while the ReadAsync is performed
            Console.WriteLine($"Reading bytes from {_file.Name}..");
            //while (!readBytes.IsCompleted)
            //{
            //    Console.WriteLine("Still reading..");
            //}
            int taskResult = await readBytes;
            Console.WriteLine($"{taskResult} bytes read from {_file.Name}");
            // Task<int> means when the task is complete, you will get an int back from the method
            //wrap a sync method tinto a task because SHA1 does not provide its own async method
#pragma warning disable CA5350 // Do Not Use Weak Cryptographic Algorithms
            var hasher = SHA1.Create();
#pragma warning restore CA5350 // Do Not Use Weak Cryptographic Algorithms
            //Task.run is generic type, at the end, a byte[] is returned
            //Task.run expects a function
            //                                                 => given nothing "()" return hasher.ComputeHash
            Task<byte[]> computeHashTask = Task.Run<byte[]>(() => hasher.ComputeHash(fileBytes));
            //this use Task.Run<T> to turn sync method ComputeHash into an awaitable task
            //notice FUnc<byte[]> that is needed because the Task.Run<T> where T= byte[] states our Func Delegate Lambda
            //must return byte[]

            //this is where we can do something while the task is carried out
            Console.WriteLine($"Computing {_file.Name} hash value from byte[]");
            byte[] hashBytes = await computeHashTask;
            base64HashString= Convert.ToBase64String(hashBytes);

            return base64HashString;
        }

        public string GetHashString()
        {
            //cannot call async function in sync function unless you specify result
            //this blocks the async call, making it perform synchronously 
            return GetHashStringAsync().Result;
        }
    }
}
