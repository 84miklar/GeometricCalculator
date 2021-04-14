using System;
using System.Collections.Generic;
using System.Text;

namespace TDDInlamning1_MLarsson.GeometricThings
{
    public class Circle : GeometricThing
    {
        public float Radius { get; set; }

        public Circle(float radius)
        {
            this.Radius = radius;
        }

        public override float GetPerimeter(GeometricThing thing)
        {
            Circle circle = thing as Circle;
            if (circle.Radius < 0) return 0;

            circle.Perimeter = circle.Radius * 2 * MathF.PI;
            return circle.NiceRound(circle.Perimeter);
        }

        public override float GetArea(GeometricThing thing)
        {
            Circle circle = thing as Circle;
            if (circle.Radius <= 0) return 0;

            circle.Area = MathF.Pow(circle.Radius, 2) * MathF.PI;
            return circle.NiceRound(circle.Area);
        }
    }
}
