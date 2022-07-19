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
        [TestCase("dulgvgzwqg", "gggdlquvwz")]
        [TestCase("gxtjtmtywr", "tttgjmrwxy")]
        [TestCase("hnlnxiupgt", "nnghilptux")]
        [TestCase("gzjotckivp", "cgijkoptvz")]
        [TestCase("dpwwsdptae", "ddppwwaest")]
        [TestCase("pcscpilknb", "ccppbiklns")]
        [TestCase("btvyhhmflf", "ffhhblmtvy")]
        [TestCase("artrtnqxcr", "rrrttacnqx")]
        [TestCase("nrtcmcoadn", "ccnnadmort")]
        [TestCase("fkdsgnekft", "ffkkdegnst")]
        [TestCase("wzenwebuau", "eeuuwwabnz")]
        [TestCase("vokfxzynwl", "fklnovwxyz")]
        [TestCase("neldfeyrxk", "eedfklnrxy")]
        [TestCase("wqadfiodgs", "ddafgioqsw")]
        [TestCase("ykiuvzfcbc", "ccbfikuvyz")]
        [TestCase("qakmc", "ackmq")]
        [TestCase("rrtbk", "rrbkt")]
        [TestCase("vaixn", "ainvx")]
        [TestCase("wmpnj", "jmnpw")]
        [TestCase("uproi", "iopru")]
        [TestCase("btska", "abkst")]
        [TestCase("ejqwr", "ejqrw")]
        [TestCase("elwlg", "llegw")]
        [TestCase("oaoiy", "ooaiy")]
        [TestCase("hrqkn", "hknqr")]
        [TestCase("pzjim", "ijmpz")]
        [TestCase("njnfq", "nnfjq")]
        [TestCase("xyohs", "hosxy")]
        [TestCase("xqycs", "cqsxy")]
        [TestCase("beoax", "abeox")]
        [TestCase("afkso", "afkos")]
        [TestCase("bldit", "bdilt")]
        [TestCase("gwrys", "grswy")]
        public void Sort(string word, string expectedSortedWord)
        {
            var result = StringAlphabetBasedOnFrequency.Sort(new List<string>() { word });
            Assert.AreEqual(expectedSortedWord, result.First());
        }
    }
}