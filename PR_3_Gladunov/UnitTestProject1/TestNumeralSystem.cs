using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class TestNumeralSystem
    {
        [TestClass]
        public class UnitTest1
        {
            [TestMethod]
            public void TestMethod1()
            {
                Numeral_System r = new Numeral_System();
                Assert.AreEqual("1011000", r.NumeralSystemCalc(2, "90"));
                Assert.AreEqual("133", r.NumeralSystemCalc(8, "90"));
                Assert.AreEqual("6A", r.NumeralSystemCalc(16, "90"));
            }
        }
    }
}
