﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDInlamning1_MLarsson;
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using TDDInlamning1_MLarsson.GeometricThings;

namespace TDDInlamning1_MLarsson.Tests
{
    [TestClass()]
    public class GeometricCalculatorTests
    {
        GeometricCalculator geoCal = new GeometricCalculator();

        [TestMethod()]
        public void GetArea_ReciveNullObjectTest()
        {
            GeometricThing empty = null;
            var actual = geoCal.GetArea(empty);
            var expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(new float[] { 5f, 6f, 5f, 6f, 6f, 10f }, 258.0973f)]
        [DataRow(new float[] { 0f, 0f, 5f, 6f, 6f, 10f }, 228.0973f)]
        public void GetArea_SumArrayTest(float[] arr, float expected)
        {
            var geoThings = new GeometricThing[] {
                new Rectangle(arr[0], arr[1]),
                new Triangle(arr[2], arr[3]),
                new Circle(arr[4]),
                new Square(arr[5]) };
            var actual = geoCal.GetArea(geoThings);
            expected = CloseEnough(expected, actual);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetAreaTest_NullArray()
        {
            float expected = 0;
            var actual = geoCal.GetArea(new GeometricThing[] { });
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
        [DataRow(new float[] { 5f, 6f, 5f, 6f, 6f, 7f }, 104.6991f)]
        [DataRow(new float[] { 0f, 0f, 5f, 6f, 6f, 7f }, 82.6991f)]
        public void GetPerimeter_SumArrayTest(float[] arr, float expected)
        {
            var geoThings = new GeometricThing[] {
                new Rectangle(arr[0], arr[1]),
                new Triangle(arr[2], arr[3]),
                new Circle(arr[4]),
                new Square(arr[5]) };
            var actual = geoCal.GetPerimeter(geoThings);
            expected = CloseEnough(expected, actual);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetPerimeterTest_NullArray()
        {
            float expected = 0;
            var actual = geoCal.GetPerimeter(new GeometricThing[] { });
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Check if expected and actual are close enough to set as equal.
        /// </summary>
        /// <param name="expected"></param>
        /// <param name="actual"></param>
        /// <returns>expected float, set to actual if calculation was true.</returns>
        private static float CloseEnough(float expected, float actual)
        {
            if (MathHelper.NearlyEqual(actual, expected))
            {
                expected = actual;
            }
            return expected;
        }
    }
}
