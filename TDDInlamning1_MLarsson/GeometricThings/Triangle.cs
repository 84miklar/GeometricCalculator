using System;
using System.Collections.Generic;
using System.Text;

namespace TDDInlamning1_MLarsson.GeometricThings
{
    public class Triangle : GeometricThing
    {
        public float Base { get; set; }
        public float Height { get; set; }
        public Triangle(float tbase, float height)
        {
            this.Base = tbase;
            this.Height = height;
        }

        public override float GetPerimeter(GeometricThing thing)
        {
            Triangle triangle = thing as Triangle;
            if (triangle.Base < 0 || triangle.Height < 0) return 0;

            triangle.Perimeter = triangle.Base + triangle.Height * 2;
            return triangle.NiceRound(triangle.Perimeter);
        }

        public override float GetArea(GeometricThing thing)
        {
            Triangle triangle = thing as Triangle;
            if (triangle.Base <= 0 || triangle.Height <= 0) return 0;

            triangle.Area = triangle.Base * triangle.Height / 2;
            return triangle.NiceRound(triangle.Area);
        }
    }
}
