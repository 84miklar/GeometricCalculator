using System;
using System.Collections.Generic;
using System.Text;

namespace TDDInlamning1_MLarsson.GeometricThings
{
    public class Circle : GeometricThing
    {
        public float Radius { get; set; }
        public float Perimeter { get; set; }
        public float Area { get; set; }

        public Circle(float radius)
        {
            this.Radius = radius;
        }
    }
}
