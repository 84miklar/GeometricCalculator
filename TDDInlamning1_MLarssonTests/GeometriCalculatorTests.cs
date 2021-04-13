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
        [DataRow(0f, 2f, 0f)]
        [DataRow(-5f, 2f, 0f)]
        [DataRow(-5f, -2f, 0f)]
        [DataRow(5.1234567f, 2.1234567f, 10.8794f)]
        public void GetSquareAreaTest(float width, float height, float expected)
        {
            GeometricThing square = new Square(width, height);
            var actual = geoCal.GetArea(square);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(3f, 2f, 10f)]
        [DataRow(0f, 2f, 4f)]
        [DataRow(-5f, 2f, 0f)]
        [DataRow(-5f, -2f, 0f)]
        [DataRow(5.12345f, 2.12345f, 14.4938f)]
        public void GetSquarePerimeterTest(float width, float height, float expected)
        {
            GeometricThing square = new Square(width, height);
            var actual = geoCal.GetPerimeter(square);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(6f, 4f, 12f)]
        [DataRow(0f, 4f, 0f)]
        [DataRow(-6f, 4f, 0f)]
        [DataRow(-6f, -4f, 0f)]
        [DataRow(6.12345f, 4.12345f, 12.6249f)]
        public void GetTriangleAreaTest(float tbase, float height, float expected)
        {
            GeometricThing triangle = new Triangle(tbase, height);
            var actual = geoCal.GetArea(triangle);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(6f, 4f, 14f)]
        [DataRow(0f, 4f, 8f)]
        [DataRow(-6f, 4f, 0f)]
        [DataRow(6.123456789f, 4.123456789f, 14.3704f)]
        public void GetTrianglePerimeterTest(float tbase, float height, float expected)
        {
            GeometricThing triangle = new Triangle(tbase, height);
            var actual = geoCal.GetPerimeter(triangle);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(6f, 113.0973f)]
        [DataRow(0f, 0f)]
        [DataRow(-6f, 0f)]
        [DataRow(6.123456789f, 117.7994f)]

        public void GetCircleAreaTest(float radius, float expected)
        {
            GeometricThing circle = new Circle(radius);
            var actual = geoCal.GetArea(circle);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(null, 0f)]
        [DataRow(6f, 37.6991f)]
        [DataRow(0f, 0f)]
        [DataRow(-6f, 0f)]
        [DataRow(6.123456789f, 38.4748f)]
        public void GetCirclePerimeterTest(float radius, float expected)
        {
            GeometricThing circle = new Circle(radius);
            var actual = geoCal.GetPerimeter(circle);
            Assert.AreEqual(expected, actual);
        }


    }
}