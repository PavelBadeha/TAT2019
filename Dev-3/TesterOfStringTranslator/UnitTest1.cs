using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dev_3UnitTests
{
    [TestClass]
    public class UnitTests
    {
        private Dev_3.StringTranslator translator = new Dev_3.StringTranslator();

        [TestMethod]
        public void TestMethodOfTranslate_StringEmpty_StringEmpty()
        {
            Assert.AreEqual(string.Empty, translator.Translate(string.Empty));
        }

        [TestMethod]
        public void TestMethodOfTranslate_StringEmpty_()
        {
            Assert.AreEqual(string.Empty, translator.Translate(string.Empty));
        }
    }
}
