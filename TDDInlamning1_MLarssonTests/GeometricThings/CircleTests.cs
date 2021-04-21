﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        [DataRow(0f, 0f)]
        [DataRow(-6f, 0f)]
        [DataRow(null, 0f)]
        public void GetArea_CircleTest_NegativeResult(float radius, float expected)
        {
            GeometricThing circle = new Circle(radius);
            var actual = circle.GetArea(circle);
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod()]
        [DataRow(6f, 113.0973f)]
        [DataRow(6.123456789f, 117.7994f)]
        public void GetArea_CircleTest_PositiveResult(float radius, float expected)
        {
            GeometricThing circle = new Circle(radius);
            var actual = circle.GetArea(circle);
            Assert.AreEqual(expected, actual, 0.0001);
        }
        [TestMethod()]
        [DataRow(0f, 0f)]
        [DataRow(-6f, 0f)]
        [DataRow(null, 0f)]
        public void GetPerimeter_CircleTest_NegativeResult(float radius, float expected)
        {
            GeometricThing circle = new Circle(radius);
            var actual = circle.GetPerimeter(circle);
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod()]
        [DataRow(6f, 37.6991f)]
        [DataRow(6.123456789f, 38.4748f)]
        public void GetPerimeter_CircleTest_PostiveResult(float radius, float expected)
        {
            GeometricThing circle = new Circle(radius);
            var actual = circle.GetPerimeter(circle);
            Assert.AreEqual(expected, actual, 0.0001);
        }
    }
}