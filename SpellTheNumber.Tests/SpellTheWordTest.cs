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
    }
}
