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

        //create a constructor that accepts string 
        //in the constructor, instantiate _file FileInfo using the above string
        //use _file to read all bytes
        //use SHA1 to compute hash and assign it to HashBytes
        public SmartFile(string fileName)
        { 
            this._file = new FileInfo(fileName);
        }

        public async Task<string> GetHashStringAsync() {
            string base64HashString = string.Empty;
            var fileStrem = _file.OpenRead();
            byte[] fileBytes = new byte[fileStrem.Length];
            var readBytesFromFile = fileStrem.ReadAsync(fileBytes, 0, (int)fileStrem.Length);
            //other things I can do while the ReadAsync is performed
            Console.WriteLine($"Reading bytes from {_file.Name}");
            //while ( !readBytesFromFile.IsCompleted ) {
            //    Console.WriteLine($"Still Reading...");
            //}
            int taskResult = await readBytesFromFile;
            Console.WriteLine($"{taskResult} bytes read from {_file.Name}");

            //now we are going to wrap a sync method into an Async Task because SHA1 does not provide its own async methods for compute hash
            var hasher = SHA1.Create();
            
            Task<byte[]> computeHashTask = Task.Run<byte[]>( () => hasher.ComputeHash(fileBytes));
            //this use Task.Run<T> to turn sync method ComputeHash into an awaitable task
            //notice the Func<byte[]> that is needed because the Task.Run<T> where T= byte[] states our Func Delegate Lambda
            //must return byte[]

            //this is where we can do something while the task is carried out
            Console.WriteLine($"computing {_file.Name} hash value from byte[]");
            byte[] hashBytes = await computeHashTask;
            base64HashString = Convert.ToBase64String(hashBytes);
            return base64HashString;
        }
        public string GetHashString() { 
            return GetHashStringAsync().Result;
        }

    }
}