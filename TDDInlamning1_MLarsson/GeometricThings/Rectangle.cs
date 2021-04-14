using System;
using System.Collections.Generic;
using System.Text;

namespace TDDInlamning1_MLarsson.GeometricThings
{
   public class Rectangle : GeometricThing
    {
        public float Width { get; set; }
        public float Height { get; set; }
        public Rectangle(float width, float height)
        {
            this.Width = width;
            this.Height = height;
        }

        public override float GetPerimeter(GeometricThing thing)
        {
            Rectangle rectangle = thing as Rectangle;
            if (rectangle.Width < 0 || rectangle.Height < 0) return 0;

            rectangle.Perimeter = rectangle.Width * 2 + rectangle.Height * 2;
            return rectangle.NiceRound(rectangle.Perimeter);
        }

        public override float GetArea(GeometricThing thing)
        {
            Rectangle rectangle = thing as Rectangle;
            if (rectangle.Width <= 0 || rectangle.Height <= 0) return 0;

            rectangle.Area = rectangle.Width * rectangle.Height;
            return rectangle.NiceRound(rectangle.Area);
        }
    }
}
