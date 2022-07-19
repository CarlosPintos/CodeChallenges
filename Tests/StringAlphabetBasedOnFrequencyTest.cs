using System.Collections.Generic;
using System.Linq;
using CodeChallenges;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class StringAlphabetBasedOnFrequencyTests
    {
        [TestCase("abaccadcc", "ccccaaabd")]
        [TestCase("xyzxy", "xxyyz")]
        public void Sort(string word, string expectedSortedWord)
        {
            var result = StringAlphabetBasedOnFrequency.Sort(new List<string>() { word });
            Assert.AreEqual(expectedSortedWord, result.First());
        }
    }
}