using System;
using System.Collections.Generic;

namespace SummaryTextv2
{
        class Program
        {
            static void Main(string[] args)
            {
                var sentence = "This is going to be a very long sentence";
                var summary = SummerizedText(sentence);
                Console.WriteLine(summary);
            }

            static string SummerizedText(string text, int maxLength = 20)
            {
                if (text.Length < maxLength)
                    return (text);

                var words = text.Split(" ");
                var totalCharacters = 0;
                var summaryWords = new List<string>();

                foreach (var word in words)
                {
                    summaryWords.Add(word);
                    totalCharacters += word.Length + 1;
                    if (totalCharacters > maxLength)
                        break;
                }
                return (String.Join(" ", summaryWords) + "... ");
            }
        }
}


