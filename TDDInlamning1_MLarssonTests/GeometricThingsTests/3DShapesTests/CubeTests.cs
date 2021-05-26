using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDInlamning1_MLarsson.GeometricThings;

namespace TDDInlamning1_MLarssonTests.GeometricThings
{
    [TestClass]
    public class CubeTests
    {
        [TestMethod]
        [DataRow(5f, 150f)]
        public void GetArea_CubeTest_PositiveResult(float side, float expected)
        {
            var cube = new Cube(side);
            var actual = cube.GetArea();
            Assert.AreEqual(actual, expected);
        }
        
        [TestMethod]
        [DataRow(0f, 0f)]
        [DataRow(-5f, 0f)]
        [DataRow(null, 0f)]
        public void GetArea_CubeTest_NegativeResult(float side, float expected)
        {
            var cube = new Cube(side);
            var actual = cube.GetArea();
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [DataRow(4f, 64f)]
        public void GetVolume_CubeTest_PositiveResult(float side, float expected)
        {
            var cube = new Cube(side);
            var actual = cube.GetVolume();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(0f, 0f)]
        [DataRow(-6f, 0f)]
        [DataRow(null, 0f)]
        public void GetVolume_CubeTest_NegativeResult(float side, float expected)
        {
            var cube = new Cube(side);
            var actual = cube.GetVolume();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(5f, 20f)]
        public void GetPerimeter_CubeTest_PositiveResult(float side, float expected)
        {
            var cube = new Cube(side);
            var actual = cube.GetPerimeter();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(0f, 0f)]
        [DataRow(-6f, 0f)]
        [DataRow(null, 0f)]
        public void GetPerimeter_CubeTest_NegativeResult(float side, float expected)
        {
            var cube = new Cube(side);
            var actual = cube.GetPerimeter();
            Assert.AreEqual(expected, actual);
        }
    }
}
