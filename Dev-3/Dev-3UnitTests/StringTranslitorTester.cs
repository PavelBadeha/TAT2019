using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Dev_3UnitTests
{
    [TestClass]
    public class StringTranslitorTester
    {
        [TestMethod]
        [DataRow("СКУЛ","school")]
        [DataRow("АЛФА", "Alfa")]
        public void TestMethodOfTransliteFromEnglishToRussian(string expected,string actual)
        {
            var translitor = new Dev_3.StringTranslitor();
            Assert.AreEqual(expected, translitor.Translite(actual));
        }

        [TestMethod]
        [DataRow("!Азбука")]
        [DataRow("}Азбука")]
        [DataRow(null)]
        [DataRow("12@dq")]
        [DataRow("12{dq")]
        [DataRow("AzАя")]
        [DataRow("")]
        public void TestMethodOfTranslite_NoCorrectFormat_ThrowFormatException(string stringWithUnkownSymbols )
        {
            var translitor = new Dev_3.StringTranslitor();
            Action actual = () => translitor.Translite(stringWithUnkownSymbols);

            Assert.ThrowsException<FormatException>(actual);
        }

        [TestMethod]
        [DataRow("ARBUZ","арбуз")]
        [DataRow("YAKOR","якорь")]
        public void TestMethodOfTransliteFromRussianToEnglish(string expected,string actual)
        {
            var translitor = new Dev_3.StringTranslitor();
            Assert.AreEqual(expected, translitor.Translite(actual));
        }
    }
}
