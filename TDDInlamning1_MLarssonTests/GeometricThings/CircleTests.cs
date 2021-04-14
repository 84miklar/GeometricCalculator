using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDInlamning1_MLarsson.GeometricThings;
using System;
using System.Collections.Generic;
using System.Text;

namespace TDDInlamning1_MLarsson.GeometricThings.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        [DataRow(6f, 113.0973f)]
        [DataRow(0f, 0f)]
        [DataRow(-6f, 0f)]
        [DataRow(6.123456789f, 117.7994f)]
        [DataRow(null, 0f)]
        public void GetArea_CircleTest(float radius, float expected)
        {
            GeometricThing circle = new Circle(radius);
            var actual = circle.GetArea(circle);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(6f, 37.6991f)]
        [DataRow(0f, 0f)]
        [DataRow(-6f, 0f)]
        [DataRow(6.123456789f, 38.4748f)]
        [DataRow(null, 0f)]
        public void GetPerimeter_CircleTest(float radius, float expected)
        {
            GeometricThing circle = new Circle(radius);
            var actual = circle.GetPerimeter(circle);
            Assert.AreEqual(expected, actual);
        }
    }
}