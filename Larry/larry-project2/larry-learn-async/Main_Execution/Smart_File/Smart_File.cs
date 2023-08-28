using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project2;



namespace Smart_File
{
    public class SmartFile
    {
        private FileInfo _file;
        public FileInfo File { get { return _file; } }
        public string HashString { get => Convert.ToBase64String(HashBytes); }
        public byte[] HashBytes { get; private set; }

        //create a constructor that accepts a string
        // in the constructor, instantiate _file FileInfo using the above string
        //use _file to read all bytes
        //use SHA1 to computer hash and assign it to HashBytes[] 

        public SmartFile(string fileName)
        {
            this._file = new FileInfo(fileName);
            using (var hasher = SHA1.Create())
            {

                HashBytes = hasher.ComputeHash(_file.OpenRead()); //sha1 produces 160bit=20byte
            }

        }
    }

}