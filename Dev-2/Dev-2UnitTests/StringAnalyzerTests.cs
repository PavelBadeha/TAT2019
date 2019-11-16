using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dev_2UnitTests
{
    /// <summary>
    /// TestClass for StringAnalyzer
    /// </summary>
    [TestClass]
    public class StringAnalyzerTests
    {
        /// <summary>
        /// Instance for StringAnalyzer
        /// </summary>
        private Dev_2.StringAnalyzer analyzer = new Dev_2.StringAnalyzer();

        /// <summary>
        /// TestMethod for MaxOfIdenticalConsecutiveDigits method
        /// </summary>
        [TestMethod]
        public void TestIdenticalDigits()
        {
            Assert.AreEqual(0,analyzer.MaxOfIdenticalConsecutiveDigits(""));
            Assert.AreEqual(1, analyzer.MaxOfIdenticalConsecutiveDigits("0123"));
            Assert.AreEqual(2, analyzer.MaxOfIdenticalConsecutiveDigits("899abc"));
            Assert.AreEqual(0, analyzer.MaxOfIdenticalConsecutiveDigits("abc"));
        }

        /// <summary>
        /// TestMethod for MaxOfIdenticalConsecutiveLatinSymbols method
        /// </summary>
        [TestMethod]
        public void TestIdenticalLatin()
        {
            Assert.AreEqual(0, analyzer.MaxOfIdenticalConsecutiveLatinSymbols(""));
            Assert.AreEqual(0, analyzer.MaxOfIdenticalConsecutiveLatinSymbols("{-9481'"));
            Assert.AreEqual(2, analyzer.MaxOfIdenticalConsecutiveLatinSymbols("AAbpod"));
            Assert.AreEqual(3, analyzer.MaxOfIdenticalConsecutiveLatinSymbols("14912ZzZZZ"));
        }

        /// <summary>
        /// TestMethod for MaxOfNotIdenticalConsecutiveSymbols method
        /// </summary>
        [TestMethod]
        public void TestNotIdenticalSymbols()
        {
            Assert.AreEqual(0, analyzer.MaxOfNotIdenticalConsecutiveSymbols(""));
            Assert.AreEqual(1, analyzer.MaxOfNotIdenticalConsecutiveSymbols("aaaa"));
            Assert.AreEqual(7, analyzer.MaxOfNotIdenticalConsecutiveSymbols("{-9481'"));
            Assert.AreEqual(5, analyzer.MaxOfNotIdenticalConsecutiveSymbols("AAbpod"));
            Assert.AreEqual(8, analyzer.MaxOfNotIdenticalConsecutiveSymbols("14912ZzZZZ"));
        }
    }
}
