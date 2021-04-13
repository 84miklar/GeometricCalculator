using System;
using System.Collections.Generic;
using System.Text;
using TDDInlamning1_MLarsson.GeometricThings;

namespace TDDInlamning1_MLarsson
{
    public class GeometriCalculator
    {
        public float GetArea(GeometricThing thing)
        {
            Square square = thing as Square;
            return square.Width * square.Height;
            
        }

        public void GetPerimeter(GeometricThing thing)
        {

        }
        public void GetPerimeter(GeometricThing[] thing)
        {

        }
    }
}
