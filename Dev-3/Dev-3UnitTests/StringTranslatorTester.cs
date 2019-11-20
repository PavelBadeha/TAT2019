using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dev_3UnitTests
{
    [TestClass]
    public class StringTranslatorTester
    {
        private Dev_3.StringTranslator translator = new Dev_3.StringTranslator();

        [TestMethod]
        public void TestMethodOfTranslate_StringEmpty_StringEmpty()
        {
            Assert.AreEqual(string.Empty, translator.Translate(string.Empty));
        }

        [TestMethod]
        public void TestMethodOfTranslate_school_russianSchool()
        {
            Assert.AreEqual("СКУЛ", translator.Translate("school"));
        }

        [TestMethod]
        public void TestMethodOfTranslate_alfa_russianAlfa()
        {
            Assert.AreEqual("АЛФА", translator.Translate("Alfa"));
        }

        [TestMethod]
        public void TestMethodOfTranslate_UnknownSymbolsRus_Exception()
        {
            try
            {
                translator.Translate("!Азбука");
            }
            catch
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void TestMethodOfTranslate_UnknownSymbolsRus2_Exception()
        {
            try
            {
                translator.Translate("}Азбука");
            }
            catch
            {
                Assert.IsTrue(true);
            }
        }
        [TestMethod]
        public void TestMethodOfTranslate_test_TEST()
        {
            string test = "тест";
            Assert.AreEqual("TEST", translator.Translate(test));
        }

        [TestMethod]
        public void TestMethodOfTranslate_UnknownSymbols_Exception()
        {
            try
            {
                translator.Translate("12@dq");
            }
            catch
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void TestMethodOfTranslate_UnknownSymbols2_Exception()
        {
            try
            {
                translator.Translate("12{dq");
            }
            catch
            {
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void TestMethodOfTranslate_StringWithEnglishAndRussianLettersTogether_Exception()
        {
            try
            {
                translator.Translate("AzАя");
            }
            catch
            {
                Assert.IsTrue(true);
            }
        }
    }
}
