using System;
using System.Collections.Generic;
using System.Text;

namespace TDDInlamning1_MLarsson
{
   public abstract class GeometricThing
    {
        public float Perimeter { get; set; }
        public float Area { get; set; }

        /// <summary>
        /// Calculates the perimeter of a shape.
        /// </summary>
        /// <param name="thing"></param>
        /// <returns>The perimeter as a float.</returns>
        public abstract float GetPerimeter(GeometricThing thing);

        /// <summary>
        /// Calculates the area of a shape.
        /// </summary>
        /// <param name="thing"></param>
        /// <returns>The area as a float.</returns>
        public abstract float GetArea(GeometricThing thing);
    }
}
