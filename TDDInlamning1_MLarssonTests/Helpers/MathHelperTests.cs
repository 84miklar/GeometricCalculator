using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDInlamning1_MLarsson;
using System;
using System.Collections.Generic;
using System.Text;

namespace TDDInlamning1_MLarsson.Tests
{
    [TestClass()]
    public class MathHelperTests
    {
        [TestMethod()]
        [DataRow(1.123469f, 1.1235f)]
        public void NiceRoundTest_RoundUp(float side, float expected)
        {
            GeometricThing thing = new Square(side);
            var actual = thing.NiceRound(side);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(1.123439f, 1.1234f)]
        public void NiceRoundTest_RoundDown(float side, float expected)
        {
            GeometricThing thing = new Square(side);
            var actual = MathHelper.NiceRound(thing, side);
            Assert.AreEqual(expected, actual);
        }
    }
}