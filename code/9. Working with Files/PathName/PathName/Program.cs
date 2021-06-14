using System;
using System.IO;

namespace PathName
{
    class Program
    {
        static void Main(string[] args)
        {
            //var path = @"c:\temp\folder1\HelloWorld.snl";
            var path = @"/Users/saqibali/Documents/git/csharp.snl";

            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);
            Console.WriteLine("Extension: {0}", extension);

            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("File Name: " + Path.GetFileName(path));
            Console.WriteLine("File Name without Extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directoy Name: " + Path.GetDirectoryName(path));

        }
    }
}