using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpellTheNumber.Tests
{
    [TestClass]
    public class SpellTheWordTest
    {
        [TestMethod]
        public void Test_For_Zero_Value()
        {
            var result = NumberSpelling.ToSpell(0);
            Assert.AreEqual("Zero",result);
        }

        [TestMethod]
        public void Test_For_Negative_Value()
        {
            var result = NumberSpelling.ToSpell(-13456);
            Assert.AreEqual("Negative value not allowed and should be a whole number", result);
        }

        [TestMethod]
        public void Test_For_Positive_Value()
        {
            string Expected = "thirteen thousand four hundred and fifty six";
            var result = NumberSpelling.ToSpell(13456);
            Assert.AreEqual(Expected, result);
        }

        [TestMethod]
        public void Test_For_Tens_Value()
        {
            var result = NumberSpelling.ToSpell(77);
            Assert.AreEqual("seventy seven", result);
        }

        [TestMethod]
        public void Test_For_Hundreds_Value()
        {
            var result = NumberSpelling.ToSpell(770);
            Assert.AreEqual("seven hundred and seventy", result);
        }

        [TestMethod]
        public void Test_For_Thousands_Value()
        {
            var result = NumberSpelling.ToSpell(7707);
            Assert.AreEqual("seven thousand seven hundred and seven", result);
        }

        [TestMethod]
        public void Test_For_Million_Value()
        {
            var result = NumberSpelling.ToSpell(1113770);
            Assert.AreEqual("one million one hundred and thirteen thousand seven hundred and seventy", result);
        }
    }
}
