using System;
using System.Collections.Generic;

namespace SummaryTextv1
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a very long santance";

            if (sentence.Length < 20)
                Console.WriteLine(sentence);
            else
            {
                var words = sentence.Split(" ");
                var totalCharacters = 0;
                var summaryWords = new List<string>();

                foreach (var word in words)
                {
                    summaryWords.Add(word);
                    totalCharacters += word.Length + 1;
                    if (totalCharacters > 20)
                        break;
                }
                var summary = String.Join(" ", summaryWords) + "... ";
                Console.WriteLine(summary);
            }
        }
    }
}
