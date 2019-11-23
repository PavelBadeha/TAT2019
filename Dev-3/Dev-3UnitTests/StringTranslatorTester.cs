using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dev_3UnitTests
{
    [TestClass]
    public class StringTranslatorTester
    {
        [TestMethod]
        [DataRow("СКУЛ","school")]
        [DataRow("АЛФА", "Alfa")]
        public void TestMethodOfTranslateFromEnglishToRussian(string expected,string actual)
        {
            var translator = new Dev_3.StringTranslator();
            Assert.AreEqual(expected, translator.Translate(actual));
        }

        [TestMethod]
        [DataRow("!Азбука")]
        [DataRow("}Азбука")]
        [DataRow(null)]
        [DataRow("12@dq")]
        [DataRow("12{dq")]
        [DataRow("AzАя")]
        [DataRow("")]
        public void TestMethodOfTranslate_NoCorrectFormat_ThrowFormatException(string stringWithUnkownSymbols )
        {
            var translator = new Dev_3.StringTranslator();
            Action actual = () => translator.Translate(stringWithUnkownSymbols);

            Assert.ThrowsException<FormatException>(actual);
        }

        [TestMethod]
        [DataRow("ARBUZ","арбуз")]
        [DataRow("YAKOR","якорь")]
        public void TestMethodOfTranslateFromRussianToEnglish(string expected,string actual)
        {
            var translator = new Dev_3.StringTranslator();
            Assert.AreEqual(expected, translator.Translate(actual));
        }
    }
}
