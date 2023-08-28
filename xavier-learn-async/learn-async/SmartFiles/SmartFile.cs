using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SmartFiles {
    public class SmartFile {

        // ===== FIELDS =====
        private FileInfo _file;

        // ===== ATTRIBUTES =====
        public FileInfo File { get { return _file; } }
        public string HashString { get => this.GetHashString(); }
        public byte[] HashBytes { get => Convert.FromBase64String(this.HashString); }

        // ===== CONSTRUCTORS =====

        //create a constructor that accepts a string
        public SmartFile(string contents) {

            // in the constructor, instantiate _file FileInfo using the above string
            this._file = new FileInfo(contents);

        }

        public async Task<string> GetHashStringAsync() {
            string base64HashString = string.Empty;
            var fileStream = this._file.OpenRead();
            byte[] fileBytes = new byte[fileStream.Length];
            Task<int> readBytesFromFile = fileStream.ReadAsync(fileBytes, 0, (int)fileStream.Length);
            //other things i can do while readasync
            Console.WriteLine($"Reading bytes from {_file.Name}");
            //while ( !readBytesFromFile.IsCompleted ) {
            //    Console.WriteLine("Still reading...");
            //}
            int taskResult = await readBytesFromFile;
            Console.WriteLine($"{taskResult} bytes read from {_file.Name}");

            // now we are going to wrap a sync method into a async task because SHA1 does not
            // provide its own async method for compute
            var hasher = SHA1.Create();

            //this use Task.Run<T> to turn sync method ComputeHash into an awaitable task
            // notice the Func<byte[]> that is needed because the Task.Run<T> where
            // T=byte[] states our Func Delegate Lambda must return byte[]
            var computeHashTask = Task.Run<byte[]>(() => hasher.ComputeHash(fileBytes));

            // do something while the task is carried out
            Console.WriteLine($"Computing {_file.Name} hash value from byte[]");
            byte[] hashBytes = await computeHashTask;
            base64HashString = Convert.ToBase64String( hashBytes );

            return base64HashString;
        }

        public string GetHashString() {
            return GetHashStringAsync().Result;
        }

    }
}
