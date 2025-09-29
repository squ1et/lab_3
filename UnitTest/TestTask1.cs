using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab_3;

namespace UnitTest
{
    [TestClass]
    public sealed class TestTask1
    {
        [TestMethod]
        public void Test_0()
        {
            var t = new task1(28, 12, 32);
            var expected = 0;

            var res = t.GetNumOfMultiples();
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void Test_1()
        {
            var t = new task1(28, 12);
            var expected = 1;

            var res = t.GetNumOfMultiples();
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void Test_2()
        {
            var t = new task1(28);
            var expected = 2;

            var res = t.GetNumOfMultiples();
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void Test_3()
        {
            var t = new task1();
            var expected = 3;

            var res = t.GetNumOfMultiples();
            Assert.AreEqual(expected, res);
        }
    }
}
