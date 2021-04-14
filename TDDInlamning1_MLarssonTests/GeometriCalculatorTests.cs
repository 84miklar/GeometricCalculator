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
        [DataRow(new float[] { 5f, 6f, 5f, 6f, 6f }, 76.6991f)]
        [DataRow(new float[] { 0f, 0f, 5f, 6f, 6f }, 54.6991f)]
        public void GetPerimeter_SumArrayTest(float[] arr, float expected)
        {
            var geoThings = new GeometricThing[] {
                new Rectangle(arr[0], arr[1]),
                new Triangle(arr[2], arr[3]),
                new Circle(arr[4]) };
            var actual = geoCal.GetPerimeter(geoThings);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetPerimeterTest_NullArray()
        {
            float expected = 0;
            var actual = geoCal.GetPerimeter(new GeometricThing[] { });
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetPerimeter_ReciveNullObjectTest()
        {
            GeometricThing empty = null;
            var actual = geoCal.GetPerimeter(empty);
            var expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetArea_ReciveNullObjectTest()
        {
            GeometricThing empty = null;
            var actual = geoCal.GetArea(empty);
            var expected = 0;
            Assert.AreEqual(expected, actual);
        }
    }
}
