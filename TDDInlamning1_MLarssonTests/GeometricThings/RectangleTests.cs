﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDInlamning1_MLarsson.GeometricThings;
using System;
using System.Collections.Generic;
using System.Text;

namespace TDDInlamning1_MLarsson.GeometricThings.Tests
{
    [TestClass()]
    public class RectangleTests
    {
        [TestMethod()]
        [DataRow(3f, 2f, 6f)]
        [DataRow(0f, 2f, 0f)]
        [DataRow(-5f, 2f, 0f)]
        [DataRow(-5f, -2f, 0f)]
        [DataRow(5.1234567f, 2.1234567f, 10.8794f)]
        [DataRow(null, null, 0f)]
        public void GetArea_RectangleTest(float width, float height, float expected)
        {
            GeometricThing rectangle = new Rectangle(width, height);
            var actual = rectangle.GetArea(rectangle);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(3f, 2f, 10f)]
        [DataRow(0f, 2f, 4f)]
        [DataRow(-5f, 2f, 0f)]
        [DataRow(-5f, -2f, 0f)]
        [DataRow(5.12345f, 2.12345f, 14.4938f)]
        [DataRow(null, null, 0f)]
        public void GetPerimeter_RectangleTest(float width, float height, float expected)
        {
            GeometricThing rectangle = new Rectangle(width, height);
            var actual = rectangle.GetPerimeter(rectangle);
            Assert.AreEqual(expected, actual);
        }
    }
}