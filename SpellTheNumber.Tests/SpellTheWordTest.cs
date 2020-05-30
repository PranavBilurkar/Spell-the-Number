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
    }
}
