using System;
using System.Text;

namespace StringManipulateUpdated
{
    class Program
    {
        static void Main(string[] args)
        {

            var builder = new StringBuilder();
            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+')
                .Remove(0, 10)
                .Insert(0, new string('-', 10));
            Console.WriteLine(builder);

    
        }
    }
}
