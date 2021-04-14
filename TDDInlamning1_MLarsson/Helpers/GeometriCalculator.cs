using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using System.Linq;
using TDDInlamning1_MLarsson.GeometricThings;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Collections;
using TDDInlamning1_MLarsson.Tests;

namespace TDDInlamning1_MLarsson
{
    public class GeometriCalculator
    {
        /// <summary>
        /// Help method to decide which
        /// shape type a GeometricThing is.
        /// Sends object to the correct GetArea method.
        /// </summary>
        /// <param name="thing"></param>
        /// <returns>0 if thing is null or not suitable, or area value. </returns>
        public float GetArea(GeometricThing thing)
        {
            if (thing != null)
            {
                if (thing is Rectangle)
                {
                    Rectangle rectangle = thing as Rectangle;
                    return rectangle.GetArea(thing);
                }
                if (thing is Square)
                {
                    Square square = thing as Square;
                    return square.GetArea(thing);
                }
                if (thing is Triangle)
                {
                    Triangle triangle = thing as Triangle;
                    return triangle.GetArea(thing);
                }
                if (thing is Circle)
                {
                    Circle circle = thing as Circle;
                    return circle.GetArea(thing);
                }
            }
            return 0;
        }

        /// <summary>
        /// Help method to decide which
        /// shape type a GeometricThing is. 
        /// Sends object to the correct GetPerimeter().
        /// </summary>
        /// <param name="thing"></param>
        /// <returns>0 if thing is null or not suitable, or perimeter value.</returns>
        public float GetPerimeter(GeometricThing thing)
        {
            if (thing != null)
            {
                if (thing is Rectangle)
                {
                    Rectangle rectangle = thing as Rectangle;
                    return rectangle.GetPerimeter(thing);
                }
                if (thing is Square)
                {
                    Square square = thing as Square;
                    return square.GetPerimeter(thing);
                }
                if (thing is Triangle)
                {
                    Triangle triangle = thing as Triangle;
                    return triangle.GetPerimeter(thing);
                }
                if (thing is Circle)
                {
                    Circle circle = thing as Circle;
                    return circle.GetPerimeter(thing);
                }
            }
            return 0;
        }

        /// <summary>
        /// Help method to loop through an array of shapes, and send it to GetPerimeter().
        /// </summary>
        /// <param name="thing"></param>
        /// <returns>0 if array is null, or the perimeter sum of all objects.</returns>
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
