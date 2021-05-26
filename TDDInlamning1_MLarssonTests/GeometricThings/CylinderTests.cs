namespace TDDInlamning1_MLarssonTests.GeometricThings
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TDDInlamning1_MLarsson.GeometricThings;
    [TestClass()]
    public class CylinderTests
    {
        [TestMethod]
        [DataRow(0f, 4f, 0f)]
        [DataRow(-5f, 4f, 0f)]
        [DataRow(5f, -4f, 0f)]
        [DataRow(50f, null, 0f)]
        public void GetArea_CylinderTest_NegativeResult(float radius, float height, float expected)
        {
            var cylinder = new Cylinder(radius, height);
            var actual = cylinder.GetArea();
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [DataRow(3f, 4f, 131.95f)]
        [DataRow(5.6f, 4.1f, 341.30f)]
        public void GetArea_CylinderTest_PositiveResult(float radius, float height, float expected)
        {
            var cylinder = new Cylinder(radius, height);
            var actual = cylinder.GetArea();
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [DataRow(0f, 10f, 0f)]
        [DataRow(-150f, 10f, 0f)]
        [DataRow(null, 10f, 0f)]
        public void GetPerimeter_CylinderTest_NegativeResult(float radius, float height, float expected)
        {
            var cylinder = new Cylinder(radius, height);
            var actual = cylinder.GetPerimeter();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(25f, 0f, 157.08f)]
        [DataRow(150f, 10f, 942.48f)]
        public void GetPerimeter_CylinderTest_PositiveResult(float radius, float height, float expected)
        {
            var cylinder = new Cylinder(radius, height);
            var actual = cylinder.GetPerimeter();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [DataRow(0f, 3f, 0f)]
        [DataRow(-3f, 3f, 0f)]
        [DataRow(3f, -3f, 0f)]
        [DataRow(null, 3f, 0f)]
        public void GetVolume_CylinderTest_NegativeResult(float radius, float height, float expected)
        {
            var cylinder = new Cylinder(radius, height);
            var actual = cylinder.GetVolume();
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [DataRow(3f, 2f, 56.55f)]
        [DataRow(5.2f, 3.43f, 291.37f)]
        public void GetVolume_CylinderTest_PositiveResult(float radius, float height, float expected)
        {
            var cylinder = new Cylinder(radius, height);
            var actual = cylinder.GetVolume();
            Assert.AreEqual(actual, expected);
        }
    }
}
