using System
using System.IO;

namespace FileAndFileInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\somefile.jpeg";

            File.Copy(@"...",@"...");
            File.Delete(path);

            if (File.Exists(path))
            {
                // Do something
            }

            var content = File.ReadAllText(path);

            var fileinfo = new FileInfo(path);
            fileinfo.CopyTo("...");
            fileinfo.Delete();

            if (fileinfo.Exists)
            {
                // Do something
            }

            fileinfo.OpenRead(); // create a file stream 

           
        }
    }
}
