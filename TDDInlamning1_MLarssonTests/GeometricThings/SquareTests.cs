using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDInlamning1_MLarsson.Tests;
using System;
using System.Collections.Generic;
using System.Text;

namespace TDDInlamning1_MLarsson.Tests.Tests
{
    [TestClass()]
    public class SquareTests
    {
        [TestMethod()]
        [DataRow(0f, 0f)]
        [DataRow(-4f, 0f)]
        [DataRow(null, 0f)]
        public void GetArea_SquareTest_NegativeResult(float side, float expected)
        {
            GeometricThing square = new Square(side);
            var actual = square.GetArea(square);
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod()]
        [DataRow(4f, 16f)]
        [DataRow(4.123456789f, 17.0029f)]
        public void GetArea_SquareTest_PositiveResult(float side, float expected)
        {
            GeometricThing square = new Square(side);
            var actual = square.GetArea(square);
            Assert.AreEqual(expected, actual, 0.0001);
        }
        [TestMethod()]
        [DataRow(0f, 0f)]
        [DataRow(-4f, 0f)]
        [DataRow(null, 0f)]
        public void GetPerimeter_SquareTest_NegativeResult(float side, float expected)
        {
            GeometricThing square = new Square(side);
            var actual = square.GetPerimeter(square);
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod()]
        [DataRow(10f, 40f)]
        [DataRow(4.123456789f, 16.4938f)]
        public void GetPerimeter_SquareTest_PositiveResult(float side, float expected)
        {
            GeometricThing square = new Square(side);
            var actual = square.GetPerimeter(square);
            Assert.AreEqual(expected, actual, 0.0001);
        }
    }
}