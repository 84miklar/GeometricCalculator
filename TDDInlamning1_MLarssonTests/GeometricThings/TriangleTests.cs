using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDInlamning1_MLarsson.GeometricThings;
using System;
using System.Collections.Generic;
using System.Text;

namespace TDDInlamning1_MLarsson.GeometricThings.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        [DataRow(6f, 4f, 12f)]
        [DataRow(0f, 4f, 0f)]
        [DataRow(-6f, 4f, 0f)]
        [DataRow(-6f, -4f, 0f)]
        [DataRow(6.12345f, 4.12345f, 12.6249f)]
        [DataRow(null, null, 0f)]
        public void GetArea_TriangleTest(float tbase, float height, float expected)
        {
            GeometricThing triangle = new Triangle(tbase, height);
            var actual = triangle.GetArea(triangle);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(6f, 4f, 14f)]
        [DataRow(0f, 4f, 8f)]
        [DataRow(-6f, 4f, 0f)]
        [DataRow(6.123456789f, 4.123456789f, 14.3704f)]
        [DataRow(null, null, 0f)]
        public void GetPerimeter_TriangleTest(float tbase, float height, float expected)
        {
            GeometricThing triangle = new Triangle(tbase, height);
            var actual = triangle.GetPerimeter(triangle);
            Assert.AreEqual(expected, actual);
        }
    }
}