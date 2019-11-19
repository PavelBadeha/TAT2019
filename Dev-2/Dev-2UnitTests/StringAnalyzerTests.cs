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
        public void TestIdenticalDigits_EmptyString_0()
        {
            Assert.AreEqual(0, analyzer.MaxOfIdenticalConsecutiveDigits(string.Empty));
        }

        [TestMethod]
        public void TestIdenticalDigits_0123_1()
        {
            Assert.AreEqual(1, analyzer.MaxOfIdenticalConsecutiveDigits("0123"));
        }

        [TestMethod]
        public void TestIdenticalDigits_899abc_2()
        {
            Assert.AreEqual(2, analyzer.MaxOfIdenticalConsecutiveDigits("899abc"));
        }


        [TestMethod]
        public void TestIdenticalDigits_abc_0()
        {
            Assert.AreEqual(0, analyzer.MaxOfIdenticalConsecutiveDigits("abc"));
        }

        /// <summary>
        /// TestMethod for MaxOfIdenticalConsecutiveLatinSymbols method
        /// </summary>
        [TestMethod]
        public void TestIdenticalLatin_EmptyString_0()
        {
            Assert.AreEqual(0, analyzer.MaxOfIdenticalConsecutiveLatinSymbols(string.Empty));
            Assert.AreEqual(0, analyzer.MaxOfIdenticalConsecutiveLatinSymbols("{-9481'"));
            Assert.AreEqual(2, analyzer.MaxOfIdenticalConsecutiveLatinSymbols("AAbpod"));
            Assert.AreEqual(3, analyzer.MaxOfIdenticalConsecutiveLatinSymbols("14912ZzZZZ"));
        }

        [TestMethod]
        public void TestIdenticalLatin_StringWithoutLetters_0()
        {
            Assert.AreEqual(0, analyzer.MaxOfIdenticalConsecutiveLatinSymbols("{-9481'"));
        }

        [TestMethod]
        public void TestIdenticalLatin_AAbpod_2()
        {
            Assert.AreEqual(2, analyzer.MaxOfIdenticalConsecutiveLatinSymbols("AAbpod"));
        }

        [TestMethod]
        public void TestIdenticalLatin_14912ZzZZZ_3()
        {
 
            Assert.AreEqual(3, analyzer.MaxOfIdenticalConsecutiveLatinSymbols("14912ZzZZZ"));
        }
        /// <summary>
        /// TestMethod for MaxOfNotIdenticalConsecutiveSymbols method
        /// </summary>
        [TestMethod]
        public void TestNotIdenticalSymbols_EmptyString_0()
        {
            Assert.AreEqual(0, analyzer.MaxOfNotIdenticalConsecutiveSymbols(string.Empty));
        }

        [TestMethod]
        public void TestNotIdenticalSymbols_aaaa_1()
        {
            Assert.AreEqual(1, analyzer.MaxOfNotIdenticalConsecutiveSymbols("aaaa"));
        }

        [TestMethod]
        public void TestNotIdenticalSymbols_9481_4()
        {
            Assert.AreEqual(4, analyzer.MaxOfNotIdenticalConsecutiveSymbols("9481"));
        }

        [TestMethod]
        public void TestNotIdenticalSymbols_AAbpod_5()
        {
            Assert.AreEqual(5, analyzer.MaxOfNotIdenticalConsecutiveSymbols("AAbpod"));
        }

        [TestMethod]
        public void TestNotIdenticalSymbols_14912ZzZZZ_8()
        {
            Assert.AreEqual(8, analyzer.MaxOfNotIdenticalConsecutiveSymbols("14912ZzZZZ"));
        }
    }
}
