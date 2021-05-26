namespace TDDInlamning1_MLarsson.GeometricThings
{
    using System;
    /// <summary>
    /// Class to handle the cylinder object
    /// </summary>
    public class Cylinder : GeometricThing
    {
        public Cylinder(float radius, float height)
        {
            Radius = radius;
            Height = height;
        }
        public float Height { get; set; }
        public float Radius { get; set; }
        public override float GetArea()
        {
            if (Radius > 0 && Height > 0)
            {
                var topAndBottomArea = GetTopAndBottomArea();
                var mantleArea = GetMantleArea();
                return Area = MathF.Round(topAndBottomArea + mantleArea, 2);
            }
            return 0;
        }

        public override float GetPerimeter()
        {
            return MathF.Round(Perimeter = Radius < 0 ? 0 : 2 * MathF.PI * Radius, 2);
        }

        public override float GetVolume()
        {
            Volume = Radius < 0 || Height < 0 ? 0 : MathF.Pow(Radius, 2) * MathF.PI * Height;
            return MathF.Round(Volume, 2);
        }

        /// <summary>
        /// Sends the mantle surface area of a cylinder to the rectangle class.
        /// </summary>
        /// <returns>Returns the area of the mantle surface.</returns>
        private float GetMantleArea()
        {
            var rectangle = new Rectangle(MathF.PI * Radius, Height);
            return 2 * rectangle.GetArea();
        }

        /// <summary>
        /// Sends the top and bottom circles of the cylinder to the circle class.
        /// </summary>
        /// <returns>The area of a circle times two.</returns>
        private float GetTopAndBottomArea()
        {
            var circle = new Circle(Radius);
            return 2 * circle.GetArea();
        }
    }
}
