using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab_3;

namespace UnitTest
{
    [TestClass]
    public class TestTask2
    {
        [TestMethod]
        public void TestOneIsPos_34()
        {
            var t = new task2(30, 40);
            var expected = 34;

            var res = t.CalcSum();
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestZeroIsPos_0()
        {
            var t = new task2(1, 20);
            var expected = 0;

            var res = t.CalcSum();
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestTwoArePos_136()
        {
            var t = new task2(30, 110);
            var expected = 136;

            var res = t.CalcSum();
            Assert.AreEqual(expected, res);
        }
    }
}

