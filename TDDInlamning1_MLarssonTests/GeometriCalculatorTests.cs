using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDInlamning1_MLarsson;
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using TDDInlamning1_MLarsson.GeometricThings;

namespace TDDInlamning1_MLarsson.Tests
{
    [TestClass()]
    public class GeometriCalculatorTests
    {
        GeometriCalculator geoCal = new GeometriCalculator();
       
        [TestMethod()]
        [DataRow(3f, 2f, 6f)]
        public void GetSquareAreaTest(float width, float height, float expected)
        {
            GeometricThing square = new Square(width, height);
            var actual = geoCal.GetArea(square);
            Assert.AreEqual(expected, actual);
        }
    }
}