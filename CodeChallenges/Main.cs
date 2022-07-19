using System;
using Faker;
using System.Collections.Generic;
using System.Linq;

namespace CodeChallenges
{
    public class Program
    {
        static void Main(string[] args)
        {
            var n = 50;
            StringAlphabetBasedOnFrequency.Sort(Faker.Lorem.Words(n).ToList()).ForEach(word =>
            {
                Console.WriteLine(word);
            });
        }
    }
}