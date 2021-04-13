using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using System.Linq;
using TDDInlamning1_MLarsson.GeometricThings;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Collections;

namespace TDDInlamning1_MLarsson
{
    public class GeometriCalculator
    {
        public float GetArea(GeometricThing thing)
        {
            if (thing is Square)
            {
                Square square = thing as Square;
                if (square.Width <= 0 || square.Height <= 0) return 0;

                return (float)Math.Round(square.Width * square.Height, 4);
            }
            if (thing is Triangle)
            {
                Triangle triangle = thing as Triangle;
                if (triangle.Base <= 0 || triangle.Height <= 0) return 0;

                return (float)Math.Round(triangle.Base * triangle.Height / 2, 4);
            }
            if (thing is Circle)
            {
                Circle circle = thing as Circle;
                if (circle.Radius <= 0) return 0;
                circle.Area = (float)(Math.Pow(circle.Radius, 2) * Math.PI);
                return (float)Math.Round(circle.Area, 4);
            }
            return 0;
        }

        public float GetPerimeter(GeometricThing thing)
        {
            if (thing is Square)
            {
                Square square = thing as Square;
                if (square.Width < 0 || square.Height < 0) return 0;

                return (float)Math.Round(square.Width * 2 + square.Height * 2, 4);

            }
            if (thing is Triangle)
            {
                Triangle triangle = thing as Triangle;
                if (triangle.Base < 0 || triangle.Height < 0) return 0;

                return (float)Math.Round(triangle.Base + triangle.Height * 2, 4);
            }
            if (thing is Circle)
            {
                Circle circle = thing as Circle;
                if (circle.Radius < 0) return 0;
                circle.Perimeter = circle.Radius * 2 * (float)Math.PI;
                return (float)Math.Round(circle.Perimeter, 4);
            }
            return 0;
        }
        public float GetPerimeter(GeometricThing[] thing)
        {
            if (thing != null)
            {
                float totalPerimeterOfShapes = 0;
                foreach (var shape in thing)
                {
                    totalPerimeterOfShapes += GetPerimeter(shape);
                }
                return totalPerimeterOfShapes;
            }
            return 0;
        }

    }
}
