using System;
using System.IO;

namespace DirectoryAndDirectoryInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Directory.CreateDirectory(@"c:\temp\folder1");
            Directory.CreateDirectory(@"/Users/saqibali/Documents/git/csharp/code/test");

            var files = Directory.GetFiles(@"/Users/saqibali/Documents/git/csharp/code", "*.sln", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

           

            var directories = Directory.GetDirectories(@"/Users/saqibali/Documents/git/csharp/code/", "*.*",
                SearchOption.AllDirectories);

            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }

            var directoryinfo = new DirectoryInfo(@"/Users/saqibali/Documents/git/csharp/code/");
            var directoriesinfo = directoryinfo.GetDirectories("*.*", SearchOption.AllDirectories);

            foreach (var directory in directoriesinfo)
            {
                Console.WriteLine(directory);
            }
        }
    }
}
