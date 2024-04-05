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

            //позитивные
            Assert.IsTrue(tst(5, 1));
            Assert.IsTrue(tst(50, 2));
            Assert.IsTrue(tst(30, 3));
            Assert.IsTrue(tst(10, 4));
            Assert.AreEqual(answ(50), 4);
            int[] a = { 1, 33, 23, 5 };
            Assert.IsTrue(final(a));
            //негативные
            Assert.IsFalse(tst(11, 1));
            Assert.IsFalse(tst(1000, 1));
            Assert.IsFalse(tst(101, 1));
            Assert.IsFalse(tst(-1, 1));
            Assert.AreNotEqual(answ(50), 5);
            int[] v = { 11, 313, 23, 5 };
            Assert.IsFalse(final(v));
        }
    }
}
