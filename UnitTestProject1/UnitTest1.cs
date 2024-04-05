using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static ConsoleApp1.Program;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.IsTrue(tst(50, 1));
            Assert.IsFalse(tst(10, 1));
            Assert.AreEqual(answ(50), 4);
            Assert.IsTrue(tst(10, 1));
            Assert.IsFalse(tst(59, 1));
            Assert.AreEqual(answ(50), 5);
        }
    }
}
