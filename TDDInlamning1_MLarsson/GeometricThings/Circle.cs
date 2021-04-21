namespace TDDInlamning1_MLarsson.GeometricThings
{
    using System;
    /// <summary>
    /// Class to handle the circle shape.
    /// </summary>
    public class Circle : GeometricThing
    {
        public Circle(float radius)
        {
            this.Radius = radius;
        }

        public float Radius { get; set; }

        public override float GetArea(GeometricThing thing)
        {
            Circle circle = thing as Circle;
            if (circle.Radius <= 0) return 0;

            circle.Area = MathF.Pow(circle.Radius, 2) * MathF.PI;
            return circle.Area;
            //return circle.NiceRound(circle.Area);
        }

        public override float GetPerimeter(GeometricThing thing)
        {
            Circle circle = thing as Circle;
            if (circle.Radius < 0) return 0;

            circle.Perimeter = circle.Radius * 2 * MathF.PI;
            return circle.Perimeter;
            //return circle.NiceRound(circle.Perimeter);
        }
    }
}
