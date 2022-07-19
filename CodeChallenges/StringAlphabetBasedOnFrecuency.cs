using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeChallenges
{
    public class StringAlphabetBasedOnFrequency
    {
       public static List<string> Sort(List<string> words)
        {
            var orderedString = new StringBuilder();
            var result = new List<string>();
            words.ForEach(word =>
            {
                orderedString.Clear();
                word
                    .GroupBy(ch => ch)
                    .Select(ch => new { chr = ch.Key, frequency = ch.Count() })
                    .OrderByDescending(item => item.frequency)
                    .ThenBy(item => item.chr)
                    .ToList().ForEach(item =>
                    {
                        orderedString.Append(new string(item.chr, item.frequency));
                    });
                result.Add(orderedString.ToString());
            });
            return result;
        }
    }
}