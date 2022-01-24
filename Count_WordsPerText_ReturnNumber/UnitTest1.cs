using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestTATA.Services;

namespace Count_WordsPerText_ReturnNumber
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow("Word,WORD. WoRd word test TEST tEstword", "word", 4)]
        [DataRow("word, w�rd. WORD.", "word", 2)]
        [DataRow("W�RD, W�rd w�rd W�RD", "word", 0)]
        public void TestMethod1(string text, string word, int expected)
        {

            TextService textServices = new TextService();
            
            var result = textServices.CountWordsFromText(text, word);
            
            Assert.AreEqual(expected, result);
        }
    }
}
