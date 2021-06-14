using System;
using System.Collections.Generic;

namespace SummaryTextv3
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a very long sentence";
            var summary = StringUtility.SummerizedText(sentence);
            Console.WriteLine(summary);
        }


    }
}


