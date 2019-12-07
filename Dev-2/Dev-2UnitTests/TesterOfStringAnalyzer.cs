using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dev_2UnitTests
{
    /// <summary>
    /// TestClass for StringAnalyzer
    /// </summary>
    [TestClass]
    public class TesterOfStringAnalyzer
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
            var analyzer = new Dev_2.StringAnalyzer();
            Assert.AreEqual(0, analyzer.MaxOfIdenticalConsecutiveDigits(string.Empty));
        }

        [TestMethod]
        public void TestIdenticalDigits()
        {
            var analyzer = new Dev_2.StringAnalyzer();
            int expected = 1;
            string actual = "0123";
            Assert.AreEqual(expected, analyzer.MaxOfIdenticalConsecutiveDigits(actual));
        }

        [TestMethod]
        public void TestIdenticalDigitsStringWithLatinSymbols()
        {
            var analyzer = new Dev_2.StringAnalyzer();
            int expected = 2;
            string actual = "899abc";
            Assert.AreEqual(expected, analyzer.MaxOfIdenticalConsecutiveDigits(actual));
        }


        [TestMethod]
        public void TestIdenticalDigitsStringWithNoDigits()
        {
            var analyzer = new Dev_2.StringAnalyzer();
            int expected = 0;
            string actual = "abc";
            Assert.AreEqual(expected, analyzer.MaxOfIdenticalConsecutiveDigits(actual));
        }

        /// <summary>
        /// TestMethod for MaxOfIdenticalConsecutiveLatinSymbols method
        /// </summary>
        [TestMethod]
        public void TestIdenticalLatin_StringWithoutLatinLetters_0()
        {
            var analyzer = new Dev_2.StringAnalyzer();
            int expected = 0;
            string actual = "{-9481'";
            Assert.AreEqual(expected, analyzer.MaxOfIdenticalConsecutiveLatinSymbols(actual));
        }

        [TestMethod]
        public void TestIdenticalLatin_StringWithUpperCases_2()
        {
            var analyzer = new Dev_2.StringAnalyzer();
            int expected = 2;
            string actual = "AAbpod";
            Assert.AreEqual(expected, analyzer.MaxOfIdenticalConsecutiveLatinSymbols(actual));
        }

        [TestMethod]
        public void TestIdenticalLatin_StringWithDigits_3()
        {
            var analyzer = new Dev_2.StringAnalyzer();
            int expected = 3;
            string actual = "14912ZzZZZ";
            Assert.AreEqual(expected, analyzer.MaxOfIdenticalConsecutiveLatinSymbols(actual));
        }
        /// <summary>
        /// TestMethod for MaxOfNotIdenticalConsecutiveSymbols method
        /// </summary>
        [TestMethod]
        public void TestNotIdenticalSymbols_EmptyString_0()
        {
            var analyzer = new Dev_2.StringAnalyzer();
            int expected = 0;
            string actual = string.Empty;
            Assert.AreEqual(expected, analyzer.MaxOfNotIdenticalConsecutiveSymbols(actual));
        }

        [TestMethod]
        public void TestNotIdenticalSymbols_StringWithOneIdenticalSymbols_1()
        {
            var analyzer = new Dev_2.StringAnalyzer();
            int expected = 1;
            string actual = "aaaa";
            Assert.AreEqual(expected, analyzer.MaxOfNotIdenticalConsecutiveSymbols(actual));
        }

        [TestMethod]
        public void TestNotIdenticalSymbols_StringWithNoIdenticalDigits_4()
        {
            var analyzer = new Dev_2.StringAnalyzer();
            int expected = 4;
            string actual = "9481";
            Assert.AreEqual(expected, analyzer.MaxOfNotIdenticalConsecutiveSymbols(actual));
        }

        [TestMethod]
        public void TestNotIdenticalSymbols_StringWithLatinSumbols_5()
        {
            var analyzer = new Dev_2.StringAnalyzer();
            int expected = 5;
            string actual = "AAbpod";
            Assert.AreEqual(expected, analyzer.MaxOfNotIdenticalConsecutiveSymbols(actual));
        }

        [TestMethod]
        public void TestNotIdenticalSymbols_StringWithDigitsAndLatinSymbols_8()
        {
            var analyzer = new Dev_2.StringAnalyzer();
            int expected = 8;
            string actual = "14912ZzZZZ";
            Assert.AreEqual(expected, analyzer.MaxOfNotIdenticalConsecutiveSymbols(actual));
        }
    }
}
